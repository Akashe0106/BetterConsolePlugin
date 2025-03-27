# Getting Started with BetterConsoleEN

Welcome to BetterConsoleEN! This guide will help you quickly get started with the library and explore its key features.

## Prerequisites

*   .NET Framework 4.8 or later

## Installation

1.  **Download the DLL:** Download the `BetterConsolePlugin.dll` file from the [Releases](LINK_TO_RELEASES) page.
2.  **Add Reference:** Add the DLL file as a reference to your .NET project.
3.  **Import Namespace:** Add the following line to your code file:

    ```csharp
    using BetterConsolePlugin;
    ```

## Basic Usage

### Writing Colored Text

```csharp
using BetterConsolePlugin;
using System;

AdvancedConsole console = new AdvancedConsole();
console.Write("Hello, World!", Event.Info, ConsoleColor.Green);
```

This code snippet will print "Hello, World!" to the console in green color, with an "INFO" event bracket.

### Creating a Table

```csharp
using BetterConsolePlugin;

Table table = new Table();
table.AddHeaders("Name", "Age", "City");
table.AddRow("John Doe", 30, "New York");
table.AddRow("Alice Smith", 25, "London");
table.Print();
```

This code will create and display a simple table with three columns and two rows.

### Creating a Menu

```csharp
using BetterConsolePlugin;
using System;
using System.Collections.Generic;

List<MenuItem> menuItems = new List<MenuItem>()
{
    new MenuItem("Start Game", () => Console.WriteLine("Game is starting..."), "Starts a new game"),
    new MenuItem("Exit", () => Environment.Exit(0), "Exits the application")
};

MenuCreate menu = new MenuCreate(menuItems);
menu.Create();
```

This code will create a basic menu with two options: "Start Game" and "Exit".

## Exploring More Features

BetterConsoleEN offers many more features to enhance your console applications. Explore the documentation for each class to learn more:

*   [AdvancedConsole]([AdvancedConsole.md](https://github.com/Akashe0106/BetterConsolePlugin/blob/main/DOCUMENTS/BetterConsoleEN/v1.0.0/How-to%20Guides/AdvancedConsole.md))
*   [Event]([Event.md](https://github.com/Akashe0106/BetterConsolePlugin/blob/main/DOCUMENTS/BetterConsoleEN/v1.0.0/How-to%20Guides/Event.md))
*   [BracketType](https://github.com/Akashe0106/BetterConsolePlugin/blob/main/DOCUMENTS/BetterConsoleEN/v1.0.0/How-to%20Guides/BracketType.md)
*   [Table](https://github.com/Akashe0106/BetterConsolePlugin/blob/main/DOCUMENTS/BetterConsoleEN/v1.0.0/How-to%20Guides/Table.md)
*   [MenuItem](https://github.com/Akashe0106/BetterConsolePlugin/blob/main/DOCUMENTS/BetterConsoleEN/v1.0.0/How-to%20Guides/MenuItem.md)
*   [MenuCreate](https://github.com/Akashe0106/BetterConsolePlugin/blob/main/DOCUMENTS/BetterConsoleEN/v1.0.0/How-to%20Guides/MenuCreate.md)

## Contributing

If you want to contribute to BetterConsoleEN, please read the [CONTRIBUTING.md](https://github.com/Akashe0106/BetterConsolePlugin/blob/main/CONTRIBUTING.md) file for more information.

Enjoy using BetterConsoleEN!
