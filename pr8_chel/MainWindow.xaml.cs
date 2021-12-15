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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pr8_chel
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
        Primes primeOb = new Primes();
        ISeries ob;
        private void PreviewTextBoxInput(object sender, TextCompositionEventArgs e)
        {
            if (!int.TryParse(e.Text, out int addvalue))
            {
                e.Handled = true;
            }
        }
        private void Knopka(object sender, RoutedEventArgs e)
        {
            //for (int i = 0; i < 5; i++)
            {
                ob = primeOb;
                Aga.Text = "Следующее простое число = " + Convert.ToString(ob.GetNext());
            }
        }
    }
}