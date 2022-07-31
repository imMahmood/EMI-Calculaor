using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmiCalcuator
{
    public partial class Form1 : Form
    {

        List<Model> ts = new List<Model>();

        public Form1()
        {
            InitializeComponent();

            loadDropDown();

        }

        private void loadDropDown()
        {
            

            instalmentType_list.Items.Add("Monthly");
            instalmentType_list.Items.Add("Weekly");

        }

        private void submit_Click(object sender, EventArgs e)
        {
            
            if (loanAmount_textbox.Text == "" || loanAmount_textbox.Text == null ||
                instalments_textBox.Text == "" || instalments_textBox.Text == null ||
                intrest_textBox.Text == "" || intrest_textBox.Text == null)
            {
                MessageBox.Show("Please Enter All Details");
            }
            else if (instalmentType_list.Text == null || instalmentType_list.Text == "")
            {
                MessageBox.Show("Please Enter Installment Type");

            }
            else
            {
               

                    double amount = Convert.ToDouble(loanAmount_textbox.Text);
                string dropdownSelectedValue = instalmentType_list.Text;
                    //Decimal intrestAnually  = Convert.ToDecimal(intrest_textBox.Text);
                    double intrestAnually = Convert.ToDouble(intrest_textBox.Text);
                    double noOfInstalments = Convert.ToDouble(instalments_textBox.Text);
                    double monthlintalmentRate = intrestAnually / 12;
                    monthlintalmentRate = dropdownSelectedValue.Equals("Monthly")? monthlintalmentRate / 100 : (monthlintalmentRate / 100)/4.327;

                    int av = (int)noOfInstalments;

                    for (int i = 1; i <= av; i++) {
                        Model model = new Model();
                        double a = Math.Pow(monthlintalmentRate + 1, noOfInstalments--);
                        double b = a / (a - 1);
                        model.sno = i;
                        model.intrestAmount = amount * monthlintalmentRate;
                        double finalAmount = amount * monthlintalmentRate * b;
                        model.dueAmount = amount = amount - (finalAmount - (amount * monthlintalmentRate));
                        model.principalAmount = (finalAmount - (amount * monthlintalmentRate));
                        ts.Add(model);

                    }

                    Form2 form2 = new Form2(ts);
                    form2.BringToFront();
                    form2.ShowDialog();



          
               
            }



        }
    }
}
