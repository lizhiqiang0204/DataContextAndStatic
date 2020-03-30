using System.ComponentModel;

namespace WpfApp3
{
     public class User2Model : INotifyPropertyChanged
    {
        private string _myStr = "2";

        public string myStr //Label 标签内容绑定到这个myStr字符串
        {
            get { return _myStr; }
            set
            {
                _myStr = value;
                OnPropertyChanged("myStr");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
