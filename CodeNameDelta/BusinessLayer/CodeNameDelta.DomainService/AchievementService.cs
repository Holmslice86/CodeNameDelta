using CodeNameDelta.Domain;
using CodeNameDelta.Domain.Interfaces;
using CodeNameDelta.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeNameDelta.DomainService
{
    public class AchievementService : IAchievementService
    {
        public IEnumerable<Achievement> GetAchievements()
        {
            return new List<Achievement>() { new Achievement() { Id = 1, Name = "Achievement1" } } ;
        }

    }
}
