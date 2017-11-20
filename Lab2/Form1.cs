/*Timothy Mahan
 * Lab 2
 * Due: 2/2/16
 * Course Section: 01
 * This program takes input from the user and concatenates
 * it in different ways depending on what button they push.
 * When they input the information and press a button, the concatenation
 * is displayed in a Label that lies between the text boxes and the buttons.
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class labForm2 : Form
    {
        public labForm2()
        {
            InitializeComponent();
        }

        private void nameForm1_Click(object sender, EventArgs e)
        {
            String userName; //Declares string variable that will contain the full user name 
            userName = titleTextBox.Text + " " + firstNameTextBox.Text + " " + middleNameTextBox.Text + " " + lastNameTextBox.Text; //Concatenates the Text property of title, first, middle, and last name text boxes with spaces in between each.
            fullNameTextLabel.Text = userName; //Enters the text from the string userName into the full name text label.
        }

        private void nameForm2_Click(object sender, EventArgs e)
        {
            string userName; //Declares string variable that will contain the full user name
            userName = firstNameTextBox.Text + " " + middleNameTextBox.Text + " " + lastNameTextBox.Text; //Concatenates the Text property of first, middle and last name text boxes with spaces in between them
            fullNameTextLabel.Text = userName; //Enters the text from the string userName into the full name text label.
        }
        
        private void nameForm3_Click(object sender, EventArgs e)

        {
            string userName; //Declares string variable that will contain the full user name
            userName = firstNameTextBox.Text + " " + lastNameTextBox.Text; //Concatenates the Text property of first and last name text boxes with spaces in between them
            fullNameTextLabel.Text = userName; //Enters the text from the string userName into the full name text label.
        }

        private void nameForm4_Click(object sender, EventArgs e)
        {
            string userName; //Declares string variable that will contain the full user name
            userName = lastNameTextBox.Text + ", " + firstNameTextBox.Text + " " + middleNameTextBox.Text + ", " + titleTextBox.Text; //Concatenates the Text property of last, first, middle, and title text boxes with spaces and commas between them
            fullNameTextLabel.Text = userName; //Enters the text from the string userName into the full name text label.
        }

        private void nameForm5_Click(object sender, EventArgs e)
        {
            string userName; //Declares string variable that will contain the full user name
            userName = lastNameTextBox.Text + ", " + firstNameTextBox.Text + " " + middleNameTextBox.Text; //Concatenates the Text property of last, first, and middle name text boxes with spaces and a comma between them.
            fullNameTextLabel.Text = userName; //Enters the text from the string userName into the full name text label.
        }

        private void nameForm6_Click(object sender, EventArgs e)
        {
            string userName; //Declares string variable that will contain the full user name
            userName = lastNameTextBox.Text + ", " + firstNameTextBox.Text; //Concatenates the Text property of last and first name test boxes with a space and a comma between them
            fullNameTextLabel.Text = userName; //Enters the text from the string userName into the full name text label.
        }

        

        
    }
}
