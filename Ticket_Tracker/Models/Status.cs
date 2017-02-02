using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ticket_Tracker.Models
{
    [Table("Status")]

    public class Status
    {
        public int ID { get; set; }
        public int Description { get; set; }
    }
}