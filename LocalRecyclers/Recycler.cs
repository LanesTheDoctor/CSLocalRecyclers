using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalRecyclers
{
    /// <summary>
    /// Recycler class
    /// Purpose: Provide class template for recycler data from external .csv file.
    /// Author: Zac Makkinga
    /// Date: 21/05/2025
    /// </summary>
    internal class Recycler : IComparable<Recycler>
    {
        // Public properties, get and set methods.
        /// <summary>
        /// Public property - Name (name of the recycler).
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Public property - Address (address of the recycler).
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Pulic property Phone (phone of the recycler).
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Public property Website (website of the recycler).
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// Public property Recycles (listing what services are provided by the recycler).
        /// </summary>
        public string Recycles { get; set; }

        /*
        Method name: Recycler Constructor
        Purpose: Creates a new reycler instance.
        Inputs: - string Name
                - string Address
                - string Phone
                - string Website
                - String Recycles
        Output: N/A
        */
        /// <summary>
        /// Constructor Method
        /// </summary>
        /// <param name="name">Name of recycler.</param>
        /// <param name="address">Address of recycler.</param>
        /// <param name="phone">Phone number of recycler.</param>
        /// <param name="website">Website of recycler.</param>
        /// <param name="recycles">Services offered by the recycler.</param>
        public Recycler(string name, string address, string phone, string website, string recycles)
        {
            Name = name;
            Address = address;
            Phone = phone;
            Website = website;
            Recycles = recycles;
        }

        /*
        Method name: ToString()
        Purpose: Overrides a method of the object class. 
        Inputs: N/A
        Output: Returns string inputs:
                - Name string
                - Address string
                - Phone string
                - Website string
                - Recycles string
        */
        /// <summary>
        /// Returns a tab-separated string representation of the Recycler,
        /// including the name, phone number, and website.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name + "\t" + Phone + "\t" + Website;
        }

        /*
           Method name: ToCSVString()
           Purpose: Returns a customised CSV format string of:
                    - Name
                    - Address
                    - Phone
                    - Website
                    - Recycles
           Inputs: N/A
           Output: Returns CSV string of inputs:
                   - Name string
                   - Address string
                   - Phone string
                   - Website string
                   - Recycles string
         */
        /// <summary>
        /// Converts the Recycler object to a comma-separated value (CSV) string
        /// containing Name, Address, Phone, Website, and Recycles.
        /// </summary>
        /// <returns></returns>
        public string ToCSVString()
        {
            return Name + "," + Address + "," + Phone + "," + Website + "," + Recycles;
        }

        /*
           Method name: CompareTo()
           Purpose: Compares the name of the Reycler instance with the name of another recycler instance. It is an implemented method from the IComparable interface. 
           Inputs: Recycler object
           Output: int
                   - Returns 0 if both names are the same.
                   - Returns -1 if the instance name isalpahetically less than obj.Name.
                   - Returns 1 if the instance name is alphabetically greater than obj.Name.
         */
        /// <summary>
        /// Compares this Recycler's name with another Recycler's name
        /// to determine their alphabetical order.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(Recycler obj)
        {
            return Name.CompareTo(obj.Name);
        }
    }
}
