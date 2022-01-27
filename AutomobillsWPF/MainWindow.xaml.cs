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

namespace AutomobillsWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private OverviewPage mOverviewPage;
        private BudgetPage mBudgetPage;

        public MainWindow()
        {
            InitializeComponent();
            mOverviewPage = new OverviewPage();
            mBudgetPage = new BudgetPage();
            PageFrame.Content = mOverviewPage;
        }

        private void OverviewPage_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = mOverviewPage;
        }

        private void Budget_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = mBudgetPage;
        }
    }



}
