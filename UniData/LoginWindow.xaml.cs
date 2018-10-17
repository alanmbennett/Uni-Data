﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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

namespace UniData
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void CreateAccountButtonClick(object sender, RoutedEventArgs e)
        {
            AccountCreationWindow accWin = new AccountCreationWindow();
            accWin.ShowDialog();
        }

        private void LoginButtonClick(object sender, RoutedEventArgs e)
        {
            /* Insert code here that checks login credentials before opening the MainWindow*/
            // Hard-coded test user is tentative code so program doesn't crash for now
            MainWindow main = new MainWindow(new UserAccount("Test", "Tester","Testing21", "testing@gmail.com", new SecureString()));
            this.Close();
            main.ShowDialog();
        }
    }
}