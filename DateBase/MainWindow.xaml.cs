using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;

namespace DateBase
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

        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


            DateBase.Orders2 orders2 = ((DateBase.Orders2)(this.FindResource("orders2")));
            // Load data into the table ORDERS. You can modify this code as needed.
            DateBase.Orders2TableAdapters.ORDERSTableAdapter orders2ORDERSTableAdapter = new DateBase.Orders2TableAdapters.ORDERSTableAdapter();
            orders2ORDERSTableAdapter.Fill(orders2.ORDERS);
            System.Windows.Data.CollectionViewSource oRDERSViewSource1 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("oRDERSViewSource1")));
            oRDERSViewSource1.View.MoveCurrentToFirst();
            DateBase.Workers2 workers2 = ((DateBase.Workers2)(this.FindResource("workers2")));
            // Load data into the table WORKERS. You can modify this code as needed.
            DateBase.Workers2TableAdapters.WORKERSTableAdapter workers2WORKERSTableAdapter = new DateBase.Workers2TableAdapters.WORKERSTableAdapter();
            workers2WORKERSTableAdapter.Fill(workers2.WORKERS);
            System.Windows.Data.CollectionViewSource wORKERSViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("wORKERSViewSource")));
            wORKERSViewSource.View.MoveCurrentToFirst();
            DateBase.Clients3 clients3 = ((DateBase.Clients3)(this.FindResource("clients3")));
            // Load data into the table CLIENTS. You can modify this code as needed.
            DateBase.Clients3TableAdapters.CLIENTSTableAdapter clients3CLIENTSTableAdapter = new DateBase.Clients3TableAdapters.CLIENTSTableAdapter();
            clients3CLIENTSTableAdapter.Fill(clients3.CLIENTS);
            System.Windows.Data.CollectionViewSource cLIENTSViewSource1 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("cLIENTSViewSource1")));
            cLIENTSViewSource1.View.MoveCurrentToFirst();
        }
    }
}
