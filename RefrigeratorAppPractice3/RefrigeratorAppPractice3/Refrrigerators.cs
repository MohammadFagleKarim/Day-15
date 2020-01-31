using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    public class Refrrigerators
    {
        public double MaxWeight { set; get; }

        public List<int> items = new List<int>();
        public List<double> unitWeights = new List<double>();

        public void Add(int itemNo, double unitWeight)
        {
            items.Add(itemNo);
            unitWeights.Add(unitWeight);
        }

        public double CurrentWeight()
        {
            double currentWeight=0;
            for (int i=0; i<items.Count(); i++)
            {
                currentWeight +=( items[i] * unitWeights[i]);
            }
            return currentWeight;
        }

        public double RemainingWeight()
        {
            double currentWeight = CurrentWeight();
            double remainingWeight = MaxWeight - currentWeight;
            return remainingWeight;
        }

        public void Validate()
        {
            if (CurrentWeight() > MaxWeight)
            {
                
            }
        }

        //public double Weight(int item, double unitWeight)
        //{
        //    currentWeight = Convert.ToDouble(item) * unitWeight;

        //    return currentWeight;
        //}
    }
}
