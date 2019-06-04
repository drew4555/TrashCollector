using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Address { get; set; }
        public string Address_Line_2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public double Zip_Code { get; set; }
        public double Payment_Info { get; set; }
        public string Collection_Day { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
        public string Extra_Pickup { get; set; }
    }
}
