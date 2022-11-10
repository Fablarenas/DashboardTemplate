﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestingAppQa.Models
{
    [Table("Sprint")]
    public class Sprint
    {
        [Key]
        public int IdSprint { get; set; }

        public string Name { get; set; }

        public virtual Project Project { get; set; }

        public List<UserHistory> HistoryUsers { get; set; }
    }
}
