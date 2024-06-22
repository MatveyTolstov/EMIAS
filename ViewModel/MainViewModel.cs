using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using vipief.ViewModel.Helpers;


namespace EMIAS.ViewModel
{
    internal class MainViewModel : BindingHelper // нужен для того чтобы окошко понимало куда ей идти 
    {

        public BindableCommand Nextcommand { get; set; } // переменная ссылается на click

        public BindableCommand Prevcommand { get; set; }

        private string kalendar1;
        public string Kalendar1
        {
            get { return kalendar1; }
            set
            {
                kalendar1 = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel() {


            Nextcommand = new BindableCommand(_ => Next()); // ссылка на метод

            Prevcommand = new BindableCommand(_ => Update());

        }

        private void Next()
        {
            MessageBox.Show("Привет");
        }

        private void Update()
        {
            Kalendar1 = "Mama";
        }
    }
}
