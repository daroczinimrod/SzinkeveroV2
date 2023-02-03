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

namespace WpfApp3
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

        private void SzinBeallito()
        {
            rctTeglalap.Fill = new SolidColorBrush(Color.FromRgb(Convert.ToByte(sliPiros.Value), Convert.ToByte(sliZold.Value), Convert.ToByte(sliKek.Value)));
        }
        private void sliPiros_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SzinBeallito();
        }

        private void sliZold_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SzinBeallito();
        }

        private void sliKek_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SzinBeallito();
        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {
            lbSzinek.Items.Add(Convert.ToByte(sliPiros.Value) +  "," + Convert.ToByte(sliZold.Value) + "," + Convert.ToByte(sliKek.Value));
        }

        private void btnTorol_Click(object sender, RoutedEventArgs e)
        {
            if (lbSzinek.SelectedIndex == -1)
            {
                MessageBox.Show("Nincs kiválasztva elem.");
            }
            else
            {
                lbSzinek.Items.RemoveAt(lbSzinek.SelectedIndex);
            }

        }

        private void btnUrit_Click(object sender, RoutedEventArgs e)
        {
            lbSzinek.Items.Clear();
        }
    }
}
