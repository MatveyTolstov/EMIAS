using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMIAS.Model
{
    internal class Admin
    {
        public int IdAdmin { get; set; }
        public string Surname { get; set; }
        public string AdminName { get; set; }
        public string Patronymic { get; set; }
        public string Email { get; set; }
        public string EnterPassword { get; set; }
    }
}
