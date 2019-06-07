using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class DaysofWeek
    {
        [Key]
        public int Id { get; set; }
        public string Day { get; set; }
        
        [ForeignKey("Clients")]
        public int CustomerId { get; set; }
        public Client Clients { get; set; }
    }
}