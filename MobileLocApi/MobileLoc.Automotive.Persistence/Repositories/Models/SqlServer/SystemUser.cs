using System;
using System.Collections.Generic;

namespace MobileLoc.Automotive.Persistence.Repositories.Models.SqlServer
{
    public partial class SystemUser
    {
        public SystemUser()
        {
            CarInsertByNavigation = new HashSet<Car>();
            CarUpdateByNavigation = new HashSet<Car>();
            InverseSystemUserParent = new HashSet<SystemUser>();
        }

        public int SystemUserId { get; set; }
        public string SystemUserName { get; set; }
        public string SystemUserType { get; set; }
        public int SystemUserParentId { get; set; }
        public bool? IsActive { get; set; }

        public virtual SystemUser SystemUserParent { get; set; }
        public virtual ICollection<Car> CarInsertByNavigation { get; set; }
        public virtual ICollection<Car> CarUpdateByNavigation { get; set; }
        public virtual ICollection<SystemUser> InverseSystemUserParent { get; set; }
    }
}