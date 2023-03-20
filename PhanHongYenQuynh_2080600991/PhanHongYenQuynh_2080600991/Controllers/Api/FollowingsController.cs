using Microsoft.AspNet.Identity;
using PhanHongYenQuynh_2080600991.DTOs;
using PhanHongYenQuynh_2080600991.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PhanHongYenQuynh_2080600991.Controllers
{
    public class FollowingsController : ApiController
    {
        private readonly ApplicationDbContext _dbContext;
        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Follow(FollowingDto followingDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == followingDto.FolloweeId))
                return BadRequest("Following already exists!");
            var folowing = new Following
            {
                FollowerId= userId,
                FolloweeId= followingDto.FolloweeId,
            };

            _dbContext.Followings.Add(folowing);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
