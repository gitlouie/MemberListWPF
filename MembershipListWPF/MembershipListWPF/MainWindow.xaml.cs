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

namespace MembershipListWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnExit(Object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();

        }
        private void BtnAdd(Object sender, RoutedEventArgs e)
        {
            AddMembershipForm addForm = new AddMembershipForm();
            addForm.Show();

        }
        private void BtnDelete(Object sender, RoutedEventArgs e)
        {
            MembershipList m = new MembershipList();
            m.Write();

        }
    }
}
