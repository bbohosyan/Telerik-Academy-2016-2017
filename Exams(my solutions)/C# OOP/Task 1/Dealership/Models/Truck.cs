using Dealership.Common;
using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Models
{
    class Truck : Vehicle, ITruck
    {
        private int weightCapacity;

        public Truck(string make, string model, decimal price, int weightCapacity) : 
            base(make, model, price)
        {
            this.Wheels = 8;
            this.WeightCapacity = weightCapacity;
        }

        public int WeightCapacity
        {
            get
            {
                return this.weightCapacity;
            }
            private set
            {
                Validator.ValidateNull(value, "Cannot be empty or null");
                Validator.ValidateIntRange(value, Constants.MinCapacity, Constants.MaxCapacity, "Weight capacity must be between 1 and 100!");
                this.weightCapacity = value;
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Truck:\n  Make: {0}\n  Model: {1}\n  Wheels: {2}\n  Price: ${3}\n  Weight Capacity: {4}t", this.Make, this.Model, this.Wheels, this.Price, this.WeightCapacity));
            if (Comments.Count > 0)
            {
                result.AppendLine("    " + "--COMMENTS--");
                result.AppendLine("    " + "----------");
                for (int i = 0; i < Comments.Count - 1; i++)
                {
                    result.AppendLine("    " + Comments[i].Content);
                    result.AppendLine("      User: " + this.Comments[i].Author);
                    result.AppendLine("    " + "----------");
                    result.AppendLine("    " + "----------");

                }
                result.AppendLine("    " + Comments[Comments.Count - 1].Content);
                result.AppendLine("      User: " + this.Comments[Comments.Count - 1].Author);
                result.AppendLine("    " + "----------");
                result.AppendLine("    " + "--COMMENTS--");

            }
            else
            {
                result.AppendLine("    --NO COMMENTS--");
            }
            return result.ToString().TrimEnd();
        }
    }
}
