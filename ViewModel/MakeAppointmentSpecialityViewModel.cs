using EMIAS.cards;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;


namespace EMIAS.ViewModel
{
   
    public class MakeAppointmentSpecialityViewModel 
    {

       
        private string _selectedTimeSlot;
        private ObservableCollection<string> _timeSlots; // Переменная для временных слотов


       
        

        

        public class DayOfMonthViewModel
        {
            public DateTime Day { get; set; }
            public bool IsPastDate => Day < DateTime.Today;
        }


        


        public ObservableCollection<string> TimeSlots // Использование ObservableCollection<string> для временных слотов
        {
            get { return _timeSlots; }
            set
            {
                _timeSlots = value;
  
            }
        }

        public string SelectedTimeSlot
        {
            get { return _selectedTimeSlot; }
            set
            {
                if (_selectedTimeSlot != value)
                {
                    _selectedTimeSlot = value;
                }
            }
        }

        private void LoadTimeSlots()
        {
            var startTime = new DateTime(1, 1, 1, 8, 0, 0); // 8:00 AM
            var endTime = new DateTime(1, 1, 1, 20, 0, 0);  // 9:00 PM

            TimeSlots = new ObservableCollection<string>();
            while (startTime <= endTime)
            {
                TimeSlots.Add(startTime.ToString("HH:mm"));
                startTime = startTime.AddMinutes(10);
            }
        }

        private void Back(object obj)
        {
            // Действие при нажатии кнопки "Назад"
        }

        private void SignUp(object obj)
        {
            // Действие при нажатии кнопки "Записаться на прием"
           
        }

    }
}