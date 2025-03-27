# Table Class: Transform Your Console Data into Art

## Description

The `Table` class is your key to presenting data in an impressive and easy-to-understand way in your .NET console applications. It's not just a tool; it's a work of art that turns your data into a visual feast! This class allows you to create tables with headers and rows, automatically adjust column widths, enhance your table's aesthetics with different colors, and even make your data more meaningful with custom formatting options. Whether you want to analyze complex data sets, create eye-catching reports, or present clear and concise information to your users, the `Table` class will be your indispensable assistant.

## Why Use the Table Class?

*   **Visual Appeal:** Transform your data into eye-catching and memorable tables instead of boring lists.
*   **Understandability:** By presenting complex data sets in an organized manner, ensure that your users quickly grasp the information.
*   **Professional Impression:** Add a professional touch to your console applications and provide your users with a quality experience.
*   **Data Analysis:** Visually analyze your data and easily discover important trends and relationships.
*   **Flexibility:** Support different data types such as text, numbers, dates, and more, and format your data as you wish.
*   **Customization:** Fully control the appearance of your table by customizing header and data colors, column widths, and other formatting options.

## Properties

*   **Headers:** A `string` array that defines the headers of the table, increases readability, and categorizes your data in a meaningful way.
    *   Type: `string[]`
*   **Data:** A list of `object` arrays that form the heart of the table, each representing a row and containing different data types.
    *   Type: `List<object[]>`
*   **HeaderColor:** A color that adds vibrancy to your table's headers, increases readability, and improves the overall aesthetics of your table.
    *   Type: `ConsoleColor?` (nullable ConsoleColor)
    *   Default Value: `ConsoleColor.Cyan`
*   **DataColor:** A color that brings your data to life, increases readability, and allows you to highlight your data.
    *   Type: `ConsoleColor?` (nullable ConsoleColor)
    *   Default Value: `ConsoleColor.White`

## Methods

### AddHeaders Method: Give Soul to Your Table

Used to add headers that give meaning and structure to your table. This method allows you to create headers that define the content of your table and guide your users.

```csharp
public void AddHeaders(params string[] headers)
```

*   **Parameters:**
    *   `headers` (string[]): An array of `string` values representing the headers of your table. Thanks to the `params` keyword, you can easily add headers by separating them with commas when calling the method.
*   **Exceptions:**
    *   `ArgumentException`: This exception is thrown if the number of headers you are trying to add is not compatible with your existing data.

### AddRow Method: Bring Your Data to Life

Allows you to enrich your table's content by adding new data. This method allows you to add your data to your table in an organized manner and present it to your users.

```csharp
public void AddRow(params object[] rowData)
```

*   **Parameters:**
    *   `rowData` (object[]): An array of `object` values representing the data to be added to your table. Thanks to the `params` keyword, you can easily add data by separating them with commas when calling the method.
*   **Exceptions:**
    *   `ArgumentException`: This exception is thrown if the number of columns in the data row you are trying to add is not compatible with your table's headers.

### Print Method: Showcase Your Masterpiece

Allows you to display the table you have created on the console, presenting your data in an impressive way. This method prints your table's headers, data, and formatting to the console, helping your users easily grasp the information.

```csharp
public void Print()
```

*   **Parameters:** None
*   **Exceptions:** None

## Usage

```csharp
using BetterConsolePlugin;

// Create a new table
Table table = new Table();

// Add headers to your table
table.AddHeaders("Name", "Age", "City", "Occupation");

// Add data to your table
table.AddRow("John Doe", 30, "New York", "Engineer");
table.AddRow("Alice Smith", 25, "London", "Teacher");
table.AddRow("Bob Johnson", 40, "Tokyo", "Doctor");

// Set the header color
table.HeaderColor = ConsoleColor.Yellow;

// Set the data color
table.DataColor = ConsoleColor.Green;

// Print your table to the console
table.Print();
```

*   **Additional Notes:**

    *   You can easily display data from different data sources (databases, files, APIs, etc.) using the `Table` class.
    *   Column widths are automatically adjusted, but you can also manually control column widths by applying custom formatting if you wish.
    *   To further customize the appearance of your table, you can create cell dividers using different characters (e.g., line characters).
    *   You can dynamically transfer the properties of objects to the table using the `System.Reflection` library.
    *   After creating your table, you can filter, sort, or summarize the data.
    *   You can use additional libraries to export your table in different formats (e.g., CSV, HTML).

This example shows how to create impressive and organized tables using the `Table` class. By using your own creativity, you can combine different data types, formatting options, and colors, and create an unforgettable visual experience in your console applications!
