using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Spectre.Console;

class App
{
    static void Main(string[] args)
    {
        Console.Clear();

        var prompt = new TextPrompt<string>("Which [green]text[/] you want to analyse?")
            .InvalidChoiceMessage("[red]This text is not valid[/]");

        Dictionary<string, string> textFiles = new();
        
        foreach (var file in Directory.GetFiles("texts"))
        {
            string fileName = String
                .Concat(file.Split(Path.GetInvalidFileNameChars()))
                .Replace("texts", "")
                .Replace(".txt", "");

            textFiles.Add(fileName, file);

            prompt = prompt.AddChoice(fileName);
        }

        prompt = prompt.DefaultValue(textFiles.First().Key);
        
        var selectedText = textFiles[AnsiConsole.Prompt(prompt)];
        var klingonText = new KlingonText(File.ReadAllText(selectedText));
        AnsiConsole.MarkupLine($"\n[bold yellow]Preposition Ammount[/]: [green]{klingonText.PrepositionCount}[/]");
        AnsiConsole.MarkupLine($"[bold yellow]Verb Ammount[/]: [green]{klingonText.VerbCount}[/]");
        AnsiConsole.MarkupLine($"[bold yellow]Beautiful distinct numbers Ammount[/]: [green]{klingonText.BeautifulDistinctNumbers.Length}[/]");
        AnsiConsole.MarkupLine($"[bold yellow]Vocabulary[/]: \n[green]{klingonText.Vocabulary}[/]");
    }
}
