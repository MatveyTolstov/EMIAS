using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMIAS.Model
{
    internal class Patient
    {
        public long Oms { get; set; }

        public string Surname { get; set; } 

        public string FirstName { get; set; } 

        public string Patronymic { get; set; } 

        public DateTime BirthDate { get; set; }

        public string Addresss { get; set; } 

        public string LivingAddress { get; set; } 

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Nickname { get; set; }
    }
}
