using CodeNameDelta.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CodeNameDelta.Service.Controllers
{
    public class AchievementController : ApiController
    {
        private IAchievementService _achievementService;
        public AchievementController(IAchievementService achievementService)
        {
            _achievementService = achievementService;
        }
        // GET: api/Achievement
        public IHttpActionResult Get()
        {
            return Ok(_achievementService.GetAchievements());
        }

        // GET: api/Achievement/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Achievement
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Achievement/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Achievement/5
        public void Delete(int id)
        {
        }
    }
}
