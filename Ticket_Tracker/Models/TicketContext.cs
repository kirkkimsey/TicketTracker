using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ticket_Tracker.Models
{
    public class TicketContext : DbContext
    {
        public virtual DbSet<Severity> Severity { get; set; }
        public virtual DbSet<User> User  { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public TicketContext() : base("TicketContext")
        {
    }
}