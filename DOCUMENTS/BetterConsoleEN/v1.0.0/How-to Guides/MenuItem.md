# MenuItem Class: Bring Your Console Menus to Life

## Description

The `MenuItem` class is a fundamental building block that allows you to create interactive and user-friendly menus in your .NET console applications. This class enables you to define the text, description, and action to be performed when each menu item is selected. You can use the `MenuItem` class to make it easy for your users to interact with your applications and to simplify complex operations.

## Why Use the MenuItem Class?

*   **User-Friendly Interface:** Enhance the user experience by easily adding navigable menus to your console applications.
*   **Interaction:** Allow your users to interact with your applications and choose the actions they want to perform.
*   **Simplicity:** Simplify complex operations through menus and make your users' workflow easier.
*   **Flexibility:** Customize the text, descriptions, and actions of menu items to adapt your menus to the needs of your application.
*   **Organization:** Provide your users with an easy overview by grouping your application's functions in a structured way under menus.

## Properties

*   **Text:** Represents the text of the menu item that will be displayed to the user.
    *   Type: `string`
*   **Description:** An optional text that explains what the menu item does.
    *   Type: `string?`
*   **Action:** A `Action` delegate that represents the action to be executed when the menu item is selected.
    *   Type: `Action`

## Constructor

### MenuItem Constructor

Creates a new `MenuItem` instance.

```csharp
public MenuItem(string text, Action action, string description = null)
```

*   **Parameters:**
    *   `text` (string): Represents the text of the menu item.
    *   `action` (Action): Represents the action to be executed when the menu item is selected.
    *   `description` (string, optional): Represents the description of the menu item. The default value is `null`.

## Usage

You can find more different uses at [MenuCreate.md](MenuCreate.md).
```csharp
using BetterConsolePluginEN;
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
MenuCreate menu = new MenuCreate(menuItems);
menu.Create();
```

*   **Additional Notes:**

    *   Using the `MenuItem` class, you can create menu items that perform different types of actions (e.g., opening, saving, printing files, establishing network connections, etc.).
    *   By using descriptions of your menu items, you can provide your users with more information about the menu options.
    *   To further customize your menus, you can use different colors, icons, or animations.
    *   You can create submenus to make your menus more organized and understandable.
    *   You can dynamically change your menus according to your users' preferences (e.g., according to the language selection).
    *   You can make your menus faster and easier to access with keyboard shortcuts (e.g., Ctrl+S, Ctrl+O).
