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
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbcontext;
        
        public AttendancesController()
        {
            _dbcontext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbcontext.Attendances.Any(a => a.AttendanceId == userId && a.CourseId == attendanceDto.CourseId))
                return BadRequest("The Attendance already exist!");
            var attendance = new Attendance
            {
                CourseId = attendanceDto.CourseId,
                AttendanceId = userId
            };

            _dbcontext.Attendances.Add(attendance);
            _dbcontext.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteAttendance(int id)
        {
            var userId = User.Identity.GetUserId();

            var attendance = _dbcontext.Attendances
                .SingleOrDefault(a => a.AttendanceId == userId && a.CourseId == id);
            if(attendance == null)
                return NotFound();

            _dbcontext.Attendances.Remove(attendance);
            _dbcontext.SaveChanges();

            return Ok(id);
        }
    }
}
