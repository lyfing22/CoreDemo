using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDemo.Entity.Entity
{
  public   class UserRoleRelation
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long RoleId { get; set; }
        public User User { get; set; }
        public UserRole Role { get; set; }

    }
}
