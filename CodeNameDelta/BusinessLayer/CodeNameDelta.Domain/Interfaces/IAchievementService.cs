using CodeNameDelta.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeNameDelta.Domain.Interfaces
{
    public interface IAchievementService
    {
        IEnumerable<Achievement> GetAchievements();

    }
}
