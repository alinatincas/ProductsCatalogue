using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Linq;

namespace CatalogueLibrary
{
    public class DbProvider
    {
        public static void SaveProducts(string path)
        {
            List<Product> products = new List<Product>();
            products.AddRange(new List<Product>
            {
                new Product("KitKat", "Nestlé", "United Kingdom", "Chocolate",
                "Kit Kat is a chocolate-covered wafer bar confection created by Rowntree's of York, United Kingdom, and is now produced globally by Nestlé, which acquired Rowntree in 1988,[1] with the exception of the United States where it is made under license by H.B. Reese Candy Company, a division of The Hershey Company. The standard bars consist of two or four fingers composed of three layers of wafer, separated and covered by an outer layer of chocolate. Each finger can be snapped from the bar separately. There are many different flavours of Kit Kat, including milk, white, and dark chocolate."),
                new Product("Snickers", "Mars", "United Kingdom", "Chocolate",
                "Snickers is a brand name chocolate bar made by the American company Mars, Incorporated previously known in the UK as 'Marathon' but changed in 1990. Consisting of nougat topped with caramel and peanuts, enrobed in milk chocolate, Snickers has annual global sales of $2 billion."),
                new Product("Gummy bears", "Hans Riegel", "Germany", "Jelly",
                "Gummy bears (German: Gummibär) are small, fruit gum candies, similar to a jelly baby in some English-speaking countries. The candy is roughly 2 cm (0.8 in) long and shaped in the form of a bear. The gummy bear is one of many gummies, popular gelatin-based candies sold in a variety of shapes and colors."),
                new Product("Bêtise de Cambrai", "Afchain", "France", "Wrapped_Candies",
                "Bêtises de Cambrai ([betiz də kɑ̃bʁɛ]) are a French boiled sweet made in the town of Cambrai. \"Bêtise\" is French for \"nonsense\" or \"stupid mistake\" and the sweets are said to have been invented by accident by the son of a confectioner named Afchain. The original flavour is mint, but many others are now produced. Stripes of caramel add sweetness."),
                new Product("Jolly Rancher", "The Hershey Company", "United States", "Wrapped_Candies",
                "Jolly Rancher is an American brand of sweet, somewhat tangy or sour/sweet hard candy, gummies, fruit chews, jelly beans, lollipops, gelatin desserts, gum, and sodas. It is currently owned by The Hershey Company. The product was originally produced by the Jolly Rancher Company, founded by Bill Harmsen of Golden, Colorado. The Jolly Rancher Company made ice cream, chocolate and candy sold at several \"Ranch Maid Ice Cream\" stores in the Denver area. The name was meant to suggest a hospitable, western company."),
                new Product("Red Vines", "American Licorice Company", "California", "Licorice",
                "Red Vines is a brand of red licorice candy manufactured in Union City, California by the American Licorice Company. Red Vines Original Red Twists are also sometimes referred to as red licorice despite containing no licorice. The original Red Vines were raspberry-flavored, but in 1952, with a slight formula change, the Red Vines Original Red Twist flavor was introduced."),
                new Product("Chupa Chups", "Enric Bernat", "Spain", "Lollypop",
                "Chupa Chups (Spanish pronunciation: Spanish: [ˈtʃupa ˈtʃups];) is a popular Spanish brand of lollipop and other confectionery sold in over 150 countries around the world. The brand was founded in 1958 by Enric Bernat, and is currently owned by the Italian-Dutch multinational corporation Perfetti Van Melle. The name of the brand comes from the Spanish verb chupar, meaning \"to suck\"."),
            });

            WriteJsonData(new List<object>(products), path);
        }

        public static List<Product> GetProducts(string path)
        {
            var jsonData = File.ReadAllText(path);
            var result = JsonConvert.DeserializeObject<List<Product>>(jsonData);
            return result;

        }

        public static void WriteJsonData(List<object> theList, string path)
        {
            var jsonData = JsonConvert.SerializeObject(theList, Formatting.Indented);
            File.WriteAllText(path, jsonData);
        }
    }
}
