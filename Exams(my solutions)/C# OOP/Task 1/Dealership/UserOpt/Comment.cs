using Dealership.Common;
using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.UserOpt
{
    class Comment : IComment
    {
        private string content;
        private string author;

        public Comment(string content)
        {
            this.Content = content;
        }

        public string Author
        {
            get
            {
                return this.author;
            }

            set
            {
                Validator.ValidateNull(value, "Cannot be empty or null");
                if (value == string.Empty)
                {
                    throw new ArgumentException("Cannot be empty");
                }
                this.author = value;
            }
        }

        public string Content
        {
            get
            {
                return this.content;
            }
            private set
            {
                Validator.ValidateNull(value, "Cannot be empty or null");
                if (value == string.Empty)
                {
                    throw new ArgumentException("Cannot be empty");
                }
                Validator.ValidateIntRange(value.Length, Constants.MinCommentLength, Constants.MaxCommentLength, "Content must be between 3 and 200 characters long!");
                this.content = value;
            }
        }
    }
}
