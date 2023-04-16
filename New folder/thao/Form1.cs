    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace ASM2_Programming_MilkTeaPanda
    {
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
       

        //Calculation total money
        private void btn_Add_Click(object sender, EventArgs e)
        {

            if (txt_Name.Text == "")
            {
                MessageBox.Show("Please input your name!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_PhoneNumber.Text == "")
            {
                MessageBox.Show("Please choose number of table!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

            else if (cbb_Pay.Text == "")
            {
                MessageBox.Show(" Choose method, please");
                cbb_Pay.Focus();
                return;
            }
            else if(txt_quantity.Text=="")
            {
                MessageBox.Show(" Choose quantity, Please");
                txt_quantity.Focus();
                return;
            }

            else
            {
                int h1 = cb_hotel1.Checked ? 5 : 0;
                int q1 = int.Parse(txt_h1.Text);

                int h2 = cb_hotel2.Checked ? 10 : 0;
                int q2 = int.Parse(txt_h2.Text);

                int h3 = cb_hotel3.Checked ? 11 : 0;
                int q3 = int.Parse(txt_h3.Text);

                int h4 = cb_hotel4.Checked ? 14 : 0;
                int q4= int.Parse(txt_h4.Text);

                int h5 = cb_hotel5.Checked ? 15 : 0;
                int q5 = int.Parse(txt_h6.Text);

                int h6 = cb_hotel6.Checked ? 16 : 0;
                int q6 = int.Parse(txt_h6.Text);    

                int h7 = cb_hotel7.Checked ? 17 : 0;
                int q7 = int.Parse(txt_h7.Text);

                int h8 = cb_hotel8.Checked ? 18 : 0;
                int q8 = int.Parse(txt_h8.Text);

                int total = (h1*q1) + (h2*q2) + (h3*q3) + (h4*q4) + (h5*q5) + (h6*q6) + (h7*q7) +(h8*q8);
                
                    txt_TotalMoney.Text = total.ToString();

            }
        }
            
    



        
            
            

            //delete information customer on data-gird
            private void btn_Remove_Click(object sender, EventArgs e)
            {
                int rowIndex = data_table.CurrentRow.Index;
                data_table.Rows.RemoveAt(rowIndex);
            }

            //update information customer
            private void btn_Update_Click(object sender, EventArgs e)
            {
                int rowIndex = data_table.CurrentRow.Index;

            

                data_table[0, rowIndex].Value = txt_Name.Text;
                data_table[1, rowIndex].Value = txt_PhoneNumber.Text;
                data_table[2, rowIndex].Value = txt_TotalMoney.Text;
                data_table[3, rowIndex].Value = cbb_Pay.Text;
            data_table[4, rowIndex].Value = txt_quantity.Text;



           

            }

            //stop the program
            private void btn_Exit_Click(object sender, EventArgs e)
            {
                try
                {
                    DialogResult dr = MessageBox.Show("Are you sure to exit?", "Confirm",
                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }

            //buy list item chosen
            private void OK_Click(object sender, EventArgs e)
            {
                try
                {
                    DialogResult dr = MessageBox.Show("Are you sure to Buy?", "Confirm",
                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show("Your order has been confirmed in the system. " +
                            "Please wait a moment! Thank you so much!");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }

        private void btn_Addgird_Click(object sender, EventArgs e)
        {

            data_table.Rows.Add(txt_Name.Text, txt_PhoneNumber.Text, txt_TotalMoney.Text, cbb_Pay.Text, txt_quantity.Text);
        }

        private void txt_TotalMoney_TextChanged(object sender, EventArgs e)
        {
           int totalMoney = int.Parse(txt_TotalMoney.Text);
        }
    }
        

         

            

           

        
    }
   
        

