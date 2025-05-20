using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalRecyclers
{
    internal class Recycler : IComparable<Recycler>
    {
        // Public properties, get and set methods.
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
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
        public int CompareTo(Recycler obj)
        {
            return Name.CompareTo(obj.Name);
        }
    }
}
