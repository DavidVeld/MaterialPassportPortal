using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MaterialPassportPortal
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class ImportParams : Window
    {
        public ObservableCollection<BoolStringClass> TheList { get; set; }

        public ImportParams()
        {
            InitializeComponent();

            TheList = new ObservableCollection<BoolStringClass>();
            TheList.Add(new BoolStringClass { IsSelected = true, TheText = "Some text for item #1" });
            TheList.Add(new BoolStringClass { IsSelected = false, TheText = "Some text for item #2" });
            TheList.Add(new BoolStringClass { IsSelected = false, TheText = "Some text for item #3" });
            TheList.Add(new BoolStringClass { IsSelected = false, TheText = "Some text for item #4" });
            TheList.Add(new BoolStringClass { IsSelected = false, TheText = "Some text for item #5" });
            TheList.Add(new BoolStringClass { IsSelected = true, TheText = "Some text for item #6" });
            TheList.Add(new BoolStringClass { IsSelected = false, TheText = "Some text for item #7" });

            this.DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_OkClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

    public class BoolStringClass
    {
        public string TheText { get; set; }
        public bool IsSelected { get; set; }
    }
}
