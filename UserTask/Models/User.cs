using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserTask.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }

        [Required]
        public String Email { get; set; }

        [Required]
        public int Phone { get; set; }
    }
}