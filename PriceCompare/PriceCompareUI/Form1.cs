using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PriceCompare.Calculations;
using PriceCompare.Components;
using PriceCompare.XmlManipulation;

namespace PriceCompareUI
{
    /**
    * When creating a UI application- consider one of the following paradigms: MVC, MVP or MVVM
    * It is best to refrain from coding in the codebehind of the UI class.
    * This enables better testability and separation of UI from User interaction and Business Logic.
    * 
    * Consider :
    * a) https://he.wikipedia.org/wiki/Model_View_Controller
    * b) https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93presenter
    * c) https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93viewmodel
    */
    public partial class Form1 : Form
    {
        private readonly PriceCalculator PriceCaluclator = new PriceCalculator();

        public Form1()
        {
            InitializeComponent();
        }

        private async void LoadItemsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * It is not a good practice to be aware of persistence specifics (or of the existense of persistence) in UI code.
                   Consider: https://en.wikipedia.org/wiki/Multitier_architecture

                 */
                XmlParser.ParseXml();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show(@"Please try to load items again in a few seconds", @"Bad Boy!");
            }
            
            listBox1.Items.Clear();

            //Any exception thrown by the task returned from the below method would crash your application
            var filteredList = await FilterXML.FilterXmlList();

            if (filteredList != null)
                listBox1.Items.AddRange(filteredList.ToArray());

            getMinMaxBtn.Enabled = true;
            searchBtn.Enabled = true;
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            //One month from now, will you remember what does listBox1 stand for? how about the other one? How about the difference between them
            /*
             * Consider: http://www.goodreads.com/book/show/3735293-clean-code
             */
            if (listBox1.SelectedItem != null) listBox2.Items.Add(listBox1.SelectedItem);
        }
        private void RmvcartBtn_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }
        private void calcPricebtn_Click(object sender, EventArgs e)
        {
            var listboxItems = listBox2.Items.Cast<ItemInformation>();
            var priceList = PriceCaluclator.CalculatePrice(listboxItems);
            total1lbl.Font = new Font(total1lbl.Font.Name, 8, FontStyle.Bold | FontStyle.Underline);

            try
            {
                total1lbl.Text = priceList[0];
                total2lbl.Text = priceList[1];
                total3lbl.Text = priceList[2];
                total1lbl.Visible = true;
                total2lbl.Visible = true;
                total3lbl.Visible = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(@"Please Select Items First.", @"No Items Selected");
            }
        }
        private void getMinMaxBtn_Click(object sender, EventArgs e)
        {
            var minMaxItems = PriceCaluclator.CalculateMinMax();

            var minList = PriceCaluclator.GetMin(minMaxItems);
            var maxList = PriceCaluclator.GetMax(minMaxItems);
            minlbl.Text = minList;
            maxlbl.Text = maxList;
        }

       private void searchBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(SearchXML.Result(searchBox.Text).ToArray());
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            searchBtn_Click(this, new EventArgs());
            searchBox.Clear();
        }

        private void clearCartBtn_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            total1lbl.Visible = false;
            total2lbl.Visible = false;
            total3lbl.Visible = false;
        }
    }
}