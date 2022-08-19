using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankUIForm
{
    public partial class ReusableBankUIForm : Form
    {
        protected int TextBoxCount { get; set; } = 4;  // number of TextBoxes

        // Enumeration constants specify Textbox indices
        public enum TextBoxIndices { Account, First, Last, Balance }

        // Parameterless constructor 
        public ReusableBankUIForm()
        {
            InitializeComponent();
        }

        // Clear all TextBoxes
        public void ClearTextBoxes()
        {
            // Iterate through every Control on the form
            foreach (Control guiControl in Controls)
            {
                // If Control is a TextBox, clear it
                (guiControl as TextBox)?.Clear();
            }
        }

        // Set TextBox values to string-array values
        public void SetTextBoxValues(string[] values)
        {
            // Determine whether string array has correct length
            if (values.Length != TextBoxCount)
            {
                // Throw exception if not correct length
                throw (new ArgumentException(
                    $"There must be {TextBoxCount} strings in the array",
                    nameof(values)));
            }
            else // Set array values if array has correct length
            {
                // Set array values to TextBox values
                accountTextBox.Text = values[(int)TextBoxIndices.Account];
                firstNameTextBox.Text = values[(int)TextBoxIndices.First];
                lastNameTextBox.Text = values[(int)TextBoxIndices.Last];
                balanceTextBox.Text = values[(int)TextBoxIndices.Balance];
            }
        }

        // Return TextBox values as string array
        public string[] GetTextBoxValues()
        {
            return new string[]
            {
                accountTextBox.Text, firstNameTextBox.Text,
                lastNameTextBox.Text, balanceTextBox.Text};
        }
    }
}
