using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    This class uses a seperate cellPhone class to get and set the cellPhone data then uses
    this class to display the data that has been stored 
*/
namespace cellPhone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //the GetData method assigs the information entered by the user to the properties of
        //THe cellPhone class

        private void GetData(CellPhone phone) {
            //variable to hold the price
            decimal price;

            //Get the phones info
            phone.Brand = brandTextBox.Text;
            phone.Model = modelTextBox.Text;
            //get the price
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                MessageBox.Show("Invalid price entry");
            }
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            //Create a ellphone object that will be passed into the GetData method
            CellPhone myPhone = new CellPhone();

            //call the getData method
            GetData(myPhone);

            //Display the data into the labels
            brandDisplayLabel.Text = myPhone.Brand;
            modelDisplayLabel.Text = myPhone.Model;
            priceDisplayLabel.Text = myPhone.Price.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }
    }
}
