using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingProject.Entities.Models
{
    public class Meeting : BaseEntity
    {
        public DateTime MeetingDate { get; set; }
        public float Hour { get; set; }
        public string Description { get; set; } //Randevu ile ilgili tutulan bilgi

        public string Note { get; set; } //seansta kullanıcı ile ilgili notlar
        public int? AppUserID { get; set; }


        //Relational Properties

        public virtual AppUser AppUser { get; set; }

    }
}
