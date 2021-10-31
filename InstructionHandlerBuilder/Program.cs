using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;

// `Encodings` is the comments above
// `Form` is the output function name (e.g. `AndGbEb` would be `GbEb` here)
//   ("no arg" handlers would use `_`)
[Serializable]
public record Handler(string[] Encodings, string Form);

[Serializable]
public class OutputFile
{
    // `TKey` is the classname
    // `TValue` is the handlers
    public Dictionary<string, List<Handler>> Classes = new();
}

[Serializable]
public class State
{
    public Dictionary<string, OutputFile> OutputFiles = new();
    public int Line = 0;
}

public class Program
{
    public static void Main()
    {
        string[] input = File.ReadAllLines("input.txt");

        State state;

        JsonSerializerOptions serializerOptions = new();
        serializerOptions.IncludeFields = true;
        serializerOptions.WriteIndented = true;

        if (File.Exists("state.json"))
            state = (State)JsonSerializer.Deserialize(File.ReadAllText("state.json"), typeof(State), serializerOptions)!;
        else
            state = new();

        ConsoleColor oldColor = Console.ForegroundColor;

        // minus 1 because the empty line at the end
        for (int i = state.Line; i < input.Length - 1; i++)
        {
            Debug.Assert(input[i].StartsWith("//"));

            int opcodeLineNum = i;
            while (input[opcodeLineNum].StartsWith("//"))
                opcodeLineNum++;

            // grab the encodings
            string[] encodings = new string[opcodeLineNum - i];
            Array.Copy(input, i, encodings, 0, encodings.Length);

            string opcode = input[opcodeLineNum];

            // extract the output class and function name from opcode
            (string classname, string operands) = GetClassAndOperandsFromOpcode(opcode);

            // fix up classname for all vector opcodes
            if (classname[0] == 'V')
                classname = Char.ToUpper(classname[1]) + classname.Substring(2); // remove the 'V'

            Handler handler = new(encodings, operands);

            for (int j = 0; j < 10; j++)
                Console.WriteLine();

            // print info for prompt
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            foreach (string comment in encodings)
                Console.WriteLine(comment);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(opcode);

            // by default, the class name is the filename, but prompt for a change
            string filename = classname;
            // except FMA opcodes
            if (filename.Contains("132") || filename.Contains("213") || filename.Contains("231"))
                filename = filename.Replace("132", "nnn").Replace("213", "nnn").Replace("231", "nnn");
            // except kmask manipulation opcodes
            if (filename[0] == 'K')
                filename = filename.Substring(0, filename.Length - 1); // drop the size suffix
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Place '{0}' inside '{1}.cs'?", operands, filename);

                Console.ForegroundColor = oldColor;
                Console.Write(" [Y/n] ");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();
                if (key.Key == ConsoleKey.Enter || key.Key == ConsoleKey.Y)
                    break;
                if (key.Key != ConsoleKey.N)
                    continue;

                Console.Write("Enter new filename (without '.cs'): ");
                filename = Console.ReadLine()!;
                if (filename != "")
                    break;
            }

            // V4FMADDxx will have the classname "4fmaddxx" which isn't allowed
            // just prefix with an underscore
            if (classname[0] == '4')
                classname = '_' + classname;

            AddHandler(state, filename, classname, handler);

            i = opcodeLineNum; // skip up to the line we last checked
            state.Line = i + 1; // set the new starting point for resuming

            // save state after every change
            File.WriteAllText("state.json", JsonSerializer.Serialize(state, typeof(State), serializerOptions));
        }


        // generate all the files!
        if (!Directory.Exists("output"))
            Directory.CreateDirectory("output");
        Thread.Sleep(5000);

        string template = File.ReadAllText("OutputFile.template");

        // build a file
        foreach (KeyValuePair<string, OutputFile> outputFile in state.OutputFiles)
            BuildAndSaveFile(template, outputFile.Key, outputFile.Value);
    }

    public static void AddHandler(State state, string filename, string className, Handler handler)
    {
        OutputFile file;
        if (state.OutputFiles.ContainsKey(filename))
            file = state.OutputFiles[filename];
        else
        {
            file = new();
            state.OutputFiles.Add(filename, file);
        }

        List<Handler> classHandlers;
        if (file.Classes.ContainsKey(className))
            classHandlers = file.Classes[className];
        else
        {
            classHandlers = new();
            file.Classes.Add(className, classHandlers);
        }

        classHandlers.Add(handler);
    }

    public static (string, string) GetClassAndOperandsFromOpcode(string opcode)
    {
        const string REGEX = @"([A-Z][a-z0-9]*)(.*)";
        GroupCollection matches = Regex.Match(opcode, REGEX).Groups;

        // $0 is the whole match
        // $1 is the mnemonic
        // $2 is the operands (if any)
        Debug.Assert(matches.Count == 3);

        string mnemonic = matches[1].Value;
        string operands = matches[2].Value;

        // if there's no operands, the function is named `_`
        if (operands == "")
            return (mnemonic, "_");
        return (mnemonic, operands);
    }

    public static void BuildAndSaveFile(string fileTemplate, string filename, OutputFile fileData)
    {
        // build a class
        StringBuilder classesStr = new();
        foreach (KeyValuePair<string, List<Handler>> classes in fileData.Classes)
        {
            // build a handler
            StringBuilder handlersStr = new();
            foreach (Handler handler in classes.Value)
            {
                handlersStr.Append("\r\n");
                foreach (string encoding in handler.Encodings)
                {
                    handlersStr.Append("    ");
                    handlersStr.Append(encoding);
                    handlersStr.Append("\r\n");
                }
                handlersStr.Append("    ");
                handlersStr.AppendFormat("public static void {0}(CpuCore cpu, Instruction instr) => throw new NotImplementedException();", handler.Form);
            }
            classesStr.AppendFormat("public static class {0}\r\n{{{1}\r\n}}\r\n", classes.Key, handlersStr.ToString());
        }

        string fileStr = fileTemplate;
        fileStr = fileStr.Replace("$1", filename);
        fileStr = fileStr.Replace("$2", classesStr.ToString());

        // ensure output directory exists
        string outputFolder = Path.Combine("output", filename[0].ToString());
        if (!Directory.Exists(outputFolder))
        {
            Directory.CreateDirectory(outputFolder);
            Thread.Sleep(1000);
        }

        // write the data
        File.WriteAllText(Path.Combine(outputFolder, filename + ".cs"), fileStr);
    }
}
