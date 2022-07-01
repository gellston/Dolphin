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

namespace View
{
    /// <summary>
    /// SideMenu.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SideMenu : UserControl
    {
        public SideMenu()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty MainContentProperty = DependencyProperty.Register("MainContent", typeof(object), typeof(SideMenu));
        public object MainContent
        {
            get
            {
                return (object)GetValue(MainContentProperty);
            }

            set
            {
                SetValue(MainContentProperty, value);
            }
        }

        public static readonly DependencyProperty MenuContentProperty = DependencyProperty.Register("MenuContent", typeof(object), typeof(SideMenu));
        public object MenuContent
        {
            get
            {
                return (object)GetValue(MenuContentProperty);
            }

            set
            {
                SetValue(MenuContentProperty, value);
            }
        }

        public static readonly DependencyProperty IsCloseProperty = DependencyProperty.Register("IsClose", typeof(bool), typeof(SideMenu));
        public bool IsClose
        {
            get
            {
                return (bool)GetValue(IsCloseProperty);
            }

            set
            {
                SetValue(IsCloseProperty, value);
            }
        }
    }
}
