using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace CarRentalApplication
{
    public partial class Form1 : Form
    {
        Double dailyRate;
        Double No_of_days;
        Double discount;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDatabaseDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.myDatabaseDataSet.Table);

        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDatabaseDataSet);

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            Double CostofRenting, totalR, Discount_Rate;

            if (number_of_DaysTextBox.Text == "")
            {
                MessageBox.Show("Enter Number of Days", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                number_of_DaysTextBox.Focus();
            }
            else
            {
                dailyRate = 25.5;
                No_of_days = Double.Parse(number_of_DaysTextBox.Text);
                discount = Double.Parse(discount_RateTextBox.Text);
                CostofRenting = dailyRate * No_of_days;
                Discount_Rate = ((CostofRenting) * discount) / 100;
                totalR = CostofRenting;
                total_CostTextBox.Text = String.Format("{0:C}", totalR);

                txtReceipt.Text = "";
                txtReceipt.AppendText("=======================================\r\n");
                txtReceipt.AppendText("                                       Car Rental Information\r\n");
                txtReceipt.AppendText("======================================\r\n");
                txtReceipt.AppendText("Car Rental Receipt" + "\r\n");
                txtReceipt.AppendText("Firstname:\t\t\t" + firstnameTextBox.Text + "\r\n");
                txtReceipt.AppendText("Lastnane:\t\t\t" + lastnameTextBox.Text + "\r\n");
                txtReceipt.AppendText("Registration Number:\t\t\t" + registration_NumberTextBox.Text + "\r\n");
                txtReceipt.AppendText("Number of Days:\t\t\t" + number_of_DaysTextBox.Text + "\r\n");
                txtReceipt.AppendText("Discount:\t\t\t" + discount_RateTextBox.Text + "\r\n");
                txtReceipt.AppendText("Total:\t\t\t" + total_CostTextBox.Text + "\r\n");
            }
      

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit Program
            const string message = "Are you sure you want to exit?";
            const string closing = "Closing program";
            var result = MessageBox.Show(message, closing, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //If user choses yes, program will close
            if (result == DialogResult.Yes)
            {
                Application.Exit(); //Close program
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------
        void TextCleared(Control con)
        {
            foreach (Control t in con.Controls)
            {
                if (t is TextBox)
                    ((TextBox)t).Clear();
                else
                    TextCleared(t);

            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult clearDialogue = MessageBox.Show("Clear Car Rental Record?", "All fields Cleared", MessageBoxButtons.YesNo);
            if (clearDialogue == DialogResult.Yes)
            {
                TextCleared(this);
                air_ConditionCheckBox.Checked = false;
                automaticCheckBox.Checked = false;

            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.tableBindingSource.MoveLast();

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.tableBindingSource.MoveFirst();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.tableBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.tableBindingSource.MoveNext();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDatabaseDataSet);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.tableBindingSource.EndEdit();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.txtReceipt.Text, this.txtReceipt.Font, Brushes.Black, 10, 25);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += printDocument1_PrintPage;
            printDocument.Print();
        }

       
    }
}
