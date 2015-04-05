﻿using OxyPlot;
//using OxyPlot.Axes;
using OxyPlot.Wpf;
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

namespace UseOxyPlot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel vm = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddPt_Click(object sender, RoutedEventArgs e)
        {
            double x, y;

            if (Double.TryParse(txtX.Text, out x) && Double.TryParse(txtY.Text, out y))
            {
                mv.Points.Add(new DataPoint(x, y));
                oxPlot.InvalidatePlot(true);
            }

        }

    }
}
