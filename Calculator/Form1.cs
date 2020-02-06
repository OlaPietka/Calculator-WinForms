using System;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    /// <summary>
    /// Calculator
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor

        
        /// <summary>
        /// Default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Clearing Methods

        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            // Clears the text from user input text box
            this.UserInputText.Text = string.Empty;

            // Focus the user input text
            FocusInputText();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            // Delete the value after the selected position
            DeleteTextValue();

            // Focus the user input text
            FocusInputText();
        }

        #endregion

        #region Operator Methods

        private void DivButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");

            // Focus the user input text
            FocusInputText();
        }

        private void MulButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");

            // Focus the user input text
            FocusInputText();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");

            // Focus the user input text
            FocusInputText();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");

            // Focus the user input text
            FocusInputText();
        }

        private void EqButton_Click(object sender, EventArgs e)
        {
            CalculateEquation();

            // Focus the user input text
            FocusInputText();
        }

        #endregion

        #region Number Methods

        private void DotButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");

            // Focus the user input text
            FocusInputText();
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");

            // Focus the user input text
            FocusInputText();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");

            // Focus the user input text
            FocusInputText();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");

            // Focus the user input text
            FocusInputText();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");

            // Focus the user input text
            FocusInputText();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");

            // Focus the user input text
            FocusInputText();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");

            // Focus the user input text
            FocusInputText();

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");

            // Focus the user input text
            FocusInputText();

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");

            // Focus the user input text
            FocusInputText();

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");

            // Focus the user input text
            FocusInputText();

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");

            // Focus the user input text
            FocusInputText();

        }

        #endregion

        /// <summary>
        /// Calculates the givaen equation and outputs the answe to the user label
        /// </summary>
        private void CalculateEquation()
        {
            this.CalculationResultText.Text= ParseOperation();

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Parses the users equation and calculate the result
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            try
            {
                // Get the users equation input
                var input = this.UserInputText.Text;

                // Remove all spaces
                input = input.Replace(" ", "");

                // Create a new top=level operation
                var operation = new Operation();
                var leftSide = true;

                // Loop through each character of the input
                for (int i = 0; i < input.Length; i++)
                {

                    // Check if the current character is a number
                    if ("0123456789.".Any(c => input[i] == c))
                    {
                        if (leftSide)
                            operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]);
                        else
                            operation.RightSide = AddNumberPart(operation.RightSide, input[i]);
                    }
                    // If it is an operator ( + - * / ) set the operation type
                    else if ("+-*/".Any(c => input[i] == c))
                    {
                        if (!leftSide)
                        {
                            //Get the operation type
                            var operatorType = GetOperationType(input[i]);


                            // Check if we actually have a right side number
                            if (operation.RightSide.Length == 0)
                            {
                                // Check the operator is not a minus
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator (+ * / or more then one -) specified without an left side number");

                                // If we got here, the operator type is a minus, there is no right number currently, so add the minus to the number
                                operation.RightSide += input[i];
                            }
                            else
                            {
                                // Calculate previous equation and set to the left side
                                operation.LeftSide = CalculateOperation(operation);

                                // Set new operator
                                operation.OperationType = operatorType;

                                // Clear the previos right number
                                operation.RightSide = string.Empty;

                            }
                        }
                        else
                        {
                            //Get the operation type
                            var operatorType = GetOperationType(input[i]);

                            // Check if we actually have a left side number
                            if (operation.LeftSide.Length == 0)
                            {
                                // Check the operator is not a minus
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator (+ * / or more then one -) specified without an left side number");

                                // If we got here, the operator type is a minus, there is no left number currently, so add the minus to the number
                                operation.LeftSide += input[i];
                            }
                            else
                            {
                                // IF we get here, we have a left number and now an operator, do we want to move to the right side

                                // Set the operation type
                                operation.OperationType = operatorType;

                                // Move to the right side
                                leftSide = false;
                            }
                        }
                    }
                }

                // if we are done parisng, and there were ni exceptions
                // calcuate the current operation
                return CalculateOperation(operation);

            } catch(Exception ex)
            {
                return $"Invalid  equation. {ex.Message}";
            }
        }

        /// <summary>
        /// Calculates a <see cref="Operation"/> and returns the result
        /// </summary>
        /// <param name="operation"></param>
        private string CalculateOperation(Operation operation)
        {
            // Store the number values of the string representations
            decimal left = 0;
            decimal right = 0;

            // Check if we have a valid left side number
            if (string.IsNullOrEmpty(operation.LeftSide) || !decimal.TryParse(operation.LeftSide, out left))
                throw new InvalidOperationException($"Left side of the operation was not a number {operation.LeftSide}");

            // Check if we have a valid right side number
            if (string.IsNullOrEmpty(operation.RightSide) || !decimal.TryParse(operation.RightSide, out right))
                throw new InvalidOperationException($"Right side of the operation was not a number {operation.RightSide}");

            try
            {
                switch (operation.OperationType)
                {
                    case OperationType.Add:
                        return (left + right).ToString();

                    case OperationType.Minus:
                        return (left - right).ToString();

                    case OperationType.Divide:
                        return (left / right).ToString();

                    case OperationType.Multiply:
                        return (left * right).ToString();

                    default:
                        throw new InvalidOperationException($"Unknow operator type when calculating operation {operation.OperationType}");

                }
            } catch (Exception ex)
            {
                throw new InvalidOperationException($"Faild to calculate operation {operation.LeftSide} {operation.OperationType} {operation.RightSide}. {ex.Message}");
            }

        }

        /// <summary>
        /// Accepts a character and returns the know <see cref="OperationType"/>
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        private OperationType GetOperationType(char character)
        {
            switch (character)
            {
                case '+':
                    return OperationType.Add;

                case '-':
                    return OperationType.Minus;

                case '/':
                    return OperationType.Divide;

                case '*':
                    return OperationType.Multiply;

                default:
                    throw new InvalidOperationException($"Uknow operator type {character}");

            }
        }

        /// <summary>
        /// Attemps to add a new character to the current number, checking for valid characters at it goes
        /// </summary>
        /// <param name="currentNumber">The current number string</param>
        /// <param name="currentCharacter">The new character to append to the string</param>
        /// <returns></returns>
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            // Check if there is already a . in the number
            if (newCharacter == '.' && currentNumber.Contains('.'))
                throw new InvalidOperationException($"Number {currentNumber} already contains a . and another cant be added");

            return currentNumber + newCharacter;
        }

        #region Private helpers

        /// <summary>
        /// Focuses the user input text
        /// </summary>
        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }

        /// <summary>
        /// Inserts the given text into the user input text box
        /// </summary>
        /// <param name="value"> The value to insert </param>
        private void InsertTextValue(string value)
        {
            //Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            // Set new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);

            // Restore the selection start
            this.UserInputText.SelectionStart = selectionStart + value.Length;

            // Set selection lenght to 0
            this.UserInputText.SelectionLength = 0;
        }

        /// <summary>
        /// Deletes the character tyo ther right of the selection start of the user input text box
        /// </summary>
        /// <param name="value"> The value to remove </param>
        private void DeleteTextValue()
        {
            // If we dont have value to delete, return
            if (this.UserInputText.Text.Length < this.UserInputText.SelectionStart + 1)
                return;

            //Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            // Delete the character to the right of the selection 
            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);

            // Restore the selection start
            this.UserInputText.SelectionStart = selectionStart;

            // Set selection lenght to 0
            this.UserInputText.SelectionLength = 0;
        }

        #endregion
    }
}
