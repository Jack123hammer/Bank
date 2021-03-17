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
using System.Windows.Shapes;

namespace Bank
{
    /// <summary>
    /// Логика взаимодействия для MainWindowAdmin.xaml
    /// </summary>
    public partial class MainWindowAdmin : Window
    {
        Entities db = new Entities();
        public MainWindowAdmin()
        {
            InitializeComponent();
            Update();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Authorization m = new Authorization();
            m.Show();
            
        }

        public void Update()
        {
            DG_Account.ItemsSource = db.Bank_account_number.ToList();
            DG_History.ItemsSource = db.Transaction.ToList();
            
        }
    }
}
