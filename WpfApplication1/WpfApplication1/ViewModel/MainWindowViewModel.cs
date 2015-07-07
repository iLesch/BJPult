using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Reflection;
using System.Collections.ObjectModel;


namespace WpfApplication1.ViewModel
{
    class MainWindowViewModel
    {
        private ObservableCollection<string> bankType = new ObservableCollection<string>();
        public ObservableCollection<string> BankType
        {
            get { return bankType; }
            set
            {
                bankType = value;
            }
        }
        public MainWindowViewModel()
        {
            // Добаваить чтение полей из Xaml-файла конфигурации
            bankType.Add("CC_ct");
            bankType.Add("CC_mt");
            bankType.Add("PC");
            bankType.Add("CC_tg");
            bankType.Add("BankUp");
            bankType.Add("BankDown");
            bankType.Add("SH");            
        }

    }
}
