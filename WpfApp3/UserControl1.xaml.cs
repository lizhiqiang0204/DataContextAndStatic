using System.Windows;
using System.Windows.Controls;

namespace WpfApp3
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        //定义UserModel，在构造方法中把实体类UserModel1赋给UserModel,这个UserModel是静态的，其他的类可以直接调用更改实体类里面的属性，从而实现其他页面类(比如MainWindow.xaml.cs)更改访问此页面类的属性
        public static User1Model UserModel ;
        public static int i = 0;

        public UserControl1()
        {
            InitializeComponent();
            DataContext = new User1Model();//设置绑定数据的上下文为User1Model类
            UserModel = (User1Model)DataContext;
        }

        //累加按键处理事件
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            i++;//按一下数值累加一次
            UserModel.myStr = i.ToString();//更改实体类标签内容值（立刻更新标签内容）
        }
    }
}
