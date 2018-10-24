using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //instead of parsing here better to do this in PrizeModel constructor
                PrizeModel model = new PrizeModel(
                    placeNameValueTextBox.Text,
                    placeNumberValueTextBox.Text,
                    prizeAmountValueTextBox.Text,
                    prizePercentageValueTextBox.Text);
                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }
                //clean text boxes 
                placeNameValueTextBox.Text = "";
                placeNumberValueTextBox.Text = "";
                prizeAmountValueTextBox.Text = "0";
                prizePercentageValueTextBox.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information, please check it and try again");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            //check if input is a number
            bool placeNumberValidNumber = int.TryParse(placeNumberValueTextBox.Text, out placeNumber);

            if (false == placeNumberValidNumber)
            {
                //TODO - Add communicates in case of failure of validation
                output = false;
            }
            //check if the number is less then 1
            if (placeNumber < 1)
            {
                output = false;
            }
            //check if the name lenght is less then 0
            if (placeNameValueTextBox.Text.Length == 0) // or placeNameValueTextBox.TextLenght == 0
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountValueTextBox.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageValueTextBox.Text, out prizePercentage);
            //check if prize amount or prize percentage is a number and it isn't empty
            if (false == prizePercentageValid || false == prizeAmountValid)
            {
                output = false;
            }
            //check if both prize amount and prize percentage is less then zero
            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }
            //check if prize percentage is in range between 0 and 100
            if (prizePercentage < 0 || prizeAmount > 100)
            {
                output = false;
            }
            //check if both are bigger than zero
            if (prizePercentage > 0 && prizeAmount > 0)
            {
                output = false;
            }

            return output;
        }
    }
}
