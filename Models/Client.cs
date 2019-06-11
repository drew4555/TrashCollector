using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Client
    {
       [Key]
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Credit_Card_Number { get; set; }
        public string Experation_date { get; set; }
        public int Three_digits_on_back { get; set; }
        public string Suspend_Service_Start { get; set; }
        public string Suspend_Service_End { get; set; }
        public string Collection_Day { get; set; }
        public string Extra_Pickup { get; set; }
        
        public int Current_Bill { get; set; }
        [ForeignKey("AppUser")]
        public string UserId { get; set; }
        public ApplicationUser AppUser { get; set; }
        
    }
}
