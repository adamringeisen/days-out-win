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

namespace WpfApp1
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

        private void Month_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            var calendar = sender as Calendar;

            if (calendar!.SelectedDate.HasValue)
            {
                DateTime date = calendar.SelectedDate.Value;
                txtHeader.Text = $"Selected Date: {date.ToShortDateString()}";
                lbl_10_days.Content = $"10 days out is {date.AddDays(10).ToShortDateString()}";
                lbl_15_days.Content = $"15 days out is {date.AddDays(15).ToShortDateString()}";
                lbl_25_days.Content = $"25 days out is {date.AddDays(25).ToShortDateString()}";
                lbl_30_days.Content = $"30 days out is {date.AddDays(30).ToShortDateString()}";
                lbl_35_days.Content = $"35 days out is {date.AddDays(35).ToShortDateString()}";
            }
        }

        private void btnResetCalendar_Click(object sender, RoutedEventArgs e)
        {
            Month.DisplayDate = DateTime.Today;
            Month.SelectedDate = DateTime.Today;
        }
    }
}
