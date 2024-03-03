using Birthday.Models.Interfaces;
using BorderControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday.Models
{
    public class Pet : IBirthdate
    {

        public string Birthday { get; set; }
    }
}
