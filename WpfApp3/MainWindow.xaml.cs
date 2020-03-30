using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        private UserControl1 User1 = new UserControl1();//实例化用户控件1
        private UserControl2 User2 = new UserControl2();//实例化用户控件2

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void ButtonClick1(object sender, RoutedEventArgs e)
        {
            UserContent = User1;//内容呈现器绑定的UserContent赋值给用户控件1
        }

        private void ButtonClick2(object sender, RoutedEventArgs e)
        {
            UserContent = User2;//内容呈现器绑定的UserContent赋值给用户控件2
        }

        private UserControl _content;
        //内容呈现器绑定到UserContent
        public UserControl UserContent
        {
            get { return _content; }
            set
            {
                _content = value;
                OnPropertyChanged("UserContent");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void btnClearAll(object sender, RoutedEventArgs e)
        {
            UserControl1.i = 0;
            UserControl1.UserModel.myStr = "0";

            UserControl2.i = 0;
            UserControl2.UserModel.myStr = "0";
        }
    }
}
