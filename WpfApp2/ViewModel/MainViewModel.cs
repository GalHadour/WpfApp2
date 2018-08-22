using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp2.Controls;
using WpfApp2.Model;

namespace WpfApp2.ViewModel
{
    public class MainViewModel : DependencyObject
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // private TestUserControl _testUserControl;
        private string _name, _lastName;
        private Student _Student;
     
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
                TestUserControlChange.Text1 = value;
            }
        }

        public string LastName
        {
            get { return _Student.LastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged("LastName");
                TestUserControlChange.Text2 = value;
            }
        }

        public Student StudentName
        {
            get
            {
                return _Student;
            }
            set
            {
                _Student = value;
                OnPropertyChanged("StudentName");
            }
        }

        //public TestUserControl TestUserControlChange
        //{
        //    get { return _testUserControl; }
        //    set { _testUserControl = value; }
        //}

        public TestUserControl TestUserControlChange { get; set; }
        public MainViewModel()
        {
            TestUserControlChange = new TestUserControl();
            _Student = new Student();
            CopyFullName = new RelayCommand1(OnCopyFullName);
            
            Name = _Student.Name;
            LastName = _Student.LastName;
            //TestUserControlChange.Text3 = student.ToString();

            //Name = "Gal";
            //LastName = "Hadour";

        }


        public static readonly DependencyProperty CopyFullNameProperty =
DependencyProperty.Register(
"CopyFullName",
typeof(RelayCommand1),
typeof(TestUserControl),
new UIPropertyMetadata(null));
        public RelayCommand1 CopyFullName
        {
            get { return (RelayCommand1)GetValue(CopyFullNameProperty); }
            set { SetValue(CopyFullNameProperty, value); }
        }

        private void OnCopyFullName()
        {
        
            TestUserControlChange.Text3 = Name+" "+LastName;
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
 


