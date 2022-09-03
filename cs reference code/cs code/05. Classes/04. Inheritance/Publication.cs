using System;

namespace Inheritance
{
    class Publication
    {
        private string _name;

        public Publication(string name, int pagecount, decimal price) {
           _name = name;
           PageCount = pagecount;
           Price = price;
        }

        // The PageCount property has no backing field
        public int PageCount {
            get; set;
        }

        public decimal Price {
            get; set;
        }

        public string Name {
            // return the name
            get { return _name; }
            
            // use the setter to validate the new property value
            set {
                if (value == "") {
                    throw new ArgumentException("Name cannot be blank");
                }
                _name = value;
            }
        }

        // use the "virtual" keyword to indicate that a method
        // can be overridden by subclasses to customize behavior
        public virtual string GetDescription() {
            return $"{Name}, {PageCount} pages";
        }
    }
}