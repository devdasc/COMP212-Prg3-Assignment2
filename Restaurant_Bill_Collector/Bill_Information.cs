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
 * Name : Devdas Chatterjee
 * ID: 300874157
 */

namespace Restaurant_Bill_Collector
{
    public partial class Bill_Information : Form
    {
        // Instantiating List objects
        List<Appetizer> appetizerList = new List<Appetizer>();
        List<Beverage> beverageList = new List<Beverage>();
        List<MainCourse> mainCourseList = new List<MainCourse>();
        List<Dessert> dessertList = new List<Dessert>();
        List<MenuItems> menuItemList = new List<MenuItems>();
        public Bill_Information()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bill_Information_Load(object sender, EventArgs e)
        {
            ListViewDetails();
            AddItemsToComboBox();
        }
        // Add columns adn heading to te Listview object
        public void ListViewDetails()
        {
            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Columns.Add("Name", 150);
            listView.Columns.Add("Quantity", 80);
            listView.Columns.Add("Price", 150);
        }
        // Add Menu lists to the comboboxes
        public void AddItemsToComboBox()
        {
            AppetizerList();
            BeverageList();
            MainCourseList();
            DessertList();          
        }
        // Add Appetizer list to the Apptizer Combobox
        public void AppetizerList()
        {
            comboBox_App.Items.Add("--Select Items--");
            appetizerList.Add(new Appetizer("Buffalo Wings", 5.95));
            appetizerList.Add(new Appetizer("Buffalo Fingers", 6.95));
            appetizerList.Add(new Appetizer("Potato Skins", 8.95));
            appetizerList.Add(new Appetizer("Nachos", 8.95));
            appetizerList.Add(new Appetizer("Mushroom Caps", 10.95));
            appetizerList.Add(new Appetizer("Shrimp Cocktail", 12.95));
            appetizerList.Add(new Appetizer("Chips and Salsa", 6.95));

            foreach (Appetizer appetizer in appetizerList)
                comboBox_App.Items.Add(appetizer.getName());
            // sets "--Select Items--" at the top of the list
            comboBox_App.SelectedIndex = 0;
        }
        // Add beverage list to the Beverage Combobox
        public void BeverageList()
        {
            comboBox_Bev.Items.Add("--Select Items--");
            beverageList.Add(new Beverage("Soda", 1.95));
            beverageList.Add(new Beverage("Tea", 1.50));
            beverageList.Add(new Beverage("Coffee", 1.25));
            beverageList.Add(new Beverage("Mineral Water", 2.95));
            beverageList.Add(new Beverage("Juice", 2.50));
            beverageList.Add(new Beverage("Milk", 1.50));

            foreach (Beverage beverage in beverageList)
                comboBox_Bev.Items.Add(beverage.getName());
            // sets "--Select Items--" at the top of the list
            comboBox_Bev.SelectedIndex = 0;

        }
        // Add main course list to the MainCourse Combobox
        public void MainCourseList()
        {
            comboBox_Main.Items.Add("--Select Items--");
            mainCourseList.Add(new MainCourse("Seafood Alfredo", 15.95));
            mainCourseList.Add(new MainCourse("Chicken Alfredo", 13.95));
            mainCourseList.Add(new MainCourse("Chicken Picatta", 13.95));
            mainCourseList.Add(new MainCourse("Turkey Club", 11.95));
            mainCourseList.Add(new MainCourse("Lobster Pie", 19.95));
            mainCourseList.Add(new MainCourse("Prime Rib", 20.95));
            mainCourseList.Add(new MainCourse("Shrimp Scampi", 18.95));
            mainCourseList.Add(new MainCourse("Turkey Dinner", 13.95));

            foreach (MainCourse mainCourse in mainCourseList)
                comboBox_Main.Items.Add(mainCourse.getName());
            // sets "--Select Items--" at the top of the list
            comboBox_Main.SelectedIndex = 0;
        }
        // Add dessert list to the Dessert Combobox
        public void DessertList()
        {
            comboBox_Des.Items.Add("--Select Items--");
            dessertList.Add(new Dessert("Apple Pie", 5.95));
            dessertList.Add(new Dessert("Sundae", 3.95));
            dessertList.Add(new Dessert("Carrot Cake", 5.95));
            dessertList.Add(new Dessert("Mud Pie", 4.95));
            dessertList.Add(new Dessert("Apple Crisp", 5.95));

            foreach (Dessert dessert in dessertList)
                comboBox_Des.Items.Add(dessert.getName());
            // sets "--Select Items--" at the top of the list
            comboBox_Des.SelectedIndex = 0;
        }
        /*
        checks if a item is in the menuitem already
        return false if does not exist
        return true if exists and increment setQuantity by 1
         */
        public bool CheckItem(string item)
        {
            bool doesExist = false;
            foreach(MenuItems menuItem in menuItemList)
            {
                if (item == menuItem.getName())
                {
                    menuItem.setQuantity(menuItem.getQuantity() + 1);
                    doesExist = true;
                }
            }
            return doesExist;
        }
        /* add appetizer item to menuitems when user clicks add button */ 
        public void AddAppetizerToMenuItems(string item)
        {
            foreach(Appetizer appetizer in appetizerList)         
                if (item == appetizer.getName())               
                    if (!CheckItem(appetizer.getName()))
                        menuItemList.Add(new MenuItems(appetizer.getName(), 1, appetizer.getPrice()));
        }
        /* add benerage item to menuitems when user clicks add button */
        public void AddBeverageToMenuItems(string item)
        {
            foreach(Beverage beverage in beverageList)        
                if (item == beverage.getName())             
                    if (!CheckItem(beverage.getName()))                 
                        menuItemList.Add(new MenuItems(beverage.getName(),1,beverage.getPrice()));
        }
        /* add maincourse item to menuitems when user clicks add button */
        public void AddMainCourseToMenuItems(string item)
        {
            foreach(MainCourse maincourse in mainCourseList)          
                if (item == maincourse.getName())             
                    if (!CheckItem(maincourse.getName()))                 
                        menuItemList.Add(new MenuItems(maincourse.getName(), 1, maincourse.getPrice()));            
        }
        /* add dessert item to menuitems when user clicks add button */
        public void AddDessertToMenuItems(string item)
        {
            foreach(Dessert dessert in dessertList)          
                if (item == dessert.getName())               
                    if (!CheckItem(dessert.getName()))                   
                        menuItemList.Add(new MenuItems(dessert.getName(), 1, dessert.getPrice()));                    
        }
        public void GetComboBoxValues()
        {
            // clears previous items added to listview 
            listView.Items.Clear();
            // method call
            AddAppetizerToMenuItems(comboBox_App.Text);
            AddBeverageToMenuItems(comboBox_Bev.Text);
            AddMainCourseToMenuItems(comboBox_Main.Text);
            AddDessertToMenuItems(comboBox_Des.Text);
        }
        public void CalculateSubTotal()
        {
            double subtotal = 0;
            double tax = 0;
            double total = 0;
            foreach (MenuItems item in menuItemList)
            {
                subtotal += item.getQuantity() * item.getPrice();
                //binding menuitems to listview
                ListViewItem lvi = new ListViewItem(item.name);
                lvi.SubItems.Add(item.quantity.ToString());
                lvi.SubItems.Add(item.price.ToString());
                listView.Items.Add(lvi);
            }   
            // canculates subtotal, tax and total and assign values to respective textboxes 
            tax = subtotal * 0.13;
            total = subtotal + tax;
            subtotal_textBox.Text = string.Format("{0:c} ", subtotal);
            tax_textBox.Text = string.Format("{0:c} ", tax);
            total_textBox.Text = string.Format("{0:c} ", total);
        }     
        public void ResetComboBox()
        {
            // setting all combo box items indexes to 0
            comboBox_App.SelectedIndex = comboBox_Bev.SelectedIndex = comboBox_Des.SelectedIndex = comboBox_Main.SelectedIndex = 0;
        }
        // event happens when user clicks add button
        private void Add_button_Click(object sender, EventArgs e)
        {         
            GetComboBoxValues();
            CalculateSubTotal();
            ResetComboBox();
        }
        //clears all values when user clicks clear button
        private void Clear_button_Click(object sender, EventArgs e)
        {
            subtotal_textBox.Text = "$0.00";
            tax_textBox.Text = "$0.00";
            total_textBox.Text = "$0.00";
            listView.Items.Clear();
            menuItemList.Clear();
        }
        private void Sub_label_Click(object sender, EventArgs e)
        {

        }
        private void comboBox_App_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void remove_button_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore.exe", "http://www.restaurantbonaparte.com/en/");
        }
    }
}
