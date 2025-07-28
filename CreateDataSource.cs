using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._1._1
{
    public static class CreateDataSource
    {
        public static Dictionary<string, Person> CreateSampleDictionary()
        {

            Dictionary<string, Person> addressBook = new Dictionary<string, Person>();
            addressBook.Add("MikeMasters", new Person() { FirstName = "Mike", LastName = "Masters", MobileNumber = "800-200-1000", WorkNumber = "800-100-4000", Address = "Big City, TN" });
            addressBook.Add("SusanSmith", new Person() { FirstName = "Susan", LastName = "Smith", MobileNumber = "800-300-2000", WorkNumber = "800-400-1000", Address = "Small City, AL" });
            addressBook.Add("EricErickson", new Person() { FirstName = "Eric", LastName = "Erickson", MobileNumber = "800-400-3000", WorkNumber = "800-200-9000", Address = "Lake City, MS" });
            return addressBook;
        }
    }
}
