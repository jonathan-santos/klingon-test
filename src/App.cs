using System;
using System.IO;
using System.Collections.Generic;
using Spectre.Console;

class App
{
    static void Main(string[] args)
    {
        Console.Clear();

        var selectionPrompt = new SelectionPrompt<string>()
            .Title("Which [green]text[/] you want to analyse?")
            .PageSize(5);

        Dictionary<string, string> textFiles = new();
        
        foreach (var file in Directory.GetFiles("texts"))
        {
            string fileName = String
                .Concat(file.Split(Path.GetInvalidFileNameChars()))
                .Replace("texts", "")
                .Replace(".txt", "");

            textFiles.Add(fileName, file);

            selectionPrompt = selectionPrompt.AddChoice(fileName);
        }

        var selectedText = textFiles[AnsiConsole.Prompt(selectionPrompt)];
        var KlingonTextAnalysis = new KlingonTextAnalysis(File.ReadAllText(selectedText));
        AnsiConsole.MarkupLine($"[bold yellow]Preposition Ammount[/]: [green]{KlingonTextAnalysis.Prepositions.Length}[/]");
        AnsiConsole.MarkupLine($"[bold yellow]Verb Ammount[/]: [green]{KlingonTextAnalysis.Verbs.Length}[/]");
        AnsiConsole.MarkupLine($"[bold yellow]First Person Verb Ammount[/]: [green]{KlingonTextAnalysis.VerbsInFirstPerson.Length}[/]");
        AnsiConsole.MarkupLine($"[bold yellow]Beautiful distinct numbers Ammount[/]: [green]{KlingonTextAnalysis.BeautifulNumbers.Length}[/]");
        AnsiConsole.MarkupLine($"[bold yellow]Vocabulary Ammount[/]: [green]{KlingonTextAnalysis.Vocabulary.Length}[/]");
    }
}
