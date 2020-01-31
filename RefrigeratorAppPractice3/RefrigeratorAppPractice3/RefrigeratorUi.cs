using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        public int t;

        public RefrigeratorUi()
        {
            t = 0;
            InitializeComponent();
        }

        Refrrigerators refrrigerators = new Refrrigerators();
        //List<double> speed = new List<double>();

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(maxWeightTakeTextBox.Text))
            {
                MessageBox.Show("Maximun Speed cannot be empty!");
                return;
            }

            refrrigerators.MaxWeight = Convert.ToDouble(maxWeightTakeTextBox.Text);

            t++;

            maxWeightTakeTextBox.Clear();

            //if (t>=1)
            //{
            //    refrigerator.MaxWeight = Convert.ToDouble(maxWeightTakeTextBox.Text);
            //    maxWeightTakeTextBox.Clear();
            //    t--;
            //    MessageBox.Show("Saved");
            //}
            //else
            //{
            //    MessageBox.Show("Maximum Wight can take once only");
            //}
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (t >= 1)
            {
                if (String.IsNullOrEmpty(itemTextBox.Text))
                {
                    MessageBox.Show("Items No. cannot be empty!");
                    return;
                }

                if (String.IsNullOrEmpty(weightTextBox.Text))
                {
                    MessageBox.Show("Unit Weight cannot be empty!");
                    return;
                }

                refrrigerators.Add(Convert.ToInt32(itemTextBox.Text), Convert.ToDouble(weightTextBox.Text));
                
                currentWeightTextBox.Text = refrrigerators.CurrentWeight().ToString();
                remainingWeightTextBox.Text = refrrigerators.RemainingWeight().ToString();
            }
            else
                MessageBox.Show("Create a refrigerator first");
            

            //int noOfitems = Convert.ToInt32(itemTextBox.Text);
            //double unitWeight = Convert.ToDouble(weightTextBox.Text);
            //refrigerator.Weight(noOfitems, unitWeight);
            //refrigerator.remainingWeight = refrigerator.MaxWeight - refrigerator.currentWeight;
            //currentWeightTextBox.Text = refrigerator.currentWeight.ToString();
            //remainingWeightTextBox.Text = refrigerator.remainingWeight.ToString();
            //currentWeightTextBox.ReadOnly = true;
            //remainingWeightTextBox.ReadOnly = true;

        }
    }
}
