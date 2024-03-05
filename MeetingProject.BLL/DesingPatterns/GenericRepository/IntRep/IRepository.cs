using MeetingProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingProject.BLL.DesingPatterns.GenericRepository.IntRep
{
    public interface IRepository<T> where T : BaseEntity
    {

    }
}
