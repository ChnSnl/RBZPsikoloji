using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingProject.Entities.Models
{
    public class UserType : BaseEntity
    {
        public string TypeName { get; set; }

        //Relational Properties

        public virtual List<AppUser> AppUsers { get; set; }
    }
}
