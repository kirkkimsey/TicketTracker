using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ticket_Tracker.Models
{
    [Table("Severity")]
    public class Severity
    {
        public int ID { get; set; }
        public int Desription { get; set; }
    }
}