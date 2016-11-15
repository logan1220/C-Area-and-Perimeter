//Logan Sirdevan
//COP2010 Project 1
//To create an application to calculate the area and perimeter of either a circle or rectangle
//Sept 15, 2016
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1LSirdevan
{
    public partial class Form1 : Form
    {
        double dblLegnth = 0, dblRadius = 0, dblWidth = 0, dblArea = 0, dblPerimeter = 0; //declare our vars

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            //clear radius text box since it's not being used. Don't want to confuse the user.
            txtRadius.Clear();

            try //try to parse the text entered in the Legnth and Width boxes. If char isn't a number, return with error.
            {
                dblLegnth = double.Parse(txtLegnth.Text);
                dblWidth = double.Parse(txtWidth.Text);
            }
            catch
            {
                MessageBox.Show("Enter a valid number for the legnth and width!");
                txtLegnth.Clear();
                txtWidth.Clear();
            }
            
            //do math
            dblArea = dblLegnth * dblWidth;
            dblPerimeter = (2 * dblLegnth) + (2 * dblWidth);

            //assign area and perimeter to new vars after math is done. Also rounds to 4 places.
            txtArea.Text = dblArea.ToString("0.0000");
            txtPerimeter.Text = dblPerimeter.ToString("0.0000");

        }//end method

        private void btnCircle_Click(object sender, EventArgs e)
        {
            //clear legnth and width text box since it's not being used. Don't want to confuse the user.
            txtLegnth.Clear();
            txtWidth.Clear();
            
            try //try to parse the text entered in the Radius box. If char isn't a number, return with error.
            {
                dblRadius = double.Parse(txtRadius.Text);
            }
            catch
            {
                MessageBox.Show("Enter a valid number for the radius!");
                txtRadius.Clear();
            }

            //do math
            dblArea= Math.PI * (dblRadius * dblRadius);
            dblPerimeter = Math.PI * (2 * dblRadius);
            
            //assign area and perimeter to new vars after math is done. Also rounds to 4 places.
            txtArea.Text = dblArea.ToString("0.0000");
            txtPerimeter.Text = dblPerimeter.ToString("0.0000");           

        }//end method
    }//end class
}//end namespace
