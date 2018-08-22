using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfApp2.Model
{
    public class Student
    {
        string _name, _lastName;
        public event PropertyChangedEventHandler PropertyChanged;

        public Student()
        {
            Name = "Gal";
            LastName = "Hadour";
        }

        //public string Name
        //{
        //    get;
        //    set;
        //}

        //public string LastName
        //{
        //    get;
        //    set;
        //}

        public string Name
        {
            get;set;
        }

        public string LastName
        {
            get;set;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}",
              Name, LastName);
        }
        protected void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
