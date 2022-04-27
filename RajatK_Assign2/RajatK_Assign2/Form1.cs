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
using System.Data;
using System.Linq;

// Rajat kadian
// 300351928
//CSIS1175-004

namespace RajatK_Assign2
{
    public partial class Form1 : Form
    {

        List<Grocery> GroceryList = new List<Grocery>();  //empty List created
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadAllUsersToListBox() //Adding user in ListBox 
        {
            OutputListBox.Items.Clear();
            //OutputListBox.Items.Add("ItemName\tItemId\tUnitPrice\tStartQty\tQtyMinForRestock\tQtySold\tQtyRestocked\tQtyHand\tSales");
            OutputListBox.Items.Add(string.Format("{0,10} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20} {7,20} {8,20}\n", "ItemName","ItemId"
                ,"UnitPrice","StartQty","QtyMinForRestock","QtySold","QtyRestocked","QtyHand","Sales"));
            foreach (Grocery user in GroceryList)
            {
                //OutputListBox.Items.Add(user);
                OutputListBox.Items.Add(string.Format("{0,10}{1,20} {2,20} {3,20} {4,20} {5,20} {6,20} {7,20} {8,20}", user.ItemName,
                    user.ItemCode, user.UnitPrice.ToString("C"), user.StartingQty, user.QtyMiniForRestock, user.QtySold, user.QtyRestocked, 
                    user.QuantityOnHand, user.TotalSales.ToString("C")));
              //  MessageBox.Show(user.ToString());
            }
        }

        private void ReadFileBtn_Click(object sender, EventArgs e) //Reading file named as localgrocery.csv 
        {
            GroceryList.Clear();
            try
            {
                using (StreamReader reader = new StreamReader("localgrocery.csv"))
                {
                    string eachLine;
                    
                    if (!reader.EndOfStream)
                    {    
                        eachLine = reader.ReadLine();   
                        MessageBox.Show(eachLine);   //Reading Header line
                    }
                    while(!reader.EndOfStream)
                    {
                        eachLine = reader.ReadLine();
                        string[] eachUserFields = eachLine.Split(',');    //Splitting the data to string and storing in array
                        string ItemName = eachUserFields[0];        //assigning value to array
                        string ItemId = eachUserFields[1];
                        string unitPrice = eachUserFields[2];
                        double.TryParse(unitPrice, out double UnitPrice); //converting to double value
                        string startQty = eachUserFields[3];
                        int.TryParse(startQty, out int StartQty); //converting to int and storing it in array
                        string qtyMinForRestock = eachUserFields[4];
                        int.TryParse(qtyMinForRestock, out int QtyMinForRestock);
                        string qtySold = eachUserFields[5];
                        int.TryParse(qtySold, out int QtySold);
                        string qtyRestocked = eachUserFields[6];
                        int.TryParse(qtyRestocked, out int QtyRestocked);
                        Grocery eachUser = new Grocery(ItemName, ItemId, UnitPrice, StartQty, QtyMinForRestock, QtySold,QtyRestocked); //creating object of Grocery class as eachUser
                        GroceryList.Add(eachUser);

                    }

                    LoadAllUsersToListBox();

                    StatusLabel.Text = "Loaded\t" + " " + GroceryList.Count + " " +"\titems from the input file";




                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxLoad_Enter(object sender, EventArgs e)
        {

        }

        private void UpdateSoldQty_Click(object sender, EventArgs e)  //update sold quantity and changing in output box
        {
            int listBox = OutputListBox.SelectedIndex;
            if (QtySoldTextBox.Text == "" || OutputListBox.SelectedIndex == 0) //if user enter 0 or empty
            {
                MessageBox.Show("Please select a grocery item to increment sold qty");
            }

            else if(OutputListBox.SelectedIndex > 0 )  //if selected index is greater than zero
            {
               
                if (!int.TryParse(QtySoldTextBox.Text, out int qtySold) || GroceryList[listBox - 1].QuantityOnHand < qtySold) //if value is not string  
                {
                    StatusLabel.Text = "Error can be integer > 0  and QuantityOnHand should be less than Entered only";
                   // int listBox = OutputListBox.SelectedIndex; //3
                   // MessageBox.Show((GroceryList[listBox-1].QuantityOnHand.ToString()));

                }

                else if (int.TryParse(QtySoldTextBox.Text, out qtySold) && GroceryList[listBox - 1].QuantityOnHand > qtySold && qtySold > 0)
                {
                    GroceryList[listBox-1].QtySold += qtySold;
                    OutputListBox.Items[listBox] = GroceryList[listBox - 1];   //changing value in listbox
                    StatusLabel.Text = "Incremented Qty Sold for item with item code" + "" + GroceryList[listBox-1].ItemCode; //changing value in listbox
                    LoadAllUsersToListBox();
                }

               

            }


        }

        private void RestockedSoldQty_Click(object sender, EventArgs e) //when button is click changing value in Outputlistbox and also in Grocery List
        {
            int listBox = OutputListBox.SelectedIndex;
            if (QtyResTextBox.Text == "" || OutputListBox.SelectedIndex == 0)  //if header is slected or nothing is selected
            {
                MessageBox.Show("Please select a grocery item to increment sold qty");
            }

            else if (OutputListBox.SelectedIndex > 0) //if selected other than header in OutputListBox
            {
                if (!int.TryParse(QtyResTextBox.Text, out int qtyRes) || GroceryList[listBox - 1].QtyRestocked < 0)
                {
                    StatusLabel.Text = "Error can be integer > 0  and QuantityOnHand should be less than Entered only";


                }

                else if (int.TryParse(QtyResTextBox.Text, out qtyRes) && qtyRes > 0 )  //changing the value Of restocked our In List and in ListBox 
                {
                    GroceryList[listBox - 1].QtyRestocked += qtyRes;
                    OutputListBox.Items[listBox] = GroceryList[listBox - 1];
                    StatusLabel.Text = "Incremented Restocked Qty  for item with Item Code" + GroceryList[listBox - 1].ItemCode;
                    LoadAllUsersToListBox();
                }

            }
                

            



        }

        private void DeleteUserBtn_Click(object sender, EventArgs e)  //delete selected row
        {
            int listBox = OutputListBox.SelectedIndex;

            if (listBox <= 0 )
            {
                MessageBox.Show("Please select a grocery item to delete");

            }

            else
            {

                GroceryList.RemoveAt(listBox - 1); //deleting from list
                OutputListBox.Items.RemoveAt(listBox); //deleting from OutputListBox
                StatusLabel.Text = "Deleted record for Item with item code \t" + " " + GroceryList[listBox - 1].ItemCode; //displayong in status label

            }
        }

        private void SaveGrocData_Click(object sender, EventArgs e)  //saving report in default folder with named as updategrocery.csv
        {
            try
            {
                using(StreamWriter myOutputStream = new StreamWriter("updategrocery.csv"))
                {
                    string headerline =  "ItemName," + "ItemCode," +  "UnitPrice" + "," + "StartingQty," + "QtyMinForRestock," + "QtySold," + "QtyRestocked," ;
                    myOutputStream.WriteLine(headerline);
                    foreach(Grocery user in GroceryList)
                    {
                        string userLine = user.ItemName + "," + user.ItemCode + "," + user.UnitPrice + "," + user.StartingQty + "," + user.QtyMiniForRestock + "," + user.QtySold + "," + user.QtyRestocked;
                        myOutputStream.WriteLine(userLine);
                    }
                }

                StatusLabel.Text = "Saved" + GroceryList.Count() + "records into the output inventory file";

            }

          
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void SaveSalesReport_Click(object sender, EventArgs e)  //Saving report with named as grocerysales
        {
            try
            {
                using(StreamWriter myOutputStream = new StreamWriter("grocerysales.csv"))
                {
                    string headerline = "ItemName," + "ItemCode," + "UnitPrice," + "QtySold," + "Sales";
                    myOutputStream.WriteLine(headerline);
                    foreach(Grocery user in GroceryList) 
                    {
                        if (user.QtySold > 0)
                        {
                            string userLine = user.ItemName + "," + user.ItemCode + "," + user.UnitPrice + "," + user.QtySold + "," + user.TotalSales + "\n";
                            myOutputStream.Write(userLine);
                        }
                    }                
                }

                List<Grocery> QSoldList = (from user in GroceryList where user.QtySold > 0 select user).ToList();
                StatusLabel.Text = "Saved " + "\t " + QSoldList.Count() + "\t records into the output sales file";

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveRestockNeedBtn_Click(object sender, EventArgs e) //saving another report with groceryrestocks.csv
        {
            try
            {
                using (StreamWriter myOutputStream = new StreamWriter("groceryrestocks.csv"))
                {
                    string headerline = "ItemName," + "ItemCode," + "QtyHand," + "QtyMinrestck";
                    myOutputStream.WriteLine(headerline);
                    foreach(Grocery user in GroceryList)
                    {
                        if (user.QuantityOnHand < user.QtyMiniForRestock)
                        {
                            string userLine = user.ItemName + "," + user.ItemCode + "," + user.QuantityOnHand + "," + user.QtyMiniForRestock + "\n";
                            myOutputStream.Write(userLine);
                        }
                    }

                }

                List<Grocery> QSoldList = (from user in GroceryList where user.QuantityOnHand < user.QtyMiniForRestock select user).ToList();
                StatusLabel.Text = "Saved " + "  " + QSoldList.Count() + " " + "records into the output sales file";




            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OutputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
