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
    }
}
