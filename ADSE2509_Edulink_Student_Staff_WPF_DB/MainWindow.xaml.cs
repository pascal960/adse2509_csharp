using System.Windows;

namespace ADSE2509_Edulink_Student_Staff_WPF_DB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Start screen with buttons to open the Student and Staff windows.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStudents_Click(object sender, RoutedEventArgs e)
        {
            var window = new StudentWindow { Owner = this };
            window.ShowDialog();
        }

        private void btnStaff_Click(object sender, RoutedEventArgs e)
        {
            var window = new StaffWindow { Owner = this };
            window.ShowDialog();
        }
    }
}
