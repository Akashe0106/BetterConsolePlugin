using System;
using System.Collections.Generic;
using System.Linq;

namespace BetterConsolePluginEN
{
    /// <summary>
    /// Main class providing advanced console outputs and interactions.
    /// Offers features like colored text, event-based outputs, bracketed text, and drawing lines.
    /// </summary>
    public class AdvancedConsole
    {
        /// <summary>
        /// Default text color. This color is used in the <see cref="Write"/> method if no color is specified.
        /// </summary>
        public ConsoleColor DefaultTextColor { get; set; } = Console.ForegroundColor;

        /// <summary>
        /// Default color of the brackets around the event when an event type is specified.
        /// If an event type is specified in the <see cref="Write"/> method, the brackets are displayed in this color.
        /// </summary>
        public ConsoleColor DefaultBracketColor { get; set; } = Console.ForegroundColor;

        /// <summary>
        /// The default event type to use when the <see cref="Write"/> method is called without specifying an event parameter.
        /// If null, no event type is used by default (no event bracket is displayed).
        /// </summary>
        private Event? DefaultEvent { get; set; } = null;

        /// <summary>
        /// Determines whether a newline character is added to the end of the text by default
        /// when the <see cref="Write"/> method is called without specifying the skipLine parameter.
        /// </summary>
        public bool DefaultSkipLine { get; set; } = false;

        private BracketType _defaultBracketType = BracketType.Square;
        private string _leftBracket = "[";
        private string _rightBracket = "]";

        /// <summary>
        /// The default bracket type to use around the event if an event type is specified
        /// when the <see cref="Write"/> method is called.
        /// </summary>
        public BracketType DefaultBracketType
        {
            get { return _defaultBracketType; }
            set
            {
                // Update bracket characters when the bracket type changes.
                if (_defaultBracketType != value)
                {
                    _defaultBracketType = value;
                    UpdateBracketCharacters();
                }
            }
        }

        /// <summary>
        /// Updates the bracket characters (_leftBracket and _rightBracket) based on the selected <see cref="DefaultBracketType"/> value.
        /// This method is automatically called when the <see cref="DefaultBracketType"/> property is changed.
        /// </summary>
        private void UpdateBracketCharacters()
        {
            switch (_defaultBracketType)
            {
                case BracketType.Square:
                    _leftBracket = "[";
                    _rightBracket = "]";
                    break;
                case BracketType.Curly:
                    _leftBracket = "{";
                    _rightBracket = "}";
                    break;
                case BracketType.Round:
                    _leftBracket = "(";
                    _rightBracket = ")";
                    break;
                case BracketType.Line:
                    _leftBracket = "|";
                    _rightBracket = "|";
                    break;
                case BracketType.Blank:
                    _leftBracket = "";
                    _rightBracket = "";
                    break;
                case BracketType.DoubleQuote:
                    _leftBracket = "\"";
                    _rightBracket = "\"";
                    break;
                case BracketType.Quote:
                    _leftBracket = "'";
                    _rightBracket = "'";
                    break;
                case BracketType.GreaterThanLessThan:
                    _leftBracket = "<";
                    _rightBracket = ">";
                    break;
                default:
                    _leftBracket = "[";
                    _rightBracket = "]";
                    break;
            }
        }

        /// <summary>
        /// Writes text to the console. Text color, brackets based on event type, and newline character can be added.
        /// </summary>
        /// <param name="text">The text to write. Text cannot be null or empty.</param>
        /// <param name="event">Event type (optional). If an event type is specified, a bracket indicating the event type is displayed to the left of the text.</param>
        /// <param name="textColor">Text color (optional). If not specified, <see cref="DefaultTextColor"/> is used.</param>
        /// <param name="skipLine">Whether to skip to the next line (optional). If not specified, <see cref="DefaultSkipLine"/> is used.</param>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="text"/> is null.</exception>
        public void Write(string text, Event? @event = null, ConsoleColor? textColor = null, bool? skipLine = null)
        {
            // Check if the text is null
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text), "Text cannot be null.");
            }

            // Get the values to use, taking from the default values if parameters are not specified.
            ConsoleColor usedTextColor = textColor ?? this.DefaultTextColor;
            ConsoleColor bracketColor = this.DefaultBracketColor;
            Event? usedEvent = @event ?? this.DefaultEvent;
            bool usedSkipLine = skipLine ?? this.DefaultSkipLine;
            BracketType? usedBracketType = this._defaultBracketType; // Get the bracket type to use.

            string eventText = "";
            ConsoleColor eventColor = ConsoleColor.White;

            // If an event type is specified, determine the event text and color.
            if (usedEvent != null)
            {
                switch (usedEvent)
                {
                    case Event.Info:
                        eventText = "INFO";
                        eventColor = ConsoleColor.Blue;
                        break;
                    case Event.Error:
                        eventText = "ERROR";
                        eventColor = ConsoleColor.Red;
                        break;
                    case Event.Warning:
                        eventText = "WARNING";
                        eventColor = ConsoleColor.Yellow;
                        break;
                    case Event.Success:
                        eventText = "SUCCESS";
                        eventColor = ConsoleColor.Green;
                        break;
                    case Event.Question:
                        eventText = "QUESTION";
                        eventColor = ConsoleColor.Magenta;
                        break;
                    case Event.Debug:
                        eventText = "DEBUG";
                        eventColor = ConsoleColor.Gray;
                        break;
                    case Event.Critical:
                        eventText = "CRITICAL";
                        eventColor = ConsoleColor.DarkRed;
                        break;
                    case Event.Test:
                        eventText = "TEST";
                        eventColor = ConsoleColor.Cyan;
                        break;
                    default:
                        eventText = "UNKNOWN";
                        eventColor = ConsoleColor.DarkGray;
                        break;
                }

                // Print the event bracket.
                Console.ForegroundColor = bracketColor;
                Console.Write(_leftBracket);

                // Print the event text (if any).
                if (!string.IsNullOrEmpty(eventText))
                {
                    Console.ForegroundColor = eventColor;
                    Console.Write(eventText);
                }

                Console.ForegroundColor = bracketColor;
                Console.Write(_rightBracket + " "); // Add the right bracket and space.
            }

            // Print the text.
            Console.ForegroundColor = usedTextColor;
            if (usedSkipLine)
            {
                Console.WriteLine(text);
            }
            else
            {
                Console.Write(text);
            }

            // Reset colors (important!).
            Console.ResetColor();
        }

        /// <summary>
        /// Draws a line in the console with the specified color and character.
        /// </summary>
        /// <param name="color">The color of the line.</param>
        /// <param name="character">The character of the line (default '-').</param>
        public void DrawLine(ConsoleColor color, char character = '-')
        {
            Console.ForegroundColor = color;
            Console.WriteLine(new string(character, Console.WindowWidth));
            Console.ResetColor(); // Don't forget to reset the colors!
        }
    }

    /// <summary>
    /// Defines the event types. This enum is used in the <see cref="AdvancedConsole.Write"/> method.
    /// </summary>
    public enum Event { Info, Error, Warning, Success, Question, Debug, Critical, Test }

    /// <summary>
    /// Defines the bracket types. This enum is used in the <see cref="AdvancedConsole"/> class.
    /// </summary>
    public enum BracketType { Blank, Square, Curly, Round, Line, Quote, DoubleQuote, GreaterThanLessThan }


    /// <summary>
    /// Manages table data and formatting. Used to print the table to the console.
    /// </summary>
    public class Table
    {
        /// <summary>
        /// Table headers. Each element represents a column header.
        /// </summary>
        public string[] Headers { get; set; }

        /// <summary>
        /// Table data. Each inner array represents a row, and each object represents a cell.
        /// An object array is used to hold data of different types (string, int, double, etc.).
        /// </summary>
        public List<object[]> Data { get; set; } = new List<object[]>();

        /// <summary>
        /// Header color (optional). If not specified, the default console color is used.
        /// </summary>
        public ConsoleColor? HeaderColor { get; set; }

        /// <summary>
        /// Data color (optional). If not specified, the default console color is used.
        /// </summary>
        public ConsoleColor? DataColor { get; set; }

        /// <summary>
        /// Adds a new row to the table.
        /// </summary>
        /// <param name="rowData">Row data (each represents a column).
        ///                            Thanks to the 'params' keyword, this parameter allows
        ///                            you to enter the data by separating it with commas,
        ///                            as if you were giving an array when calling the method.</param>
        /// <exception cref="ArgumentException">Thrown if the number of columns in the added row does not match the number of columns in the headers.</exception>
        public void AddRow(params object[] rowData)
        {
            if (Headers != null && Headers.Length > 0 && rowData.Length != Headers.Length)
            {
                throw new ArgumentException("The number of columns in the added row does not match the header!", nameof(rowData));
            }
            Data.Add(rowData);
        }

        /// <summary>
        /// Adds or modifies table headers.
        /// </summary>
        /// <param name="headers">Headers.  Thanks to the 'params' keyword, this parameter allows
        ///                           you to enter the headers by separating them with commas,
        ///                           as if you were giving an array when calling the method.</param>
        ///  <exception cref="ArgumentException">Thrown if the number of header columns does not match the number of existing data columns.</exception>
        public void AddHeaders(params string[] headers)
        {
            if (Data.Count > 0 && Data[0].Length != headers.Length)
            {
                throw new ArgumentException("The number of header columns does not match the number of existing data columns!", nameof(headers));
            }

            Headers = headers;
        }

        /// <summary>
        /// Prints the table to the console.
        /// </summary>
        public void Print()
        {
            ConsoleColor headerColor = HeaderColor ?? ConsoleColor.Cyan;
            ConsoleColor dataColor = DataColor ?? ConsoleColor.White;

            if ((Headers == null || Headers.Length == 0) && (Data == null || Data.Count == 0))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Warning: No headers or data!");
                Console.ResetColor();
                return;
            }

            int columnCount = 0;
            if (Headers != null)
                columnCount = Headers.Length;
            else if (Data.Count > 0)
                columnCount = Data[0].Length;

            int[] columnWidths = new int[columnCount];

            if (Headers != null)
            {
                for (int i = 0; i < columnCount; i++)
                {
                    columnWidths[i] = Headers[i].Length;
                }
            }

            foreach (var row in Data)
            {
                if (row.Length != columnCount)
                {
                    throw new ArgumentException("The number of row columns is different than expected!");
                }

                for (int i = 0; i < columnCount; i++)
                {
                    columnWidths[i] = Math.Max(columnWidths[i], row[i]?.ToString().Length ?? 0);
                }
            }

            if (Headers != null)
            {
                Console.ForegroundColor = headerColor;
                for (int i = 0; i < columnCount; i++)
                {
                    Console.Write(Headers[i].PadRight(columnWidths[i] + 2));
                }
                Console.WriteLine();
            }

            if (Headers != null || Data.Count > 0)
            {
                Console.ForegroundColor = (Headers != null) ? headerColor : dataColor;
                Console.WriteLine(new string('-', columnWidths.Sum() + (columnCount * 2)));
            }

            Console.ForegroundColor = dataColor;
            foreach (var row in Data)
            {
                for (int i = 0; i < columnCount; i++)
                {
                    Console.Write(row[i]?.ToString().PadRight(columnWidths[i] + 2));
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }


    /// <summary>
    /// Represents a menu item.
    /// </summary>
    public class MenuItem
    {
        /// <summary>
        /// The text of the menu item (e.g., "New Game").
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The description of the menu item (optional) (e.g., "Starts a new game.").
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The action (Action) to be executed when the menu item is selected.
        /// </summary>
        public Action Action { get; set; }


        /// <summary>
        /// Creates a new menu item.
        /// </summary>
        /// <param name="text">The text of the menu item.</param>
        /// <param name="action">The action to be executed when the menu item is selected.</param>
        /// <param name="description">The description of the menu item (optional).</param>
        public MenuItem(string text, Action action, string description = null)
        {
            Text = text;
            Action = action;
            Description = description;
        }
    }

    /// <summary>
    /// Creates and manages a console menu. Presents options to the user and performs actions based on the selected option.
    /// </summary>
    public class MenuCreate
    {
        /// <summary>
        /// List of menu items.
        /// </summary>
        public List<MenuItem> Items { get; set; }

        /// <summary>
        /// The color of the selected menu item (optional). If not specified, the default console color is used.
        /// </summary>
        public ConsoleColor? SelectionColor { get; set; }

        /// <summary>
        /// The color of the non-selected menu items (optional). If not specified, the default console color is used.
        /// </summary>
        public ConsoleColor? NormalItemColor { get; set; }

        /// <summary>
        /// Creates a new menu.
        /// </summary>
        /// <param name="items">List of menu items.</param>
        /// <param name="selectionColor">The color of the selected menu item (optional).</param>
        /// <param name="normalItemColor">The color of the non-selected menu items (optional).</param>
        public MenuCreate(List<MenuItem> items, ConsoleColor? selectionColor = null, ConsoleColor? normalItemColor = null)
        {
            Items = items;
            SelectionColor = selectionColor;
            NormalItemColor = normalItemColor;
        }

        /// <summary>
        /// Creates the menu, presents the options to the user, and performs the action based on the selected option.
        /// </summary>
        public void Create()
        {
            int selectedItem = 0;
            ConsoleKeyInfo pressedKey;

            do
            {
                Console.CursorVisible = false;
                if (Console.CursorTop >= Items.Count)
                {
                    Console.SetCursorPosition(0, Console.CursorTop - Items.Count);
                }

                int i = 0;
                foreach (var item in Items)
                {
                    string prefix = (i == selectedItem) ? ">" : " ";
                    Console.ForegroundColor = (i == selectedItem) ? (SelectionColor ?? ConsoleColor.Yellow) : (NormalItemColor ?? ConsoleColor.White);

                    if (string.IsNullOrEmpty(item.Description))
                    {
                        Console.WriteLine($"{prefix}{item.Text}");
                    }
                    else
                    {
                        Console.WriteLine($"{prefix}{item.Text,-20} : {item.Description}");
                    }

                    i++;
                }

                pressedKey = Console.ReadKey(true);

                switch (pressedKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        selectedItem = (selectedItem - 1 + Items.Count) % Items.Count;
                        break;
                    case ConsoleKey.DownArrow:
                        selectedItem = (selectedItem + 1) % Items.Count;
                        break;
                }

            } while (pressedKey.Key != ConsoleKey.Enter);

            Console.CursorVisible = true;
            Console.ResetColor();

            Items[selectedItem].Action();
        }
    }
}
