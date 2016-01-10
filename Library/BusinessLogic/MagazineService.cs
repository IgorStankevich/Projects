using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BusinessLogic
{
    public class MagazineService
    {
        public static List<Magazine> _magazines = new List<Magazine>();
        public static Magazine _magazine = new Magazine();

        public static void AddMagazine(Magazine magazine)
        {
            _magazines.Add(magazine);
        }
        public static DataTable GetMagazinesTable(List<Magazine> magazines)
        {
            DataTable dataTable = new DataTable("Magazines");
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Author", typeof(string));
            dataTable.Columns.Add("Publisher", typeof(string));
            dataTable.Columns.Add("Date of Publishing", typeof(int));
            dataTable.Columns.Add("Periodicity", typeof(int));
            foreach (var magazine in magazines)
            {
                dataTable.Rows.Add(magazine.Name, magazine.Author, magazine.Publisher, magazine.DatePublishing, magazine.Periodicity);
            }
            return dataTable;
        }
    }
}
