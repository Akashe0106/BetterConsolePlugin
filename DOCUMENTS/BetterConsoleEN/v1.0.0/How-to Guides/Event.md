# Event Enum: Make Your Console Outputs Meaningful

## Description

The `Event` enum is a powerful tool designed to enrich and add meaning to the outputs in your console applications. This enum allows you to categorize the different situations your application encounters during runtime: informational messages, errors, warnings, successful operations, user input expectations, debugging information, and critical situations. By using the `Event` enum with the `AdvancedConsole` class's `Write` method, you can instantly add context to your console outputs and allow your users (or you) to quickly understand your application's status.

## Why Use the Event Enum?

*   **Readability:** Makes your console outputs more organized and easier to read.
*   **Comprehensibility:** Clearly indicates what the messages mean and what state your application is in.
*   **Debugging:** Simplifies your debugging processes, helping you quickly identify the source and importance of errors.
*   **Logging:** Provides consistent and meaningful outputs for your logging systems.
*   **User Experience:** Provides your users with clear and concise information about the status of your application, providing a better experience.

## Values

| Value     | Description                                                                                             | Example Message                             | Console Output Example               |
| :-------- | :----------------------------------------------------------------------------------------------------- | :------------------------------------------ | :----------------------------------- |
| `Info`    | Represents general information about the application or system.                                          | "Application started successfully."         | `[INFO] Application started.`        |
| `Error`   | Indicates that an unexpected problem or error has occurred.                                                | "A file reading error occurred."          | `[ERROR] A file reading error.`       |
| `Warning` | Indicates a potential problem or risk.                                                                 | "Disk space has reached a critical level." | `[WARNING] Disk space critical.`    |
| `Success` | Indicates that an operation has been completed successfully.                                             | "Database connection established successfully." | `[SUCCESS] Database connected.`       |
| `Question`| Represents situations where user input or confirmation is expected.                                      | "Do you want to continue? (Y/N)"          | `[QUESTION] Do you want to continue?` |
| `Debug`   | Contains information used during development and debugging.                                              | "Variable 'name' value: 'John'"            | `[DEBUG] Variable 'name' value: 'John'` |
| `Critical`| Indicates situations that could seriously affect the stability or operation of the application.          | "Out of memory error!"                    | `[CRITICAL] Out of memory error!`    |
| `Test`    | Contains information used in testing processes.                                                         | "Database connection test successful."      | `[TEST] Database connection test.`   |

## Usage

Using the `Event` enum with the `AdvancedConsole` class's `Write` method is quite easy. Just specify the message you want to print and the corresponding `Event` type.

```csharp
using BetterConsolePlugin;

AdvancedConsole console = new AdvancedConsole();

// Printing an information message
console.Write("Application is starting...", Event.Info);

// Printing an error message
console.Write("An error occurred!", Event.Error);

// Printing a warning message
console.Write("Disk space is running low.", Event.Warning);
```

