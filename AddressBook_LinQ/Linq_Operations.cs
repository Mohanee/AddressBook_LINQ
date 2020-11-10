using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace AddressBook_LinQ
{
    public class Linq_Operations
    {
        // Create Data table to store address book details
        public DataTable dataTable = new DataTable();

        /// <summary>
        /// Add columns to the created data table
        /// </summary>
        public void CreateAddressBook()
        {
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("Zipcode", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("EmailID", typeof(string));
        }

        /// <summary>
        /// Method to insert rows(contacts) into the table
        /// </summary>
        public void InsertValues()
        {
            ContactValidation cvalid = new ContactValidation();
            try
            {
                cvalid.CheckContactValidation("Trina", "Maity", "HaldiaComplex", "Haldia", "W.B.", "165301", "8983456534", "trinamaity@gmail.com");
                dataTable.Rows.Add("Trina", "Maity", "HaldiaComplex", "Haldia", "W.B.", "165301", "8983456534", "trinamaity@gmail.com");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                cvalid.CheckContactValidation("Bruce", "Banner", "Vandalia", "Dayton", "Florida", "454541", "7123425612", "hulkBuster@gmail.com");
                dataTable.Rows.Add("Bruce", "Banner", "Vandalia", "Dayton", "Florida", "454541", "7123425612", "hulkBuster@gmail.com");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                cvalid.CheckContactValidation("Sweta", "Verma", "Ranchi Estate", "Ranchi", "JHK", "123122", "9889710434", "vermasweta@yahoo.com");
                dataTable.Rows.Add("Sweta", "Verma", "Ranchi Estate", "Ranchi", "JHK", "123122", "9889710434", "vermasweta@yahoo.com");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                cvalid.CheckContactValidation("Sayantani", "Mondal", "IITKGP quaters", "Kharagpur", "WB", "100723", "7893264355", "smondal@gmail.com");
                dataTable.Rows.Add("Sayantani", "Mondal", "IITKGP quaters", "Kharagpur", "WB", "100723", "7893264355", "smondal@gmail.com");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                cvalid.CheckContactValidation("Riya", "Srivastav", "Lajpat Nagar", "Delhi", "Delhi", "780431", "9856964579", "riyasriv@yahoo.com");
                dataTable.Rows.Add("Riya", "Srivastav", "Lajpat Nagar", "Delhi", "Delhi", "780431", "9856964579", "riyasriv@yahoo.com");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                cvalid.CheckContactValidation("Tiasa", "Chakraborty", "RoyalPalace", "Kolkata", "W.B.", "223544", "7849876734", "chaktiasa@rediffmail.com");
                dataTable.Rows.Add("Tiasa", "Chakraborty", "RoyalPalace", "Kolkata", "W.B.", "223544", "7849876734", "chaktiasa@rediffmail.com");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                cvalid.CheckContactValidation("Natasha", "Barman", "Jalpaiguri Estate", "Jalpaiguri", "W.B.", "178028", "9866735277", "natsbarman@gmail.com");
                dataTable.Rows.Add("Natasha", "Barman", "Jalpaiguri Estate", "Jalpaiguri", "W.B.", "178028", "9866735277", "natsbarman@gmail.com");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                cvalid.CheckContactValidation("Priya", "Arya", "Sector1", "Bhilai", "C.G.", "490006", "8987224534", "arya7priya@gmail.com");
                dataTable.Rows.Add("Priya", "Arya", "Sector1", "Bhilai", "C.G.", "490006", "8987224534", "arya7priya@gmail.com");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                cvalid.CheckContactValidation("Ishika", "Mitra", "Farid Nagar", "Faridabad", "Delhi", "100112", "6767986886", "jarvis@gmail.com");
                dataTable.Rows.Add("Ishika", "Mitra", "Farid Nagar", "Faridabad", "Delhi", "100112", "6767986886", "jarvis@gmail.com");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                cvalid.CheckContactValidation("Alisha", "Sharma", "Sector8", "Bhilai", "C.G.", "178001", "9876543256", "sharmalaisha@yahoo.com");
                dataTable.Rows.Add("Alisha", "Sharma", "Sector8", "Bhilai", "C.G.", "178001", "9876543256", "sharmalaisha@yahoo.com");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Method to display all the contacts in the data table
        /// </summary>
        public void DisplayDataTable()
        {
            foreach (DataColumn col in dataTable.Columns)
            {
                Console.Write(col.ToString().PadRight(14));
            }
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine();
                foreach (DataColumn col in dataTable.Columns)
                {
                    Console.Write(row[col].ToString().PadRight(14));
                }
            }
        }
    }
}
