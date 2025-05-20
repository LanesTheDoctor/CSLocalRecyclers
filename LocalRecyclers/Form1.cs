//Purpose
//	1.  Create a GUI Form application.
//	2.  Provide user-interaction supports such as buttons, textboxes, and comboboxes.
//	3.  Read recyclers data from external file "recyclers.csv" while running.
//	4.  Display recyclers data after being read when the app is launched, it must be in ascending alphabetical order by business name.
//	5.  Display the first record in text boxes.
//	6.  Navigate though recycler data entries.
//	7.  Search by name for a recycler using the binary search feature.

//  8.  Clear textbox fields when actioned.
//	9.  Add a recycler when actioned.
//	10. Update a recycler when actioned.
//	11. Delete a recycler when actioned.
//	12. Launch the default browser of the host device and open the recycler's website when actioned.
//	13. Save the modified data to the "reycyclers.csv" when actioned.
//	14. Display recycler data by recycled product.
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
namespace LocalRecyclers
{
    public partial class Form1 : Form
    {
        // RecyclerList instance containing List<Recycler>
        private List<Recycler> rList;

        // Index of current records.
        private int currentRecord;

        // Array of recycling services offered in the comboBox
        private string[] recycleProducts;

        /*
            Method name: Form1 Constructor
            Purpose: 1. Sets up GUI components.
                        2. Initialises private data.
                        3. Sets up recycler info in comboBoxes
                        4. Reads in external file data and sets up rList.
                        5. Sorts rList by recycler name.
            Inputs: N/A
            Output: N/A
        */
        public Form1()
        {
            InitializeComponent();

            // Set current record int.
            currentRecord = 0;

            // Assign string values of recycled products.
            recycleProducts = new string[] { "All Waste", "Electronic Waste", "Green Waste", "Hazardous Waste", "Household Waste", "Scrap Cars", "Scrap Metal", "Unwanted Items" };

            // Clear out any existing items in the filter comboBox and then add recycler data.
            filter_ComboBox.Items.Clear();
            filter_ComboBox.Items.AddRange(recycleProducts);

            // Instantiate the rList.
            rList = new List<Recycler>();

            // Read external data from CSV file.
            ReadData("recyclers.csv");

            // Test
            //if (rList.Count > 0)
            //{
            //        string displayStr = "List of recyclers:\n\n";
            //        for (int i = 0; i < rList.Count; i++)
            //        {
            //            displayStr += rList[i].ToString() + "\n\n";
            //        }

            //        MessageBox.Show(displayStr);
            //}

            // Display all recyclers read in from the CSV file.
            // Display the first record in the textboxes.
            if (rList.Count > 0)
            {
                DisplayRecyclersList();
                DisplayCurrentRecord();
            }

            // Error message in the event that there are either zero recyclers to display from the CSV file or there is an issue with the file.
            else
            {
                MessageBox.Show("There are no reycler records to display!");
            }
        }


        /*
            Method name: ReadData()
            Purpose: Reads external CSV data to set up recyclerList
            Inputs: string filePath
            Output: N/A
        */
        public void ReadData(string filePath)
        {
            // Read from external file (filePath
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader file = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = file.ReadLine()) != null)
                        {
                            string[] lineArray = line.Split(',');
                            if (lineArray.Length >= 5)
                            {
                                string name = lineArray[0];
                                string address = lineArray[1];
                                string phone = lineArray[2];
                                string website = lineArray[3];
                                string recycles = lineArray[4];

                                Recycler recycler = new Recycler(name, address, phone, website, recycles);
                                rList.Add(recycler);
                            }
                        }
                    }

                    // Close file.
                    //file.close;

                    // Sort recycler list alphabetically by name.
                    rList.Sort();
                }

                else
                {
                    MessageBox.Show("ERROR: No external file exists for: " + filePath, "!");
                }
            }

            catch (IOException ioe)
            {
                MessageBox.Show("Error: Problem reading in external file for: " + filePath + "!");
            }

            catch (Exception e)
            {
                MessageBox.Show("ERROR: Problem with external file: " + filePath + "\n" + e.Message);
            }
        }

        /*
           Method name: DisplayRecyclersList()
           Purpose: Displays full listing of name, phone, and website url for each recycler.
           Inputs: N/A
           Output: N/A
        */
        private void DisplayRecyclersList()
        {
            string displayStr = "Name\t\t\tPhone\t\tWeb Site\r\n";
            displayStr += "----------------------------------------------------------------\r\n";
            for (int i = 0; i < rList.Count; i++)
            {
                displayStr += rList[i].ToString() + "\r\n";
            }

            recyclerListing_TextBox.Text = displayStr;
        }

        /*
           Method name: DisplayRecyclersList()
           Purpose: Displays full listing of name, phone, and website url for each recycler.
           Inputs: string filterStr
           Output: N/A
        */
        private void DisplayRecyclersList(string filterStr)
        {
            string displayStr = "Name\t\t\tPhone\t\tWeb Site\r\n";
            displayStr += "----------------------------------------------------------------\r\n";
            for (int i = 0; i < rList.Count; i++)
            {
                if (rList[i].Recycles.Contains(filterStr))
                {
                    displayStr += rList[i].ToString() + "\r\n";
                }
            }

            recyclerListing_TextBox.Text = displayStr;
        }

        /*
           Method name: DisplayCurrentRecord()
           Purpose: Displays a single record for a recycler from the rList object. An entry for a recycler will be selected by the navigation buttons.
           Inputs: N/A
           Output: N/A
        */
        private void DisplayCurrentRecord()
        {
            name_TextBox.Text = rList[currentRecord].Name;
            address_TextBox.Text = rList[currentRecord].Address;
            phone_TextBox.Text = rList[currentRecord].Phone;
            website_TextBox.Text = rList[currentRecord].Website;
            recycles_TextBox.Text = rList[currentRecord].Recycles;
        }

        /*
           Method name: filter_ComboBox_SelectedIndexChanged()
           Purpose: When an item is selected, it will be reflected in recyclerListing_TextBox via this method.
           Inputs: EventArgs e (Event generated data)
           Output: N/A
        */
        private void filter_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filterStr = filter_ComboBox.SelectedItem.ToString();
            if (filterStr.Equals("All Waste"))
            {
                DisplayRecyclersList();
            }

            else
            {
                DisplayRecyclersList(filterStr);
            }
        }

        /*
           Method name: search_Button_Click()
           Purpose: This method is called when the search button is clicked. It:
                    1. Checks if search_TextBox is empty.
                    2. If it isn't empty, it will run a binary search for the name in the List. NOTE: Binary searches only work when the list is sorted by name.
                    3. If a record is found, a full record will be displayed in the textboxes.
           Inputs: EventArgs e (Event generated data)
           Output: N/A
        */
        private void search_Button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(search_TextBox.Text))
            {
                MessageBox.Show("ERROR: Name is required for the search!");
            }

            else
            {
                string nameToSearch = search_TextBox.Text;
                int foundIndex = BinarySearch(nameToSearch);
                if (foundIndex < 0)
                {
                    MessageBox.Show("No record foundfor " + nameToSearch + "!");
                }

                else
                {
                    currentRecord = foundIndex;
                    MessageBox.Show("Record found for " + nameToSearch + " at index " + currentRecord + "!");
                    DisplayCurrentRecord();
                }
            }
        }

        /*
           Method name: BinarySearch()
           Purpose: Searches for a recycler's name in the rList object and returns a -1 if it's not found, index postion (0 -> n-1) if it is found.
                    The binary search technique is usd but it does require a sortted list, it will be sorted alphabetically by the recycler's name.
           Inputs: string searchName
           Output: int foundIndex
        */
        public int BinarySearch(string searchName)
        {
            int foundIndex = -1;
            int firstIndex = 0;
            int lastIndex = rList.Count - 1;

            while (firstIndex <= lastIndex)
            {
                int midIndex = (firstIndex + lastIndex) / 2;
                string nameToCompare = rList[midIndex].Name;
                if (nameToCompare.CompareTo(searchName) == 0)
                {
                    foundIndex = midIndex;
                    break;
                }

                else if (nameToCompare.CompareTo(searchName) > 0)
                {
                    lastIndex = midIndex - 1;
                }

                else
                {
                    firstIndex = midIndex + 1;
                }
            }

            return foundIndex;
        }

        /*
           Method name: IsRecyclerValidk()
           Purpose: Validates recycler record entries to ensure all necessary data is provided.
           Inputs: Strings via textfields.
           Output: N/A
        */
        private bool IsRecyclerValid()
        {
            bool isValid = true;
            string errorMessage = "ERROR(S) encountered:\n";

            // 1. Check name
            if (string.IsNullOrWhiteSpace(name_TextBox.Text))
            {
                errorMessage += "• Business Name is required.\n";
                isValid = false;
            }

            // 2. Check address
            if (string.IsNullOrWhiteSpace(address_TextBox.Text))
            {
                errorMessage += "• Address is required.\n";
                isValid = false;
            }

            // 3. Check phone
            if (string.IsNullOrWhiteSpace(phone_TextBox.Text))
            {
                errorMessage += "• Phone number is required.\n";
                isValid = false;
            }

            // 4. Check website
            if (string.IsNullOrWhiteSpace(website_TextBox.Text))
            {
                errorMessage += "• Website URL is required.\n";
                isValid = false;
            }

            // 5. Check recycle products
            if (string.IsNullOrWhiteSpace(recycles_TextBox.Text))
            {
                errorMessage += "• Recycled product type(s) are required.\n";
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Validation Error");
            }

            return isValid;
        }

        /*
           Method name: clear_Button_Click()
           Purpose: When clicked all text fields on the upperLeft_Panel will be cleared.
           Inputs: EventArgs e (Event generated data
           Output: N/A
        */
        private void clear_Button_Click(object sender, EventArgs e)
        {
            name_TextBox.Text = "";
            address_TextBox.Text = "";
            phone_TextBox.Text = "";
            website_TextBox.Text = "";
            recycles_TextBox.Text = "";
        }

        /*
           Method name: addNew_Button_MouseClick()
           Purpose: When clicked data from all text fields on the upperLeft_Panel will be added to the recyclers.csv file.
           Inputs: EventArgs e (Event generated data
           Output: N/A
        */
        private void addNew_Button_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsRecyclerValid()) return;

            DialogResult confirm = MessageBox.Show(
                "Do you want to add this new recycler?",
                "Confirm Addition",
                MessageBoxButtons.YesNo
            );

            if (confirm == DialogResult.No) return;

            string name = name_TextBox.Text;
            string address = address_TextBox.Text;
            string phone = phone_TextBox.Text;
            string website = website_TextBox.Text;
            string recycles = recycles_TextBox.Text;

            Recycler recycler = new Recycler(name, address, phone, website, recycles);
            rList.Add(recycler);
            rList.Sort();

            DisplayRecyclersList();
            currentRecord = rList.IndexOf(recycler);
            DisplayCurrentRecord();
        }

        /*
           Method name: update_Button_MouseClick()
           Purpose: When clicked data from all text fields on the upperLeft_Panel will be added to the recyclers.csv file and will overrite the data for the selected entry.
           Inputs: EventArgs e (Event generated data
           Output: N/A
        */
        private void update_Button_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsRecyclerValid()) return;

            string originalFName = rList[currentRecord].Name;

            DialogResult confirm = MessageBox.Show
            (
                $"Do you want to update the record for \"{originalFName}\"?",
                "Confirm Update",
                MessageBoxButtons.YesNo
            );

            if (confirm == DialogResult.No) return;

            rList[currentRecord].Name = name_TextBox.Text;
            rList[currentRecord].Address = address_TextBox.Text;
            rList[currentRecord].Phone = phone_TextBox.Text;
            rList[currentRecord].Website = website_TextBox.Text;
            rList[currentRecord].Recycles = recycles_TextBox.Text;

            rList.Sort();
            DisplayRecyclersList();

            currentRecord = rList.FindIndex(r => r.Name == name_TextBox.Text);
            DisplayCurrentRecord();
        }

        /*
           Method name: delete_Button_Click()
           Purpose: When clicked all data from the entry will be permanently removed.
           Inputs: EventArgs e (Event generated data
           Output: N/A
        */
        private void delete_Button_Click(object sender, EventArgs e)
        {
            if (rList.Count == 0)
            {
                MessageBox.Show("No recyclers to delete.", "Delete Failed");
                return;
            }

            string nameToDelete = rList[currentRecord].Name;

            DialogResult confirm = MessageBox.Show
            (
                $"Are you sure you want to delete the record for \"{nameToDelete}\"?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo
            );

            if (confirm == DialogResult.No) return;

            rList.RemoveAt(currentRecord);

            if (rList.Count == 0)
            {
                currentRecord = 0;
                recyclerListing_TextBox.Clear();
                name_TextBox.Clear();
                address_TextBox.Clear();
                phone_TextBox.Clear();
                website_TextBox.Clear();
                recycles_TextBox.Clear();

                MessageBox.Show("Recycler deleted. No more entries remaining.");
                return;
            }

            if (currentRecord >= rList.Count)
            {
                currentRecord = rList.Count - 1;
            }

            DisplayRecyclersList();
            DisplayCurrentRecord();
        }

        /*
           Method name: exit_Button_Click()
           Purpose: Closes the progam when clicked.
           Inputs: EventArgs e (Event generated data
           Output: N/A
        */
        private void exit_Button_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show
            (
               "Are you sure you want to exit the application?",
               "Exit Confirmation",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void firstLine_Button_Click(object sender, EventArgs e)
        {
            // Go to the first entry.
            currentRecord = 0;

            // Display the first entry.
            DisplayCurrentRecord();
        }

        private void prev_Button_Click(object sender, EventArgs e)
        {
            // Go to the previous entry.
            currentRecord--;

            if (currentRecord < 0)
            {
                currentRecord = rList.Count - 1;
            }

            // Display the previous entry.
            DisplayCurrentRecord();
        }

        private void next_Button_Click(object sender, EventArgs e)
        {
            // Go to the next entry.
            currentRecord++;

            if (currentRecord == rList.Count)
            {
                currentRecord = 0;
            }

            // Display the next entry.
            DisplayCurrentRecord();
        }

        private void lastLine_Button_Click(object sender, EventArgs e)
        {
            // Go to the last entry.
            currentRecord = rList.Count - 1;

            // Display the last entry.
            DisplayCurrentRecord();
        }

        /*
            Method name: url_Button_MouseClick()
            Purpose: When clicked will direct you to the website of the recycler.
            Inputs: EventArgs e (Event generated data
            Output: N/A
        */
        private void url_Button_MouseClick(object sender, MouseEventArgs e)
        {
            string url = website_TextBox.Text;

            try
            {
                if (!url.StartsWith("http", StringComparison.OrdinalIgnoreCase))
                {
                    url = "https://" + url;
                }

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unable to open URL:\n" + ex.Message, "ERROR!");
            }
        }
    }
}