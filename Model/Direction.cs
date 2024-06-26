using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMIAS.Model
{
    internal class Direction//класс для напрвалений
    {
        public int IdDirection { get; set; }//id

        public int SpecialityId { get; set; }//id специальности

        public long Oms { get; set; } //id пользователя
    }
}
