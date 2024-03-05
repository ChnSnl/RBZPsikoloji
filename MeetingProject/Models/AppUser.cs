using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingProject.Entities.Models
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }

        public string Mail { get; set; }
        public string Password { get; set; }

        //Relational Properties

        public virtual AppUserProfile Profile { get; set; }
        public virtual List<Meeting> Meetings { get; set; }
        public virtual UserType UserType { get; set; }

    }
}
