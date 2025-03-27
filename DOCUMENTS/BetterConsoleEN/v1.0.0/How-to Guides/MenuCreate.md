# MenuCreate Class: Craft Impressive and User-Friendly Menus for Your Console Applications

## Description

The `MenuCreate` class is a powerful tool that enables you to create interactive and easy-to-use menus in your .NET console applications. This class significantly enhances the user experience of your console applications by allowing you to organize menu items, set menu titles, customize the appearance of menu items, and easily manage user input. The `MenuCreate` class is not just a menu builder; it's also a way to interact with your users and make the functionality of your applications easily accessible.

## Why Use the MenuCreate Class?

*   **Enhanced User Experience:** Maximize the user experience by adding intuitive and easy-to-use menus to your console applications. Instead of complex commands or hard-to-remember shortcuts, your users can interact with your applications with simple menu options.
*   **Easy Menu Management:** Easily create, organize, and manage your menu items. You can dynamically change your menus, add new items, update existing items, or delete them.
*   **Customizable Appearance:** Customize the colors, fonts, icons, and other visual features of menu items to match your menus with your application's design and brand identity.
*   **Flexible Action Management:** Easily define and manage the actions to be performed when menu items are selected. You can assign different types of actions to your menu items, get user input, and dynamically change the behavior of your application.
*   **Quick Integration:** Easily integrate the `MenuCreate` class into your existing .NET projects and start creating interactive menus in no time.

## Properties

*   **Items:** Represents the list of `MenuItem` objects to be displayed in the menu.
    *   Type: `List<MenuItem>`
*   **SelectionColor:** Determines the color of the selected menu item.
    *   Type: `ConsoleColor?` (nullable ConsoleColor)
    *   Default Value: `ConsoleColor.Yellow`
*   **NormalItemColor:** Determines the color of the non-selected menu items.
    *   Type: `ConsoleColor?` (nullable ConsoleColor)
    *   Default Value: `ConsoleColor.White`

## Methods

### Create Method: Build and Display Your Menu

Creates the menu, presents the options to the user, and performs the action based on the selected option.

```csharp
public void Create()
```

*   **Parameters:** None
*   **Exceptions:** None

## Constructor: Lay the Foundation for Your Menu

### MenuCreate Constructor: Create a New Menu

Create a new `MenuCreate` class instance, laying the foundation for your interactive console menus. This constructor allows you to define your menu items, the color of the selected item, and the color of normal items.

```csharp
public MenuCreate(List<MenuItem> items, ConsoleColor? selectionColor = null, ConsoleColor? normalItemColor = null)
```

*   **Parameters:**
    *   `items` (List<MenuItem>): Represents the list of `MenuItem` objects to be displayed in the menu. This parameter is mandatory.
    *   `selectionColor` (ConsoleColor?, optional): Determines the color of the selected menu item. This parameter can be `null`. The default value is `ConsoleColor.Yellow`.
    *   `normalItemColor` (ConsoleColor?, optional): Determines the color of the non-selected menu items. This parameter can be `null`. The default value is `ConsoleColor.White`.

## Usage

### 1. Example: Basic Menu Creation

This example shows the most basic menu creation scenario. Menu items are defined, added to a list, and then the menu is created and displayed using the `MenuCreate` class.

```csharp
using BetterConsolePlugin;
using System;
using System.Collections.Generic;

// Define menu items
List<MenuItem> items = new List<MenuItem>()
{
    new MenuItem("Start Game", () => Console.WriteLine("Game is starting..."), "Starts a new game"),
    new MenuItem("Settings", () => Console.WriteLine("Opening settings menu..."), "Allows you to configure game settings"),
    new MenuItem("Exit", () => Environment.Exit(0), "Exits the application")
};

// Create and display the menu
MenuCreate menu = new MenuCreate(items);
menu.Create();
```

### 2. Example: Creating a Menu with Customized Colors

This example shows how you can improve the appearance of your menu by customizing the colors of the menu items. You can specify a different color for the selected item and a different color for the normal items.

```csharp
using BetterConsolePlugin;
using System;
using System.Collections.Generic;

// Define menu items (the same items can be used)
List<MenuItem> items = new List<MenuItem>()
{
    new MenuItem("Start Game", () => Console.WriteLine("Game is starting..."), "Starts a new game"),
    new MenuItem("Settings", () => Console.WriteLine("Opening settings menu..."), "Allows you to configure game settings"),
    new MenuItem("Exit", () => Environment.Exit(0), "Exits the application")
};

// Create and display the menu with customized colors
MenuCreate coloredMenu = new MenuCreate(items, ConsoleColor.Green, ConsoleColor.Gray);
coloredMenu.Create();
```

### 3. Example: Creating a Menu with Menu Items Without Descriptions

This example shows how you can create a menu without using descriptions for menu items. The description is an optional feature used to specify what a menu item does or what it is for.

```csharp
using BetterConsolePlugin;
using System;
using System.Collections.Generic;

// Define a list with menu items without descriptions
List<MenuItem> simpleItems = new List<MenuItem>()
{
    new MenuItem("Option 1", () => { Console.WriteLine("Option 1 executed!"); }), // No description
    new MenuItem("Option 2", () => { Console.WriteLine("Option 2 executed!"); }), // No description
    new MenuItem("Exit", () => { Environment.Exit(0); }) // No description
};

// Create and display a menu with these items
MenuCreate simpleMenu = new MenuCreate(simpleItems);
simpleMenu.Create();
```

### 4. Example: Creating a Menu With Advanced Menu Items

```csharp
using BetterConsolePlugin;
using System;
using System.Collections.Generic;

// 1. Step: Create your menu items
MenuItem menuItem1 = new MenuItem(
    "Start Game", // The text of the menu item
    () => Console.WriteLine("Game is starting..."), // The action to be executed when the menu item is selected
    "Starts a new game" // The description of the menu item
);

MenuItem menuItem2 = new MenuItem(
    "Settings", // The text of the menu item
    () => Console.WriteLine("Opening settings menu..."), // The action to be executed when the menu item is selected
    "Allows you to configure game settings" // The description of the menu item
);

MenuItem menuItem3 = new MenuItem(
    "Exit", // The text of the menu item
    () => Environment.Exit(0), // The action to be executed when the menu item is selected
    "Exits the application" // The description of the menu item
);

// 2. Step: Add your menu items to a list
List<MenuItem> menuItems = new List<MenuItem>()
{
    menuItem1,
    menuItem2,
    menuItem3
};

// 3. Step: Create and display your menu using the MenuCreate class
MenuCreate menu = new MenuCreate(
    menuItems, // List of menu items
    ConsoleColor.Green, // Color of the selected item
    ConsoleColor.Gray // Color of the normal items
);
menu.Create();
```

*   **Additional Notes:**

    *   Using the `MenuCreate` class, you can create different types of menus (e.g., vertical menus, horizontal menus, submenus, etc.).
    *   You can make your menus more attractive by customizing the colors, fonts, and icons of your menu items.
    *   You can dynamically change your menus according to your users' preferences (e.g., according to the language selection).
    *   You can make your menus faster and easier to access with keyboard shortcuts (e.g., up arrow, down arrow, Enter).
    *   You can also make your menus controllable with mouse clicks (if the console application supports it).
    *   You can display your menus consistently on different platforms (e.g., Windows, Linux, macOS).

