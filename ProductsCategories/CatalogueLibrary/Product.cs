using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueLibrary
{
    public class Product
    {
        public String Name
        {
            get;
            set;
        }
        public String Manufacturer
        {
            get;
            set;
        }
        public String Country
        {
            get;
            set;
        }
        public String Category
        {
            get;
            set;
        }
        public String Description
        {
            get;
            set;
        }

        //constructor
        public Product(String name, String manufacturer, String country, String category, String description)
        {
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.Country = country;
            this.Category = category;
            this.Description = description;
        }
    }
}
