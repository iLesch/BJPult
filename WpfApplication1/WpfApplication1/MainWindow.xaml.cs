using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApplication1.ViewModel;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
        MainWindowViewModel curState = new MainWindowViewModel();
		public MainWindow()
		{
			InitializeComponent();
            Initialize initClassObject = new Initialize();            
            DataContext = curState;
       //     curState.BankType.Add("1");
       //     curState.BankType.Add("2");
       //     curState.BankType.Add("3");
        //  initClassObject.InitializeBankType(curState);
		}
        private void RenameBank_Click(object sender, RoutedEventArgs e)
        {
            //var Str = curState.BankType;          
        }
	}
}
