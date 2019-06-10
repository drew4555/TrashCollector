using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class ClientViewModel
    {
        public Client Client { get; set; }
        public DaysofWeek DaysOfWeek { get; set; }
        public Address Address { get; set; }
    }
}