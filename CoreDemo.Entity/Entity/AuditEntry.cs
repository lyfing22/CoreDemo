using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDemo.Entity.Entity
{
    public class AuditEntry
    {
        public int AuditEntryId { get; set; }
        public string Username { get; set; }
        public string Action { get; set; }
    }
}
