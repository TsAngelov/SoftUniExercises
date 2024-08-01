﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORM.App.Models
{
    public class Department
    {
        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; }

        public ICollection<Employee> Employees { get; }
    }
}
