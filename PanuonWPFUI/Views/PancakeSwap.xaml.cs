using Panuon.WPF;
using Panuon.WPF.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using System.Windows.Shapes;
using System.Xml.Schema;

namespace PanuonWPFUI.Views
{
    /// <summary>
    /// PancakeSwap.xaml 的交互逻辑
    /// </summary>
    public partial class PancakeSwap : WindowX
    {
        public PancakeSwap()
        {
            InitializeComponent();
            IcItems.ItemsSource = new ObservableCollection<Model>()
            {
                //\u=&#x 转义字符Unicode
                new Model()
                {
                    DisplayName="Total Liquidity" ,
                    Value="$268.3254",
                    AccentBrush=new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ed6f86")),
                    Icon="\ue945"
                },
                new Model()
                {
                    DisplayName="Total Liquidity2" ,
                    Value="$368.3254",
                    AccentBrush=new SolidColorBrush((Color)ColorConverter.ConvertFromString("#075E9B")),
                    Icon="\ue946"
                },
                new Model()
                {
                    DisplayName="Total Liquidity3" ,
                    Value="$468.3254",
                    AccentBrush=new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7F51C9")),
                    Icon="\ue947"
                },
                new Model()
                {
                    DisplayName="Total Liquidity4" ,
                    Value="$568.3254",
                    AccentBrush=new SolidColorBrush((Color)ColorConverter.ConvertFromString("#753F67")),
                    Icon="\ue948"
                },

            };
            IsbItems.ItemsSource = new ObservableCollection<Mode2>()
            {
                new Mode2()
                {
                    Property1="1111",
                    Property2="2222",
                    Property3="3333",
                    Property4="4444",
                    IsRaise=true,
                },
                 new Mode2()
                {
                    Property1="1111",
                    Property2="2222",
                    Property3="3333",
                    Property4="4444",
                    IsRaise=false
                },
                  new Mode2()
                {
                    Property1 = "1111",
                    Property2 = "2222",
                    Property3 = "3333",
                    Property4 = "4444",
                    IsRaise=true
                 }
           };

        }

        
    }

    public class Model : NotifyPropertyChangedBase
    {
        private string displayName;

        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }

        private Brush accentBrush;

        public Brush AccentBrush
        {
            get { return accentBrush; }
            set { accentBrush = value; }
        }

        private string icon;

        public string Icon
        {
            get { return icon; }
            set { icon = value; }
        }

        private string _value;

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }

    public class Mode2 : NotifyPropertyChangedBase
    {
        private string property1;

        public string Property1
        {
            get { return property1; }
            set { property1 = value; }
        }

        private string property2;

        public string Property2
        {
            get { return property2; }
            set { property2 = value; }
        }

        private string property3;

        public string Property3
        {
            get { return property3; }
            set { property3 = value; }
        }

        private string property4;

        public string Property4
        {
            get { return property4; }
            set { property4 = value; }
        }

        private bool isRaise;

        public bool IsRaise
        {
            get { return isRaise; }
            set { isRaise = value; }
        }

    }
}
