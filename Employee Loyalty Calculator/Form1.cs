using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace vanderWaltPrac7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtEmpName.Text;
                int yearsWorked;
                int.TryParse(txtEmpName.Text, out yearsWorked);
                int totalDebt;
                int.TryParse(txtPrevDebt.Text, out totalDebt);  
                

               
                
                    if(yearsWorked < 10 && yearsWorked > 0) // checking if years worked is less than 10 and bigger than 0.
                    {
                        lstLoyalty.Items.Add("Dear " + name + "thank you for you loyal service");

                        int loyaltyBonus = 0;


                        for (int i = 1; i <= yearsWorked; ++i) // for loop to 
                        {
                            loyaltyBonus += 1000;

                        lstLoyalty.Items.Add("For year " + i + " your loyalty bonus is added and is now " + loyaltyBonus);
                            
                        }

                    

                    
                   if (totalDebt < yearsWorked *1000) // checking if debt is smaller than years worked.
                    {
                        lstDebt.Items.Add("You owe the company " + totalDebt + ". For each year 500 is deducted to pay debt.");
                        int loyaltyBonus2 = yearsWorked *1000;
                        int j = 1;

                        while (totalDebt >= 500) // checking if debt is bigger than 500 then doing neccacary calculations to print the debt after each year
                        {
                            totalDebt -= 500;
                            loyaltyBonus2 -= 500;

                            lstDebt.Items.Add("New debt after year" + j + " debt is " + totalDebt);
                            lstDebt.Items.Add("New loyalty after year" + j + " debt is " + loyaltyBonus2);

                            j++;

                        }
                        lstDebt.Items.Add("Company will write off remaining " + totalDebt + " on your debt");
                        totalDebt = 0;
                    }
                    else
                    {
                        MessageBox.Show("Enter debt amount lower than your loyalty bonus.");
                    }

                }
                    else if(yearsWorked > 9) // checking if years worked thengiving neccecary bonusses
                {
                    lstLoyalty.Items.Add("Dear " + name + "thank you for you loyal service");

                    int loyaltyBonus = 0;


                    for (int i = 1; i <= yearsWorked; ++i)// for loop to iterate through the years
                    {
                        loyaltyBonus += 2000;

                        lstLoyalty.Items.Add("For year " + i + " your loyalty bonus is added and is now " + loyaltyBonus);

                    }

                    lstDebt.Items.Add("You owe the company " + totalDebt + ". For each year 500 is deducted to repay debt");

                   if(totalDebt < yearsWorked * 2000)
                    {
                        lstDebt.Items.Add("You owe the company " + totalDebt + ". For each year 500 is deducted to pay debt.");
                        int loyaltyBonus2 = yearsWorked * 2000;
                        int j = 1;

                        while (totalDebt >= 500) // while loop to check debt and do neccacary calculations
                        {
                            totalDebt -= 500;
                            loyaltyBonus2 -= 500;

                            lstDebt.Items.Add("New debt after year" + j + " debt is " + totalDebt);
                            lstDebt.Items.Add("New loyalty after year" + j + " debt is " + loyaltyBonus2);

                            j++;

                        }
                        lstDebt.Items.Add("Company will write off remaining " + totalDebt + " on your debt");
                        totalDebt = 0;
                    }
                    else// 
                    {
                        MessageBox.Show("Enter debt amount lower than your loyalty bonus.");
                    }



                }
                else
                {
                    MessageBox.Show("No employers work here less than one year.");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error."); // when error occurs
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEmpName.Clear();
            txtNoYW.Clear();
            txtPrevDebt.Clear();
            lstDebt.Items.Clear();
            lstLoyalty.Items.Clear();
        }
    }
}
