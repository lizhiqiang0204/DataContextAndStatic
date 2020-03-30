using System.Windows;
using System.Windows.Controls;


namespace WpfApp3
{
    /// <summary>
    /// UserControl2.xaml 的交互逻辑
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        public static User2Model UserModel;//定义UserModel，在构造方法中把实体类UserModel2赋给UserModel,这个UserModel是静态的，其他的类可以直接调用更改实体类里面的属性，从而实现其他页面类更改访问此页面类的属性
        public static int i = 0;

        public UserControl2()
        {
            InitializeComponent();
            DataContext = new User2Model();//设置绑定数据的上下文为User2Model类
            UserModel = (User2Model)DataContext;//这个UserModel就是实体类User2Model
        }
        //累加按键处理事件
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            i++;//按一下数值累加一次
            UserModel.myStr = i.ToString();//更改实体类标签内容值（立刻更新标签内容）
        }

    }
}
