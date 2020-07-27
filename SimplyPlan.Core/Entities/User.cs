﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimplyPlan.Core.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}
