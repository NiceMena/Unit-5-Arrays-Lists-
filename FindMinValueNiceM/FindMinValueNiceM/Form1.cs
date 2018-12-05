/*
 * Created by: Nice Mena
 * Created on: 3-12-18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Find Min Value
 * This program finds the min value of numbers in an array
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

namespace FindMinValueNiceM
{
    public partial class frmMinvalue : Form
    {
        private int GetMinValue(int[] tmpArrayOfInts)
        {
            int minValue = 501;
            int tmpMinVal;

            foreach (int value in tmpArrayOfInts)
            {
                tmpMinVal = value;
                if (tmpMinVal < minValue)
                {
                    minValue = tmpMinVal;
                }
            }
            return minValue;

        }
 
        public frmMinvalue()
        {
            InitializeComponent();
            // hiding the label
            this.lblMinValue.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declaring local vaiables
            const int MAX_ARRAY_SIZE = 10;

            const int MAX_VAL = 501;


            // CREATING A RANDOM NUM GEN
            Random randomNumGen = new Random();

            // clearing the lst bbox
            this.lstNumbers.Items.Clear();

            // creating the array
            int[] arrayOfIntegers = new int[MAX_ARRAY_SIZE];

            int index, randomNumber, minValue;


            for (index = 0; index < MAX_ARRAY_SIZE; index++)
            {
                // generating a random num
                randomNumber = randomNumGen.Next(1, 500 -1);
                arrayOfIntegers[index] = randomNumber;

                // adding the numbers to the lst box
                lstNumbers.Items.Add(randomNumber);

                // refreshing the lst box
                this.Refresh();
            }

            // get the max value in the array 
            minValue = GetMinValue(arrayOfIntegers);

            // display max value
            this.lblMinValue.Show();
            this.lblMinValue.Text = " The min Value is: " + minValue;
        }

    }
}

