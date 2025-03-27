# AdvancedConsole Class

## Description

The `AdvancedConsole` class is a tool that allows you to make your console applications more rich, informative, and user-friendly in .NET projects. This class significantly enhances the appearance and usability of your console applications through various features such as colored texts, event-based outputs, customizable bracketed texts, and line drawing. This class provides great convenience, especially in scenarios such as logging, debugging, user notification, and interactive menus.

## Properties

### Default Text Color (DefaultTextColor)

*   **Description:** Determines the default color of the texts printed to the console. The color determined by this property is used if no color is specified in the `Write` method.
*   **Type:** `ConsoleColor` (from the System.Console namespace)
*   **Default Value:** `Console.ForegroundColor` (The console's initial default text color)
*   **Usage:**

    ```csharp
    AdvancedConsole console = new AdvancedConsole();
    console.DefaultTextColor = ConsoleColor.Green; // Sets the default color to green
    console.Write("This text will be printed in green.");
    ```

### Default Bracket Color (DefaultBracketColor)

*   **Description:** Determines the default color of the brackets used in event-based outputs (e.g., `[ERROR]`, `[INFO]`). This color is used as the color of the brackets around the event when an event type is specified in the `Write` method.
*   **Type:** `ConsoleColor`
*   **Default Value:** `Console.ForegroundColor`
*   **Usage:**

    ```csharp
    AdvancedConsole console = new AdvancedConsole();
    console.DefaultBracketColor = ConsoleColor.Yellow; // Sets the bracket color to yellow
    console.Write("A warning message.", Event.Warning); // The [WARNING] bracket will be in yellow.
    ```

### Default Skip Line (DefaultSkipLine)

*   **Description:** Determines whether a newline character is automatically added after the text is printed when the `Write` method is used, thus moving to the next line. This feature is used to control the layout of console outputs.
*   **Type:** `bool` (true or false)
*   **Default Value:** `false` (No newline is added)
*   **Usage:**

    ```csharp
    AdvancedConsole console = new AdvancedConsole();
    console.DefaultSkipLine = true; // A new line is skipped after each text is printed.
    console.Write("This text is on one line...");
    console.Write("...and this text will be on the other line.");
    ```

### Default Bracket Type (DefaultBracketType)

*   **Description:** Determines the shape of the brackets used in event-based outputs (square brackets, curly braces, etc.). This feature allows you to personalize the appearance of console outputs.
*   **Type:** `BracketType` (A custom enum)
*   **Default Value:** `BracketType.Square` (Square brackets: `[]`)
*   **Usage:**

    ```csharp
    AdvancedConsole console = new AdvancedConsole();
    console.DefaultBracketType = BracketType.Curly; // Makes the brackets curly braces: {}
    console.Write("An information message.", Event.Info); // Printed as {INFO}.
    ```

## Methods

### Write Method

Prints text to the console. This method offers various options such as adding text color, brackets according to event type, and skipping to a new line.

```csharp
public void Write(string text, Event? @event = null, ConsoleColor? textColor = null, bool? skipLine = null)
```

*   **Parameters:**
    *   `text` (string): The text to be printed to the console. This parameter is mandatory and cannot be null or empty.
    *   `event` (Event?, optional): The event type accompanying the text. This parameter can be null. If an event type is specified, a bracket indicating the event type is displayed to the left of the text.
    *   `textColor` (ConsoleColor?, optional): The color of the text. This parameter can be null. The `DefaultTextColor` property is used if not specified.
    *   `skipLine` (bool?, optional): Whether to add a newline character to the end of the text. This parameter can be null. The `DefaultSkipLine` property is used if not specified.
*   **Exceptions:**
    *   `ArgumentNullException`: This exception is thrown if the `text` parameter is null.
*   **Usage Examples:**

    ```csharp
    using BetterConsolePluginEN;

    AdvancedConsole console = new AdvancedConsole();

    // Simple text printing
    console.Write("Hello, console!");

    // Colored text printing
    console.Write("This text is in red.", null, ConsoleColor.Red);

    // Event text printing (with default bracket type)
    console.Write("An error occurred!", Event.Error);

    // Event text printing (with custom bracket type and color)
    console.DefaultBracketColor = ConsoleColor.Cyan;
    console.DefaultBracketType = BracketType.Curly;
    console.Write("A warning message.", Event.Warning, ConsoleColor.Yellow);

    // Printing text and skipping to a new line
    console.DefaultSkipLine = true;
    console.Write("This text is on one line.");
    console.Write("This text is on the other line.");
    ```

### DrawLine Method

Draws a horizontal line in the console with the specified color and character. This method helps you present information more neatly by creating visual separators in console outputs.

```csharp
public void DrawLine(ConsoleColor color, char character = '-')
```

*   **Parameters:**
    *   `color` (ConsoleColor): The color of the line. This parameter is mandatory.
    *   `character` (char, optional): The character that makes up the line. This parameter is optional and defaults to the '-' (hyphen) character.
*   **Usage Examples:**

    ```csharp
    using BetterConsolePluginEN;

    AdvancedConsole console = new AdvancedConsole();

    // Drawing a yellow line (with default character)
    console.DrawLine(ConsoleColor.Yellow);

    // Drawing a red line of stars
    console.DrawLine(ConsoleColor.Red, '*');
    ```

*   **Additional Notes:**

    *   The `DrawLine` method can be used to provide visual separation between sections in console outputs.
    *   You can create more creative line styles by using different characters.
    *   You can dynamically change the line color and character according to your application's theme or specific events.

