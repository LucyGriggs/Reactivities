using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Activity
    {
        //Table called Activity
        //Columns in the table
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Decription { get; set; }
        public string Catagory { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }

    }
}