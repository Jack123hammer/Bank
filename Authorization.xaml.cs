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
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        Entities db = new Entities();
        public int level_out;
        
        public Authorization()
        {
            InitializeComponent();
            
        }

        private void btn_auth_employer_Click(object sender, RoutedEventArgs e)
        {
            Employers emp = db.Employers.SingleOrDefault(t => t.Login == Login_emp.Text && t.Password == Password_emp.Password);
            if (emp == null)
            {
                MessageBox.Show("Debil");
            }
            else if (emp.Type_of_employee ==1)
            {
                MainWindowAdmin m = new MainWindowAdmin();
                m.Show();
                Close();
            }
            else if (emp.Type_of_employee == 2)
            {
                MainWindowModerator m = new MainWindowModerator();
                m.Show();
                Close();
            }
            else if (emp.Type_of_employee == 3)
            {
                MainWindowOperator m = new MainWindowOperator();
                m.Show();
                Close();
            }
            
        }

        private void btn_auth_client_Click(object sender, RoutedEventArgs e)
        {
            //Entity_clients ent = db.Entity_clients.SingleOrDefault(t => t.Login == login_client.Text && t.Password == Password_client.Password);
            Logins_and_passwords lap = db.Logins_and_passwords.SingleOrDefault(t => t.Login == login_client.Text && t.Password == Password_client.Password);
            int id_pair = lap.ID_of_pair;
            Account acc = db.Account.SingleOrDefault(t => t.id_pair == id_pair);
            if (lap == null )
            {
                MessageBox.Show("Debil");
            }
            else if (lap !=null)
            {
                int client_out = acc.ID_account;
                
                MainWindowClient m =new MainWindowClient(client_out);
                m.Show(); 
                Close();
            }
            
        }
    }
}
