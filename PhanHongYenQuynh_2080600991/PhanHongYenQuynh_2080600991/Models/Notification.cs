using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhanHongYenQuynh_2080600991.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }

        public DateTime OriginalDateTime { get; set; }
        public string OriginalPlace { get; set; }

        public int Type { get; set; }
        public byte Course_Id { get; set; }
        public Course Course { get; set; }
    }
}