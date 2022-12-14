using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Pandiet.Models
{
    internal class User
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime DateBirthday { get; set; }
        public int GenderID { get; set; }
        public double Weight { get; set; }
    }
}
