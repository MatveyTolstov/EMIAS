using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMIAS.Model
{
    internal class Doctor
    {
        public int IdDoctor { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public int SpecialityId { get; set; }
        public string EnterPassword { get; set; }
        public string WorkAddress { get; set; }
    }
}
