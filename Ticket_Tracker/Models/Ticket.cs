using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ticket_Tracker.Models
{
    [Table("Tickets")]
    public class Ticket
    {
        //PrimaryKEy
        public int ID { get; set; }
        public int Subject { get; set; }
        public int Description { get; set; }
        //ForeignKey for table called severity
        public int Severity { get; set; }
        //fk on table called user
        public int AssignedTo{ get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastModified { get; set; }
        // fk on table called status
        public int Status { get; set; }

        [ForeignKey("AssignedTo")]
        public virtual User AssignedToUser { get; set; }

        [ForeignKey("CreatedBy")]
        public virtual User CreatedByUser { get; set; }

        [ForeignKey("Severity")]
        public virtual Severity SeverityDescription { get; set; }

        [ForeignKey("Status")]
        public virtual Status TicketStatus { get; set; }

    }
}