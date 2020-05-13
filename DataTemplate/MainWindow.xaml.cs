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

namespace DataTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<DataTemplate1> Students = new List<DataTemplate1>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataTemplate1 s1 = new DataTemplate1() { StudentName = "Mary", StudentNumber = "s13234534", GPA = 77.5, StudentImage = "/images/cat.jpg" };
            DataTemplate1 s2 = new DataTemplate1() { StudentName = "Jim", StudentNumber = "s13234500", GPA = 35, StudentImage = "/images/dog.jpg" };

            Students.Add(s1);
            Students.Add(s2);

            lbxStudents.ItemsSource = Students;
        }
    }
}
