using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics;

namespace _1815101_Gregorio_R_ICT525_A2
{
    public partial class Form1 : Form
    {
        
        public class Item //public class Item is needed so we can store data to into it later 
        {
            public string Name { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
            public override string ToString() // cmbitems calls the the ToString method to display the item in the UI,
            {                                 //overriding the method, allows you to pass an entire item into cmbitem but
                return Name;                  //will only display Name, but the other data connected to that name are both still there. 
            }
        }
        public static string CustomerName { get; set; }
        public static string CustomerEmail { get; set; }
        public static string CustomerAddress{ get; set; }

       

        public class choice
        {
            public string ChosenItem { get; set; }
            public decimal ChosenPick { get; set; }
            public decimal ChosenTotal { get; set; }

        }
        List<choice> Choices = new List<choice>();
    public Form1()
        {
            InitializeComponent();
        }

 
        private void Form1_Load(object sender, EventArgs e)
        {

            grpItem.Enabled = false; //disables the item list group box, and the buttons for add and view to cart at the start. 
            btnAddtoCart.Enabled = false;
            btnView.Enabled = false;
            numItems.Enabled = false;

            using (StreamReader streamReader = new StreamReader(@".\ListOfItems.txt"))
            {
                while (!streamReader.EndOfStream)
                {//reads ListOfItems.txt by line, and only stops when it reach the end of the stream of the .txt file 

                        string line = streamReader.ReadLine(); //based on how it's been Split, splits[0] stores all the names, 
                        string[] splits = line.Split('|'); //splits[1] stores all the price, and splits[2] stores all the stock 
                        string name = splits[0]; 
                        string price = splits[1];
                        string quantity = splits[2];
                        //decimal price_decimal = decimal.Parse(price);         //converts price which were a string into a decimal type, for use later
                        //int quantity_int = int.Parse(quantity);              //converts the quantity which were a string into a integer type, for use later.
                        Item item = new Item()  //item will now hold everything related to Name, Price, and Quantity
                        {
                            Name = name,
                            Price = price,
                            Quantity = quantity,


                        };
              
                        cmbItem.Items.Add(item); //now because public overide string ToString() { return Name; } 
                                                //it will only return Name and all the date correlating with it still attached to it
                }
            }
            cmbItem.Items.RemoveAt(0);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            grpItem.Enabled = true; //due to the event of the create order button being clicked we can now activate the groupbox and the buttons
            btnAddtoCart.Enabled = true;
            btnView.Enabled = true;

            CustomerName = txtName.Text; 
            CustomerEmail = txtEmail.Text;
            CustomerAddress = txtAddress.Text;

           

            

        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            numItems.Enabled = true;
            Item selectedItem = (Item)cmbItem.SelectedItem;           //creates a SelectedItem property for the Item class
            lblItemPrice.Text = selectedItem.Price.ToString();       // will now update with correct price matching with name selected on the combo box
            lblitemsLeft.Text = selectedItem.Quantity.ToString();   // will now update with the correct stock amount matching with the name selected on the combo box
            numItems.Maximum = int.Parse(selectedItem.Quantity);   // sets the maximum value to match the selected item's quantity




        }
        private void btnView_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(Choices);
            frm2.Show();
        }
         private void button1_Click(object sender, EventArgs e)
        {
            if (numItems.Value == 0)
            {
                MessageBox.Show("No. of items needed is currently 0, please input the quantity of items you need" );

            }
            else
            {
                string pickeditem = cmbItem.Text; 
                string pickeditemprc = lblItemPrice.Text;
                decimal PickedPrice = Convert.ToDecimal(pickeditemprc);
                decimal pickeditemqty = numItems.Value;
                decimal totalprice = PickedPrice * pickeditemqty; //multiply the item price and the number bought by the customer

                choice x = new choice
                {
                    ChosenItem = pickeditem,
                    ChosenPick = pickeditemqty,
                    ChosenTotal = totalprice
                };
                Choices.Add(x); //adds them to the list to be moved to form2

                decimal leftstock = decimal.Parse(lblitemsLeft.Text) - numItems.Value;  //reduces the value of stock whenever something is added to cart
                lblitemsLeft.Text = leftstock.ToString();                               //due to not being a requirement, this part just works aesthetically
                numItems.Maximum = leftstock;                                          //whenever the item is re selected it resets the stock amount


                
                

              

            }


        }

        private void lblItemPrice_Click(object sender, EventArgs e)
        {

        }

        private void grpItem_Enter(object sender, EventArgs e)
        {

        } 
        private void numItems_ValueChanged(object sender, EventArgs e)
        {
            
        }      
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      

        private void grpInfo_Enter(object sender, EventArgs e)
        {

        }


    }
}
