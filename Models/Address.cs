using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Address1{ get; set; }
        public string Address_Line_2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public double Zip_Code { get; set; }
        [ForeignKey("ApplicationUser")]
        public int FKId { get; set; }
        public ApplicationUser applicationUser { get; set; }
    }
}