using System.Windows;

namespace ADSE2509_Edulink_Student_Staff_WPF_DB
{
    /// <summary>
    /// Interaction logic for StaffWindow.xaml
    /// </summary>
    public partial class StaffWindow : Window
    {
        // The ViewModel holds the staff data and does the database work
        private readonly StaffViewModel _viewModel = new StaffViewModel();

        public StaffWindow()
        {
            InitializeComponent();
            DataContext = _viewModel; // Connects the {Binding ...} in the XAML to the ViewModel
        }

        // Top buttons
        private void btnNew_Click(object sender, RoutedEventArgs e) => _viewModel.PrepareNewStaff();
        private void btnRefresh_Click(object sender, RoutedEventArgs e) => _viewModel.LoadData();

        // CRUD buttons
        private void btnAdd_Click(object sender, RoutedEventArgs e) => _viewModel.AddStaff();
        private void btnUpdate_Click(object sender, RoutedEventArgs e) => _viewModel.UpdateStaff();

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(
                $"Are you sure you want to delete {_viewModel.SelectedStaff?.Names}'s record?",
                "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
                _viewModel.DeleteStaff();
        }

        // Navigation buttons
        private void btnFirst_Click(object sender, RoutedEventArgs e) => _viewModel.First();
        private void btnPrevious_Click(object sender, RoutedEventArgs e) => _viewModel.Previous();
        private void btnNext_Click(object sender, RoutedEventArgs e) => _viewModel.Next();
        private void btnLast_Click(object sender, RoutedEventArgs e) => _viewModel.Last();
    }
}
