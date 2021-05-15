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

namespace asynchronous_demo
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

        // this method will cause screen to lock
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var slowCalculations = new SlowCalculations();
            var s = slowCalculations.GetData();
            txtCalculatedData.Text = s;
        }

        // no screen locking by clicking it
        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var slowCalculations = new SlowCalculations();
            var s = await Task.Run(() => slowCalculations.GetData());
            txtCalculatedData.Text = s;
        }

        private async void btnUseAsyncCalc_Click(object sender, RoutedEventArgs e)
        {
            var slowCalculations = new SlowCalculations();
            var s = await slowCalculations.GetDataAsync();
            txtCalculatedData.Text = s;
        }
    }
}
