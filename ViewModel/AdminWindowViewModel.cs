using EMIAS.Model;
using EMIAS.ViewModel.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using vipief.ViewModel.Helpers;

namespace EMIAS.ViewModel
{
    internal class AdminWindowViewModel : BindingHelper
    {
        public BindableCommand CreateButton { get; set; } // кнопка на создание данных

        public BindableCommand ChangeComboBox { get; set; } // изменение combobox

        private string name; // id данные
        public string FirstName
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        private string surname;

        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
                OnPropertyChanged();
            }
        }

        private string midname;

        public string Middlename
        {
            get { return midname; }
            set
            {
                midname = value;
                OnPropertyChanged();
            }
        }

        private string date;

        public string Date {
            get { return date; }
            set
            {
                date = value;
                OnPropertyChanged();
            }
        }

        private string adddress;

        public string Adddress {
            get { return adddress; }
            set
            {
                adddress = value;
                OnPropertyChanged();
            }
        }

        private string id; // id данные
        public string Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }


        private object selectedItem;
        public object SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged();
                OnSelectedItemChanged();
            }
        }

        public List<string> Roles { get; set; }

        private IEnumerable data;
        public IEnumerable Data
        {
            get { return data; }
            set
            {
                data = value;
                OnPropertyChanged();
            }
        }

        private string selectedRole;
        public string SelectedRole
        {
            get { return selectedRole; }
            set
            {
                selectedRole = value;
                OnPropertyChanged();
                Load();
            }
        }

        public BindableCommand UpdateButton;

        public AdminWindowViewModel()
        {
            CreateButton = new BindableCommand(_ => Create());
            Roles = new List<string> { "Admins", "Doctors", "Patients" };
            ChangeComboBox = new BindableCommand(_ => Load());
            SelectedRole = Roles.First();
            UpdateButton = new BindableCommand(_ => Update());

        }

        private void Load()
        {
            try
            {
                string jsonResponse = Api.Get(SelectedRole);
                switch (SelectedRole)
                {
                    case "Admins":
                        Data = JsonConvert.DeserializeObject<List<Admin>>(jsonResponse);
                        break;
                    case "Doctors":
                        Data = JsonConvert.DeserializeObject<List<Doctor>>(jsonResponse);
                        break;
                    case "Patients":
                        Data = JsonConvert.DeserializeObject<List<Patient>>(jsonResponse);
                        break;
                    default:
                        Data = null;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Create()
        {
            try
            {
                var info = new { id ,   }; //создаем массив из данных

                string json = JsonConvert.SerializeObject(info);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Update()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void OnSelectedItemChanged()
        {
            // Логика обработки выбранного элемента
            if (SelectedItem != null)
            {
                // Сброс значений перед обновлением
                Id =FirstName = Surname = Middlename = Date = Adddress = string.Empty;

                if (SelectedItem is Admin admin)
                {
                    Id = admin.IdAdmin.ToString();
                    FirstName = admin.AdminName;
                    Surname = admin.Surname;
                    Middlename = admin.Patronymic;
                    Adddress = admin.Email; 
                }
                else if (SelectedItem is Doctor doctor)
                {
                    Id = doctor.IdDoctor.ToString();
                    FirstName = doctor.FirstName;
                    Surname = doctor.Surname;
                    Middlename = doctor.Patronymic;
                    Adddress = doctor.WorkAddress; 
                }
                else if (SelectedItem is Patient patient)
                {
                    Id = patient.Oms.ToString();
                    FirstName = patient.Surname;
                    Surname = patient.FirstName;
                    Middlename = patient.Patronymic;
                    Date = patient.BirthDate.ToString("yyyy-MM-dd"); 
                    Adddress = patient.Addresss; 
                }
            }
        }




    }
}
