using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;

namespace _1815101_Gregorio_R_ICT525_A2
{
    public partial class Form2 : Form
    {
        public Form2(List<Form1.choice>Choices)
        {
            InitializeComponent();
            btnPlaceOrder.Enabled = false;
             



            var col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Item";
            col1.Name = "ItemName";
            col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataCart.Columns.Add(col1);
            

            var col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Num Required";
            col2.Name = "Quantity";
            col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataCart.Columns.Add(col2);

            var col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Total Price";
            col3.Name = "Price";
            col3.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataCart.Columns.Add(col3);
            


            decimal sumtotal = 0; //needed to get the total price
            int counter = Choices.Count; //counts the number of items in Choices
           
            if (counter == 0) //checks if the users has added anything to cart by checking the number of items inside the list
            {                 //if it's 0 then a message is shown to inform the user to add items to cart
                string need = "Please Add Items to cart";
                dataCart.Rows.Add(need);
            }

            else 
            {
                
                foreach (Form1.choice choice in Choices) //adds the items on the rows 
                {
                    dataCart.Rows.Add(
                        choice.ChosenItem,
                        choice.ChosenPick,
                        "$" + choice.ChosenTotal);
                }

                for (int i = 0; i < counter; i++) //gets the final total of all added to cart items
                {
                    sumtotal = sumtotal + Choices[i].ChosenTotal;
                }

                lblfinaltotal.Text = "$" + sumtotal;
                btnPlaceOrder.Enabled = true;

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblCustomerName.Text = Form1.CustomerName;
            lblCustomerEmail.Text = Form1.CustomerEmail;
            lblCustomerAddress.Text = Form1.CustomerAddress;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            


            try
            {
                
                StreamWriter Orderwriter = new StreamWriter(@".\Orderform.txt");
                
                Orderwriter.WriteLine("*******************INVOICE*******************");
                Orderwriter.WriteLine("Customer Name: {0}", Form1.CustomerName);
                Orderwriter.WriteLine("Customer Email: {0}", Form1.CustomerEmail);
                Orderwriter.WriteLine("Customer Address: {0}", Form1.CustomerAddress);
                Orderwriter.WriteLine("Invoice Date: {0}", DateTime.Now.ToString());
                Orderwriter.WriteLine("------------------------------------------------");
                Orderwriter.WriteLine("Item\t\t|No. Of Items Ordered\t|Price");
                Orderwriter.WriteLine("------------------------------------------------");
                                                                            //For Loop is used to print the value of each row of data in the dataCart datagridview
                for (int i = 0; i < dataCart.Rows.Count; i++)               //the outer for loop focuses on handling which row to read and write to the text file
                {
                    for (int j = 0; j < dataCart.Columns.Count; j++)        //the inner for loop focuses on moving to each of columms of that row 
                    {

                        if (j == 0) //for aesthetic purposes only if the length of the item name is below 8 characters it will have 2 tabs
                        {
                            if (dataCart.Rows[i].Cells[j].Value.ToString().Length <= 8)          
                            {
                                Orderwriter.Write(dataCart.Rows[i].Cells[j].Value.ToString() + "\t" + "\t");
                            }

                            else if(dataCart.Rows[i].Cells[j].Value.ToString().Length >= 8)
                            {
                                Orderwriter.Write(dataCart.Rows[i].Cells[j].Value.ToString() + "\t");
                            }


                        }
                        else if (j == 1) 
                        {
                            if (dataCart.Rows[i].Cells[j].Value.ToString().Length <= 8)
                            {
                                Orderwriter.Write("\t" + "  " + dataCart.Rows[i].Cells[j].Value.ToString() + "\t" + "\t");
                            }
                        }

                        else
                        {
                            Orderwriter.Write(dataCart.Rows[i].Cells[j].Value.ToString() + "\t"); //writes the current value on that exact positon
                        }
                        if (j != dataCart.Columns.Count - 1) // adds "|"  to still emulate the seperation of each data on a table, 
                        {                                   // the reason dataCart.Columns.Count - 1 because once it reaches the end it doesnt need the "|"
                           Orderwriter.Write("|");
                        }
                    }
                    Orderwriter.WriteLine(""); //moves to a new line once every column is passed 
                }

                

                Orderwriter.Close();
            }
            catch (Exception h)
            {
                MessageBox.Show("Exception: " + h.Message); //creates an exception if file creation ended up getting corrupted 
            }
            finally
            {
                MessageBox.Show("Order Placed! Order Invoice can be found in:"+ @"\1815101_Gregorio_R_ICT525_A2\1815101_Gregorio_R_ICT525_A2\bin\Debug\Orderform.txt");
            }

        }
    }
}
