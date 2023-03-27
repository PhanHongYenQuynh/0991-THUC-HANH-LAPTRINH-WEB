using PhanHongYenQuynh_2080600991.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PhanHongYenQuynh_2080600991.ViewModels
{
    public class FollowViewModel
    {
        public IEnumerable<ApplicationUser> FollowingUser { get; set; }
        
        public bool ShowAction { get; set; }
        
       
       
    }
}