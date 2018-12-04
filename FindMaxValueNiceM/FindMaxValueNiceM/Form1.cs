/*
 * Created by: Nice Mena
 * Created on: 30-11-18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #36 - Find Max Value
 * This program finds the max value of numbers in an array
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

namespace FindMaxValueNiceM
{
    public partial class frmFindMaxValue : Form
    {
        private int GetMaxValue(int[] tmpArrayOfInts)
        {
            int maxValue = -1;
            int tmpMaxVal;

            foreach (int value in tmpArrayOfInts)
            {
                tmpMaxVal = value;
                if(tmpMaxVal > maxValue)
                {
                    maxValue = tmpMaxVal;
                }
            }
            return maxValue;
            
        }
        public frmFindMaxValue()
        {
            InitializeComponent();
            // hiding the label
            this.lblMaxValue.Hide();
;        }
    
      
        private void btnStart_Click(object sender, EventArgs e)
        {
            // declaring local vaiables
            const int MAX_ARRAY_SIZE = 10;

            const int MAX_VAL = -1;

           
            // CREATING A RANDOM NUM GEN
            Random randomNumGen = new Random();

            // clearing the lst bbox
            this.lstMaxValue.Items.Clear();

            // creating the array
            int[] arrayOfIntegers = new int[MAX_ARRAY_SIZE];

            int index, randomNumber, maxValue;


            for (index = 0; index < MAX_ARRAY_SIZE; index++)
            {
                // generating a random num
                randomNumber = randomNumGen.Next(1, 500 + 1);
                arrayOfIntegers[index] = randomNumber;

                // adding the numbers to the lst box
                lstMaxValue.Items.Add(randomNumber);

                // refreshing the lst box
                this.Refresh();
            }
         
            // get the max value in the array 
            maxValue = GetMaxValue(arrayOfIntegers);

            // display max value
            this.lblMaxValue.Show();
            this.lblMaxValue.Text = " The max Value is: " + maxValue;
        }

        private void frmFindMaxValue_Load(object sender, EventArgs e)
        {

        }
    }
}
