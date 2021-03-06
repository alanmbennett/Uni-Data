﻿using System;
using System.Collections.Generic;
using System.Data;
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

namespace UniData
{
    /// <summary>
    /// Interaction logic for DeleteWindow.xaml
    /// </summary>
    public partial class DeleteWindow : Window
    {
        DatabaseHelper.Input Input; // represents whether row or column input is desired
        public bool cancelClicked; // represents if cancel button was clicked or not

        public DeleteWindow(DatabaseHelper.Input input, List<string> columns)
        {
            Input = input;
            InitializeComponent();

            cancelClicked = false;

            if(Input == DatabaseHelper.Input.Columns)
            {
                ColumnCombobox.ItemsSource = columns; // populate combobox with database columns

                /* Set a default selected item */   
                if(columns.Count > 0) 
                    ColumnCombobox.SelectedIndex = 0;

                ColumnCombobox.Visibility = Visibility.Visible;
                TextboxLabel.Content = "Column Name ";

            }
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            if (Input == DatabaseHelper.Input.Columns && ColumnCombobox.SelectedItem != null)
                this.Close();
            else
            {
                ErrorMessage.Content = "Error: Unable to delete based on parameter given.";
                ErrorMessage.Visibility = Visibility.Visible;
            }

        }

        private void UpdateErrorMessage(object sender, TextChangedEventArgs e)
        {
            if (Input == DatabaseHelper.Input.Columns && ColumnCombobox.SelectedItem != null)
                ErrorMessage.Visibility = Visibility.Hidden;
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            cancelClicked = true;
            this.Close();
        }



    }
}
