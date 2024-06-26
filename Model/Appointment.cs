using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMIAS.Model
{
    internal class Appointment//класс для записей
    {
        public int IdAppointment { get; set; } //id 

        public long Oms { get; set; } //id пользователя

        public int DoctorId { get; set; }//id врача

        public DateTime AppointmentDate { get; set; }//дата записи

        public DateTime AppointmentTime { get; set; }//время записи

        public int StatusId { get; set; }//id статуса записи
    }
}
