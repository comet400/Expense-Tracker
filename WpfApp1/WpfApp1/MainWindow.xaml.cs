using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;

namespace ExpenseTracker
{
    public partial class MainWindow : Window
    {
        private const string FilePath = "yourExpenses.txt"; // Save as a text file
        private List<Expense> expenses = new List<Expense>();

        public MainWindow()
        {
            InitializeComponent();
            LoadExpenses();
        }

        private void LoadExpenses()
        {
            expenses.Clear();

            if (File.Exists(FilePath))
            {
                // Read each line and deserialize manually
                var lines = File.ReadAllLines(FilePath);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        expenses.Add(new Expense
                        {
                            Name = parts[0],
                            Type = parts[1],
                            Price = decimal.TryParse(parts[2], out var price) ? price : 0
                        });
                    }
                }
            }
            else
            {
                SaveExpenses(); // Create the file if it doesn't exist
            }
        }

        private void SaveExpenses()
        {
            var lines = expenses.Select(exp => $"{exp.Name}|{exp.Type}|{exp.Price}");
            File.WriteAllLines(FilePath, lines);
        }

        private void AddExpense_Click(object sender, RoutedEventArgs e)
        {
            string name = ExpenseNameTextBox.Text.Trim();
            string type = ExpenseTypeTextBox.Text.Trim();
            if (decimal.TryParse(ExpensePriceTextBox.Text, out decimal price))
            {
                if (expenses.Any(exp => exp.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
                {
                    OutputTextBlock.Text = "This expense already exists.";
                    return;
                }

                expenses.Add(new Expense { Name = name, Type = type, Price = price });
                SaveExpenses();
                OutputTextBlock.Text = "Expense added successfully.";
                ClearInputs();
            }
            else
            {
                OutputTextBlock.Text = "Please enter a valid price.";
            }
        }

        private void RemoveExpense_Click(object sender, RoutedEventArgs e)
        {
            string name = ExpenseNameTextBox.Text.Trim();

            var expense = expenses.FirstOrDefault(exp => exp.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (expense != null)
            {
                expenses.Remove(expense);
                SaveExpenses();
                OutputTextBlock.Text = "Expense removed successfully.";
                ClearInputs();
            }
            else
            {
                OutputTextBlock.Text = "Expense not found.";
            }
        }

        private void DisplayExpenses_Click(object sender, RoutedEventArgs e)
        {
            if (expenses.Any())
            {
                OutputTextBlock.Text = string.Join("\n", expenses.Select(exp =>
                    $"Name: {exp.Name}, Type: {exp.Type}, Price: ${exp.Price:F2}"));
            }
            else
            {
                OutputTextBlock.Text = "No expenses found.";
            }
        }

        private void DisplayTotal_Click(object sender, RoutedEventArgs e)
        {
            decimal total = expenses.Sum(exp => exp.Price);
            OutputTextBlock.Text = $"Total Price: ${total:F2}";
        }

        private void ClearInputs()
        {
            ExpenseNameTextBox.Clear();
            ExpenseTypeTextBox.Clear();
            ExpensePriceTextBox.Clear();
        }
    }

    public class Expense
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
    }
}
