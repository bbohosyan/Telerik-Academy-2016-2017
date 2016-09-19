using Dealership.Common;
using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Models
{
    class Motorcycle : Vehicle, IMotorcycle
    {
        private string category;

        public Motorcycle(string make, string model, decimal price, string category)
            : base(make, model, price)
        {
            this.Wheels = 2;
            this.Category = category;
        }

        public string Category
        {
            get
            {
                return this.category;
            }
            private set
            {
                Validator.ValidateNull(value, "Cannot be empty or null");
                if (value == string.Empty)
                {
                    throw new ArgumentException("Cannot be empty");
                }
                Validator.ValidateIntRange(value.Length, Constants.MinCategoryLength, Constants.MaxCategoryLength, "Category must be between 3 and 10 characters long!");
                this.category = value;
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Motorcycle:\n  Make: {0}\n  Model: {1}\n  Wheels: {2}\n  Price: ${3}\n  Category: {4}", this.Make, this.Model, this.Wheels, this.Price, this.Category));
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
