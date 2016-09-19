using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common.Enums;
using Dealership.Common;

namespace Dealership.UserOpt
{
    class User : IUser/*, ICommentable*/
    {
        private string firstName;
        private string lastName;
        private string password;
        private Role role;
        private string username;
        private IList<IVehicle> vehicles;
        //private IList<IComment> comments;

        public User(string username, string firstName, string lastName, string password, string role)
        {
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.vehicles = new List<IVehicle>();
            //this.comments = new List<IComment>();
            if (role == "Normal")
            {
                this.Role = Role.Normal;
            }
            else if (role == "VIP")
            {
                this.Role = Role.VIP;
            }
            else if (role == "Admin")
            {
                this.Role = Role.Admin;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                Validator.ValidateNull(value, "Cannot be empty or null");
                if (value == string.Empty)
                {
                    throw new ArgumentException("Cannot be empty");
                }
                Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength, "Firstname must be between 2 and 20 characters long!");
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                Validator.ValidateNull(value, "Cannot be empty or null");
                if (value == string.Empty)
                {
                    throw new ArgumentException("Cannot be empty");
                }
                Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength, "Lastname must be between 2 and 20 characters long!");
                this.lastName = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            private set
            {
                Validator.ValidateNull(value, "Cannot be empty or null");
                if (value == string.Empty)
                {
                    throw new ArgumentException("Cannot be empty");
                }
                Validator.ValidateIntRange(value.Length, Constants.MinPasswordLength, Constants.MaxPasswordLength, "Password must be between 5 and 30 characters long!");
                this.password = value;
            }
        }

        public Role Role
        {
            get
            {
                return this.role;
            }
            private set
            {
                Validator.ValidateNull(value, "Cannot be empty or null");
                this.role = value;
            }
        }

        public string Username
        {
            get
            {
                return this.username;
            }
            private set
            {
                Validator.ValidateNull(value, "Cannot be empty or null");
                if (value == string.Empty)
                {
                    throw new ArgumentException("Cannot be empty");
                }
                Validator.ValidateSymbols(value, Constants.UsernamePattern, "Username contains invalid symbols!");
                Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength, "Username must be between 2 and 20 characters long!");
                this.username = value;
            }
        }

        public IList<IVehicle> Vehicles
        {
            get
            {
                return this.vehicles;
            }
            private set
            {
                Validator.ValidateNull(value, "Cannot be empty or null");
                this.vehicles = value;
            }
        }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {

            vehicleToAddComment.Comments.Add(commentToAdd);
        }

        public void AddVehicle(IVehicle vehicle)
        {
            if (this.Role == Role.VIP)
            {
                this.vehicles.Add(vehicle);
            }
            else if (this.Role == Role.Admin)
            {
                throw new ArgumentException(Constants.AdminCannotAddVehicles);
            }
            else
            {
                Validator.ValidateIntRange(vehicles.Count, -100, 4, string.Format(Constants.NotAnVipUserVehiclesAdd, 5.ToString()));
                this.vehicles.Add(vehicle);

            }
        }

        public string PrintVehicles()
        {
            int numVehicle = 1;
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("--USER {0}--", this.Username));
            if (vehicles.Count > 0)
            {
                for (int i = 0; i < vehicles.Count; i++)
                {
                    result.AppendLine(numVehicle.ToString() + ". " + vehicles[i].ToString());
                    numVehicle++;
                }
            }
            else
            {
                result.AppendLine("--NO VEHICLES--");
            }
            return result.ToString().TrimEnd();
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            if (commentToRemove.Author == this.Username)
            {
                vehicleToRemoveComment.Comments.Remove(commentToRemove);
            }
            else
            {
                throw new ArgumentException(Constants.YouAreNotTheAuthor);
            }
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            this.vehicles.Remove(vehicle);
        }
        public override string ToString()
        {
            return string.Format("Username: {0}, FullName: {1} {2}, Role: {3}",this.Username, this.FirstName, this.LastName, this.Role);
        }
    }
}
