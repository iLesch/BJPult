using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Reflection;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;


namespace WpfApplication1.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<string> bankType = new ObservableCollection<string>();
        public ObservableCollection<string> BankType
        {
            get { return bankType; }
            set
            {
                bankType = value;
                RaisePropertyChanged("BankType");
            }
        }

        private Dictionary<string,string> preset1 = new Dictionary<string, string>();
        public Dictionary<string,string> Preset1
        {
            get { return preset1; }
            set
            {
                preset1 = value;
                RaisePropertyChanged("Preset1");
            }
        }

        private Dictionary<int, string> preset2 = new Dictionary<int, string>();
        public Dictionary<int, string> Preset2
        {
            get { return preset2; }
            set
            {
                preset2 = value;
                RaisePropertyChanged("Preset2");
            }
        }

        private Dictionary<int, string> banksel = new Dictionary<int, string>();
        public Dictionary<int, string> BankSel
        {
            get { return banksel; }
            set
            {
                BankSel = value;
                RaisePropertyChanged("BankSel");
            }
        }

        private Dictionary<int, int> relays = new Dictionary<int, int>();
        public Dictionary<int, int> Relays
        {
            get { return relays; }
            set
            {
                relays = value;
                RaisePropertyChanged("Relays");
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
