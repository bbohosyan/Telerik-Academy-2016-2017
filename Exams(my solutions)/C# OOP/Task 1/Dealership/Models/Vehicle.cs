using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common.Enums;
using Dealership.Common;

namespace Dealership.Models
{
    class Vehicle : IVehicle, ICommentable, IPriceable
    {
        private string make;
        private string model;
        private decimal price;
        private IList<IComment> comments;
        private VehicleType type;
        private int wheels;

        public Vehicle (string make, string model, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.Wheels = wheels;
            this.Comments = new List<IComment>();
        }

        public IList<IComment> Comments
        {
            get
            {
                return this.comments;
            }
            private set
            {
                Validator.ValidateNull(value, "Cannot be empty or null");
                this.comments = value;
            }
        }

        public string Make
        {
            get
            {
                return this.make;
            }
            private set
            {
                Validator.ValidateNull(value, "Cannot be empty or null");
                if (value == string.Empty)
                {
                    throw new ArgumentException("Cannot be empty");
                }
                Validator.ValidateIntRange(value.Length, Constants.MinMakeLength, Constants.MaxMakeLength, "Make must be between 2 and 15 characters long!");
                this.make = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                Validator.ValidateNull(value, "Cannot be empty or null");
                if (value == string.Empty)
                {
                    throw new ArgumentException("Cannot be empty");
                }
                this.model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                Validator.ValidateNull(value, "Cannot be empty or null");
                Validator.ValidateDecimalRange(value, Constants.MinPrice, Constants.MaxPrice, "Price must be between 0.0 and 1000000.0!");
                this.price = value;
            }
        }

        public VehicleType Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                Validator.ValidateNull(value, "Cannot be empty or null");
                this.type = value;
            }
        }

        public int Wheels
        {
            get
            {
                return this.wheels;
            }
            protected set
            {
                Validator.ValidateNull(value, "Cannot be empty or null");
                this.wheels = value;
            }
        }

        //public override string ToString()
        //{
        //    return "aaa";
        //}
    }
}
