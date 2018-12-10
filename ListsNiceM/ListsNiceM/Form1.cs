/*
 * Created by: Nice Mena
 * Created on: 05-12-18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #39 -lists 
 * This program stores items in a list
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

namespace ListsNiceM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // declare the local variabbles
            int userMark = -1;

            // convert the value in the textbox to an integer
            try
            {
                userMark = int.Parse(txtMarks.Text);
            }
            // write the error command line if user enters an invalid number
            catch (Exception ParseError)
            {
                Console.WriteLine(" An erro occured: '{0}'", ParseError);
            }

            // check if the user enetered a number between 0 an 100
            if ( ( userMark >= 0) && (userMark<= 100) )
            {
                // add the mark to the list box
                this.lstNumbers.Items.Add(userMark);

                // create an empty list
                List<int> myListOfIntegers = new List<int>();


                // add numbers to my list
                myListOfIntegers.Add(userMark);
            }
            // otherwise display an error
            else
            {
                MessageBox.Show("Please enter a number between 0 and 100", "Invalid Number");
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            // declaring local variables
            int average = 0;
            int sumOfNumbers = 0;
            int numOfMarks = 0;
            double mark;
            int nextNumb;

            // convert mark
            double mark = double.Parse(txtMarks.Text);

            if (mark > 0 && mark < 100)
            {
                // create the total
                sumOfNumbers = mark + sumOfNumbers;

                // increment
                numOfMarks++;

                // calculate the average
                average =sumOfNumbers / numOfMarks;

                // display the average
                lblAverage.Text = "your average is " + average + " % ";

            }

            else
            {
                // display the mark
                lblAverage.Text = "your average is " + average + " % ";
            }
           
                // create the total
                sumOfNumbers = mark + sumOfNumbers;

            // increment
            numOfMarks++;

            // calculate the average
            average = sumOfNumbers / numOfMarks;

            // display the average
            lblAverage.Text = "your average is " + average + " % ";



        }
    }
}
