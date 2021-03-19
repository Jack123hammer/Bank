﻿using System;
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
        
        public MainWindowClient(int client_out)
        {
            InitializeComponent();
            client_in = client_out;
            Update();
        }

        public void Update()
        {
            
                dg_client.ItemsSource = db.Bank_account_number.Where(t=>t.id_account == client_in).ToList();
            DG_History.ItemsSource = db.Transaction.Where(t => t.Sender.Bank_account_number.id_account == client_in || t.Reciever.Bank_account_number.id_account == client_in).ToList();


        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Authorization m = new Authorization();
            m.Show();
            Close();
        }
    }
}
