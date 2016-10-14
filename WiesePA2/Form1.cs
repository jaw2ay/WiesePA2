using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiesePA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cost.Text ="";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calc_Click(object sender, EventArgs e)
        {
            int chocolate,
                strawberry,
                vanilla;
            //convert updownbox values to integers for use in calculations
            chocolate = (int)chocIce.Value;
            strawberry = (int)strawIce.Value;
            vanilla = (int)vanIce.Value;

            //count how many topping checkboxes are checked and add that count to 
            //an int called toppings using a linq query

            int toppings = 0;
            try
            {
                toppings = groupBox2.Controls.OfType<CheckBox>().Count(x => x.Checked);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //check which radiobox is checked in Apparatus groupBox
            //if cup is checked assign int app 1
            //else if cone is checked assign app 2
            //app used as placemarker for input into IceCream Class
            int app = 0;
            
            if (cup.Checked == true)
            {
                app = 1;
            }
            else if(cone.Checked == true)
            {
                app = 2;
            }


            //instantiates the IceCream Class for Calculations
            IceCream Ice = new IceCream(chocolate, strawberry, vanilla, toppings, app);

            //parses final calulation to cost label
            cost.Text = string.Format("{0:C}", Ice.FinalCost());

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //resets the values when clear is clicked
            chocIce.Value = 0;
            strawIce.Value = 0;
            vanIce.Value = 0;

            peanuts.Checked = false;
            fudge.Checked = false;
            sprinkles.Checked = false;
            marshmellow.Checked = false;
            cherries.Checked = false;
            toffee.Checked = false;

            cup.Checked = true;

            cost.Text = "";
        }
    }
}
