# BracketType Enum: Personalize Your Event Outputs

## Description

The `BracketType` enum, when used with the `AdvancedConsole` class, allows you to determine the type of brackets used in event-based console outputs. This enum allows you to personalize the appearance of your console applications and align them with your brand image.

## Why Use the BracketType Enum?

*   **Visual Variety:** Makes your console outputs more diverse and engaging.
*   **Brand Identity:** Provides a consistent look by using brackets that match your application's brand identity.
*   **User Preferences:** Offers the ability to change the bracket type according to your users' preferences.
*   **Readability:** By changing the bracket type, you can make certain event types easier to distinguish.

## Values

| Value                 | Description                                                                 | Example Output   |
| :-------------------- | :----------------------------------------------------------------------- | :----------------- |
| `Blank`               | No brackets are used.                                                     | `INFO Message`     |
| `Square`              | Square brackets are used: `[]`                                          | `[INFO] Message`   |
| `Curly`               | Curly braces are used: `{}`                                          | `{INFO} Message`   |
| `Round`               | Round brackets are used: `()`                                        | `(INFO) Message`   |
| `Line`                | Vertical line brackets are used: `\|\|`                                    | `\|INFO\| Message` |
| `Quote`               | Single quote brackets are used: `''`                                    | `'INFO' Message`   |
| `DoubleQuote`         | Double quote brackets are used: `""`                                    | `"INFO" Message` |
| `GreaterThanLessThan` | Greater than/less than brackets are used: `<>`                              | `<INFO> Message`   |

## Usage

You can use the `BracketType` enum with the `DefaultBracketType` property of the `AdvancedConsole` class. This allows you to set the default bracket type for all event outputs.

```csharp
using BetterConsolePluginEN;

AdvancedConsole console = new AdvancedConsole();

// Set the default bracket type to curly braces
console.DefaultBracketType = BracketType.Curly;

// Print an information message (with curly braces)
console.Write("Application is starting...", Event.Info); // {INFO} Application is starting...

// Set the default bracket type to line brackets
console.DefaultBracketType = BracketType.Line;

// Print an error message (with line brackets)
console.Write("An error occurred!", Event.Error); // |ERROR| An error occurred!
