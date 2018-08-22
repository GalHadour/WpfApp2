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

namespace WpfApp2.Controls
{
    /// <summary>
    /// Interaction logic for TestUserControl.xaml
    /// </summary>
    public partial class TestUserControl : UserControl
    {
        
        public static readonly DependencyProperty TextInControlProperty1 = DependencyProperty.Register("Text1", typeof(string), typeof(TestUserControl));
        public static readonly DependencyProperty TextInControlProperty2 = DependencyProperty.Register("Text2", typeof(string), typeof(TestUserControl));
        public static readonly DependencyProperty TextInControlProperty3 = DependencyProperty.Register("Text3", typeof(string), typeof(TestUserControl));

        public string Text1
        {
            get { return (string)GetValue(TextInControlProperty1); }
            set { SetValue(TextInControlProperty1, value); }
        }

        public string Text2
        {
            get { return (string)GetValue(TextInControlProperty2); }
            set { SetValue(TextInControlProperty2, value); }
        }

        public string Text3
        {
            get { return (string)GetValue(TextInControlProperty3); }
            set { SetValue(TextInControlProperty3, value); }
        }


        public static readonly DependencyProperty CopyTextProperty =
      DependencyProperty.Register(
          "CopyText",
          typeof(RelayCommand1),
          typeof(TestUserControl),
          new UIPropertyMetadata(null));
        public RelayCommand1 CopyText
        {
            get { return (RelayCommand1)GetValue(CopyTextProperty); }
            set { SetValue(CopyTextProperty, value); }
        }

       
        private void OnCopyText()
        {
           Text3= Text1 +" "+ Text2;
        }
        public TestUserControl()
        {
            InitializeComponent();
            CopyText = new RelayCommand1(OnCopyText);

        }
        //public TestUserControl(string fullName)
        //{
        //    InitializeComponent();

        //    string []_fullName = fullName.Split(' ');
        //    Text1 = _fullName[0];
        //    Text2 = _fullName[1];

        //    CopyText = new RelayCommand1(OnCopyText);

        //}






    }
}
