using System;
using System.Collections.Generic;
using System.IO;
using Spectre.Console;

class ConsoleApp
{
    const string _pasteOption = "A pasted text";
    const string _exitOption = "None. Exit";

    Dictionary<string, string> _mainMenuOptions;

    static void Main()
    {
        ConsoleApp app = new();
        app.Start();
    }

    public void Start()
    {
        CreateMainMenuOptions();

        while(true)
        {
            Console.Clear();

            var selectedText = MainMenu();

            if (selectedText == _exitOption)
                break;

            if (selectedText == _pasteOption)
                PrintTextAnalysis(AnsiConsole.Ask<string>("Paste your [blue]Klingon[/] text"));
            else
                PrintTextAnalysis(File.ReadAllText(selectedText));

            AnsiConsole.MarkupLine("\n[grey]Press anything to continue...[/]");
            Console.ReadKey();
        }
    }

    void CreateMainMenuOptions()
    {
        _mainMenuOptions = new();

        foreach (var file in Directory.GetFiles("texts"))
        {
            string fileName = String
                .Concat(file.Split(Path.GetInvalidFileNameChars()))
                .Replace("texts", "Text File ")
                .Replace(".txt", "");

            _mainMenuOptions.Add(fileName, file);
        }

        _mainMenuOptions.Add(_pasteOption, _pasteOption);
        _mainMenuOptions.Add(_exitOption, _exitOption);
    }
    
    string MainMenu()
    {
        var selectionPrompt = new SelectionPrompt<string>()
            .Title("What [bold green]Klingon Text[/] you want to analyze?")
            .PageSize(5);

        foreach(var option in _mainMenuOptions)
            selectionPrompt = selectionPrompt.AddChoice(option.Key);

        return _mainMenuOptions[AnsiConsole.Prompt(selectionPrompt)];
    }
    
    void PrintTextAnalysis(string text)
    {
        var KlingonTextAnalysis = new KlingonTextAnalysis(text);
        AnsiConsole.MarkupLine($"[bold yellow]Preposition Ammount[/]: [green]{KlingonTextAnalysis.Prepositions.Length}[/]");
        AnsiConsole.MarkupLine($"[bold yellow]Verb Ammount[/]: [green]{KlingonTextAnalysis.Verbs.Length}[/]");
        AnsiConsole.MarkupLine($"[bold yellow]First Person Verb Ammount[/]: [green]{KlingonTextAnalysis.VerbsInFirstPerson.Length}[/]");
        AnsiConsole.MarkupLine($"[bold yellow]Beautiful distinct numbers Ammount[/]: [green]{KlingonTextAnalysis.BeautifulNumbers.Length}[/]");
        AnsiConsole.MarkupLine($"[bold yellow]Vocabulary Ammount[/]: [green]{KlingonTextAnalysis.Vocabulary.Length}[/]");
    }
}
