using Dealership.Common;
using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Models
{
    class Car : Vehicle, ICar
    {
        private int seats;

        public Car(string make, string model, decimal price, int seats)
            : base (make, model, price)
        {
            this.Wheels = 4;
            this.Seats = seats;
        }

        public int Seats
        {
            get
            {
                return this.seats;
            }
            private set
            {
                Validator.ValidateNull(value, "Cannot be empty or null");
                Validator.ValidateIntRange(value, Constants.MinSeats, Constants.MaxSeats, "Seats must be between 1 and 10!");
                this.seats = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Car:\n  Make: {0}\n  Model: {1}\n  Wheels: {2}\n  Price: ${3}\n  Seats: {4}", this.Make, this.Model, this.Wheels, this.Price, this.Seats));
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
