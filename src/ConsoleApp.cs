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
        PrintTextProperty("Prepositions", KlingonTextAnalysis.Prepositions, "yellow");
        PrintTextProperty("Verbs", KlingonTextAnalysis.Verbs, "red");
        PrintTextProperty("Verbs in First Person", KlingonTextAnalysis.VerbsInFirstPerson, "darkorange");
        PrintTextProperty("Vocabulary", KlingonTextAnalysis.Vocabulary, "green");
        PrintTextProperty("Beautiful Numbers", KlingonTextAnalysis.BeautifulNumbers, "blue");
    }

    void PrintTextProperty<T>(string displayName, T[] property, string colorTitle)
    {
        AnsiConsole.MarkupLine($"\n[bold {colorTitle}]{displayName} ({property.Length})[/]:");
        AnsiConsole.MarkupLine($"[white]{String.Join(' ', property)}[/]");
    }
}
