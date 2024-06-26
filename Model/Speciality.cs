using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMIAS.Model
{
    internal class Speciality
    {
        public int IdSpeciality { get; set; } //id

        public string Name { get; set; } //назавние специанльности

        public string ImagePath { get; set; } //путь до папки с картинкой
    }
}
