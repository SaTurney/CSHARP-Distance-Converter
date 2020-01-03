//Sabrina Turney
//C# I
//Program 4-5: Distance Converter
//Last Edited September 1, 2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//"Note: Be sure to handle the situation where the user picks the
//same units from both list boxes. The converted value will be the same 
//as the value entered." - C# Book Note.
namespace Distance_Converter
{
    public partial class distanceConverter : Form
    {
        public distanceConverter()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            //First we will complete all calculations once the convert button is clicked
            //I will name variables here for the numbers we'll use in calculations for feet yards and inches.
            double enterBoxDistance = double.Parse(this.enterBox.Text);
            //take all input from the "enter" text box to be converted- A double value.

            //named variables - integers for "to" and "from" values fom their boxes to perform necessary calculations.
            int fromBoxDistance = fromBox.SelectedIndex;
            int toBoxDistance = toBox.SelectedIndex;
            //for the "from" value, we need to know which one of inches, feet, or yards we're using.
            //after that, we know what kind of calculation we're performing, and use all the switch cases.
            //This is similar to the "Time Zone" application, except we perform a different calculation
            //depending on which case we have. All cases break when they are finished.
            
            switch (fromBoxDistance)
            {
                case 0:
                    switch (toBoxDistance)
                    {
                        //Here is a nested switch statement for the inches value if it's clicked.
                        //we do the same twice more for feet and yards.
                        case 0:
                            convertedDistance.Text = enterBoxDistance.ToString();
                            //Keeping the note in mind that if the same value is clicked,
                            //we have to return the same value in the "converted distance" box.
                            break;
                        case 1:
                            convertedDistance.Text = (enterBoxDistance / 12).ToString();
                            //Converting feet from inches.
                            break;
                        case 2:
                            convertedDistance.Text = (enterBoxDistance / 36).ToString();
                            //converting yards from inches. Inches must first be transferred into feet.
                            //To make code more concise, just divide by 36, which is 12(inches in 1 foot) * 3(feet in 1 yard).
                            break;
                    }
                    break;

                //In this case, we are instead performing calculations as if we had clicked "Feet" in the
                //"From" box, instead of "Inches". Calculations shift slightly, but we perform more case testing here.
                //I could not find a suitable way to make these code blocks smaller through refactoring, but it seems
                //like an if statement is hinted at here. I just kept going at this point- 
                //Note to self that I was also reading more of the "Lazy Operator" discussion at this point. Wondering
                //if it can go anywhere in this code.
                case 1:
                    switch (toBoxDistance)
                    {
                        case 0:
                            //feet to inches here- Doing the list from top to bottom in cases.
                            convertedDistance.Text = (enterBoxDistance * 12).ToString();
                            break;
                        case 1:
                            //feet to feet here- No calculations required, to adhere with the notes previously.
                            convertedDistance.Text = enterBoxDistance.ToString();
                            break;
                        case 2:
                            //feet to yards here- no long-winded calculations needed. All simple.
                            convertedDistance.Text = (enterBoxDistance / 3).ToString();
                            break;
                    }
                    break;

                case 2:
                    //Our last case is the Yards being selected in the "From" conversion box. More case testing!
                    switch (toBoxDistance)
                    {
                        case 0:
                            //yards to inches- Instead of multiplying by 3(feet) and then 12(inches)
                            //we just cut out the middleman- multiply by 36.
                            convertedDistance.Text = (enterBoxDistance * 36).ToString();
                            break;
                        case 1:
                            //yards to feet - 3 feet in 1 yard.
                            convertedDistance.Text = (enterBoxDistance * 3).ToString();
                            break;
                        case 2:
                            //Note case in book- yards to yards == no operations (except there).
                            convertedDistance.Text = enterBoxDistance.ToString();
                            break;
                    }
                    break;
            }
        }
        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            //Easy part:
            //When the exit button is clicked, the program closes.
            this.Close();
        }
    }
}
