using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Data;

namespace ADSE2509_Edulink_Student_Staff_WPF_DB
{
    internal class StudentViewModel : INotifyPropertyChanged
    {
        // Repository object used to perform CRUD operations on the Student table
        private readonly SqlServerStudentRepository _repository = new SqlServerStudentRepository();

        // Collection holding all student records loaded from the database
        public ObservableCollection<Student> StudentList { get; } = new ObservableCollection<Student>();

        // View wrapper used for filtering and navigating through the student collection
        public ICollectionView StudentView { get; }

        private Student _selectedStudent = new Student
        {
            BirthDate = DateTime.Today,
            CurrentSem = 1
        };

        // Currently selected student bound to the form inputs and DataGrid
        public Student SelectedStudent
        {
            get => _selectedStudent;
            set
            {
                _selectedStudent = value;
                OnPropertyChanged();
            }
        }

        private string _searchText = string.Empty;

        // Search text used to filter students by name, course, or nationality
        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                OnPropertyChanged();
                StudentView.Refresh();
            }
        }

        private string _statusMessage = string.Empty;

        // Status message displayed at the bottom of the Student window
        public string StatusMessage
        {
            get => _statusMessage;
            set
            {
                _statusMessage = value;
                OnPropertyChanged();
            }
        }

        // Constructor to initialise the collection view and load student records
        public StudentViewModel()
        {
            StudentView = CollectionViewSource.GetDefaultView(StudentList);
            StudentView.Filter = FilterStudents;
            LoadData();
        }

        // Method to filter student records based on the user's search query
        private bool FilterStudents(object obj)
        {
            if (obj is not Student student)
                return false;

            if (string.IsNullOrWhiteSpace(SearchText))
                return true;

            return (student.Names?.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ?? false)
                || (student.Course?.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ?? false)
                || (student.Nationality?.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ?? false)
                || (student.StudentNo?.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ?? false);
        }

        //=============================================================================
        // STUDENT CRUD METHODS
        //=============================================================================

        // Method to load/refresh all student records from the database
        public void LoadData()
        {
            try
            {
                StudentList.Clear();

                foreach (var student in _repository.GetAll())
                {
                    StudentList.Add(student);
                }

                SelectedStudent = StudentList.FirstOrDefault() ?? new Student
                {
                    BirthDate = DateTime.Today,
                    CurrentSem = 1
                };

                if (StudentList.Count > 0)
                    StudentView.MoveCurrentToFirst();

                StatusMessage = $"Loaded {StudentList.Count} record(s) from the database.";
            }
            catch (Exception e)
            {
                SelectedStudent = new Student
                {
                    BirthDate = DateTime.Today,
                    CurrentSem = 1
                };
                StatusMessage = $"Loading student records failed: {e.Message}";
            }
        }

        // Method to add a new student record to the database
        public void AddStudent()
        {
            if (!HasValidStudent())
            {
                StatusMessage = "Please enter at least a student number and name before adding a record";
                return;
            }

            try
            {
                var name = SelectedStudent.Names;
                _repository.Add(SelectedStudent);
                LoadData();
                StatusMessage = $"Added {name}'s record(s) to the database.";
            }
            catch (Exception e)
            {
                StatusMessage = $"Insert failed: {e.Message}";
            }
        }

        // Method to update an existing student's record in the database
        public void UpdateStudent()
        {
            if (!HasValidStudent())
            {
                StatusMessage = "Please select a valid student before updating.";
                return;
            }

            try
            {
                var name = SelectedStudent.Names;
                _repository.Update(SelectedStudent);
                LoadData();
                StatusMessage = $"Updated {name}'s record(s) in the database.";
            }
            catch (Exception e)
            {
                StatusMessage = $"Update failed: {e.Message}";
            }
        }

        // Method to delete the selected student's record from the database
        public void DeleteStudent()
        {
            if (!HasValidStudent())
            {
                StatusMessage = "Please select a valid student before deleting.";
                return;
            }

            try
            {
                var name = SelectedStudent.Names;
                _repository.Delete(SelectedStudent);
                LoadData();
                StatusMessage = $"Deleted {name}'s record(s) in the database.";
            }
            catch (Exception e)
            {
                StatusMessage = $"Delete failed: {e.Message}";
            }
        }

        //=============================================================================
        // NAVIGATION & HELPER METHODS
        //=============================================================================

        // Method to synchronise SelectedStudent with the current item in StudentView
        private void SyncCurrentSelection()
        {
            if (StudentView.CurrentItem is Student current)
            {
                SelectedStudent = current;
            }
        }

        // Method to move to the first student record
        public void First()
        {
            StudentView.MoveCurrentToFirst();
            SyncCurrentSelection();
        }

        // Method to move to the previous student record
        public void Previous()
        {
            if (!StudentView.MoveCurrentToPrevious())
                StudentView.MoveCurrentToFirst();

            SyncCurrentSelection();
        }

        // Method to move to the next student record
        public void Next()
        {
            if (!StudentView.MoveCurrentToNext())
                StudentView.MoveCurrentToLast();

            SyncCurrentSelection();
        }

        // Method to move to the last student record
        public void Last()
        {
            StudentView.MoveCurrentToLast();
            SyncCurrentSelection();
        }

        // Method to clear the form and prepare a blank Student object for entry
        public void PrepareNewStudent()
        {
            SelectedStudent = new Student
            {
                BirthDate = DateTime.Today,
                CurrentSem = 1
            };

            StatusMessage = "Ready to add a new student";
        }

        // Method to check whether the student no. and name fields have been filled
        private bool HasValidStudent() =>
            SelectedStudent != null &&
            !string.IsNullOrWhiteSpace(SelectedStudent.StudentNo) &&
            !string.IsNullOrWhiteSpace(SelectedStudent.Names);

        public event PropertyChangedEventHandler? PropertyChanged;

        // Helper method to notify the UI when a bound property value changes
        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
