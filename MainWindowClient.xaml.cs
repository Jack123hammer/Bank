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
    /// Логика взаимодействия для MainWindowClient.xaml
    /// </summary>
    public partial class MainWindowClient : Window
    {
        Entities db = new Entities();
        public int client_in;
        public int client_type;
        public MainWindowClient(int client_type_out,int client_out)
        {
            InitializeComponent();
            client_in = client_out;
            client_type = client_type;
        }

        public void Update()
        {
            if (client_type==1)
            {
                dg_client.ItemsSource = db.Account_physical.Where(t=>t.ID_account_physical == client_in).ToList() ;
            }
            else if (client_type == 2)
            {
                dg_client.ItemsSource = db.Entity_clients.Where(t => t.ID == client_in).ToList();
            }
            
        }
    }
}
