using BL_3300;
using DAL;
using BE;
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
using System.Windows.Shapes;

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for AddTester.xaml
    /// </summary>
    public partial class AddTester : Window
    {
        BE.Tester tester;
        BL.BL_imp bl;
        public AddTester()
        {
            InitializeComponent();
            tester = new BE.Tester();
            this.gridAddTester.DataContext = tester;
            bl = BL.FactoryBL.getBL();
            this.comboBox1.ItemsSource = Enum.GetValues(typeof(BE.gender));
        }

        private void addBranchButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.addBranch(branch);
                MessageBox.Show("the branch \"" + branch.branchName + "\" added to the list", "");
                branch = new BE.Branch();
                this.gridAddBranch.DataContext = branch;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}