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
        var klingonText = new KlingonText(File.ReadAllText(selectedText));
        AnsiConsole.MarkupLine($"\n[bold yellow]Preposition Ammount[/]: [green]{klingonText.PrepositionCount}[/]");
        AnsiConsole.MarkupLine($"[bold yellow]Verb Ammount[/]: [green]{klingonText.VerbCount}[/]");
        AnsiConsole.MarkupLine($"[bold yellow]First Person Verb Ammount[/]: [green]{klingonText.VerbInFirstPersonCount}[/]");
        AnsiConsole.MarkupLine($"[bold yellow]Beautiful distinct numbers Ammount[/]: [green]{klingonText.BeautifulDistinctNumbers.Length}[/]");
        AnsiConsole.MarkupLine($"[bold yellow]Vocabulary[/]: \n[green]{klingonText.Vocabulary}[/]");
    }
}
