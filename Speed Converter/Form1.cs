using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Speed_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // Declare a constants
            int START_SPEED = 60;
            int END_SPEED = 130;
            int INTERVAL = 10;
            double CONVERSION_FACTOR = 0.6214;

            // Declare variables
            int kph;    // To hold the speed in kph
            double mph; // To hold the speed in mph

            // Display the table of speeds
            for (kph = START_SPEED; kph <= END_SPEED; kph += INTERVAL) 
            {
                // Calculate the mph
                mph = kph * CONVERSION_FACTOR;

                // Display the conversion
                outputListBox.Items.Add(kph + " is the same as " + mph + " mph");
            }
        }
    }
}
