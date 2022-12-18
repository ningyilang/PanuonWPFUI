using Panuon.WPF;
using Panuon.WPF.UI;
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
using System.Windows.Shapes;

namespace PanuonWPFUI.Views
{
    /// <summary>
    /// ProjectManagement.xaml 的交互逻辑
    /// </summary>
    public partial class ProjectManagement : WindowX
    {
        public ProjectManagement()
        {
            InitializeComponent();
            lsb.ItemsSource = new List<string>()
            {
                "\ue941",
                "\ue942",
                "\ue943",
                "\ue944",
            };
            lcHeaders.ItemsSource = new ObservableCollectionX<ItemsHeader>()
            {
                new ItemsHeader()
                {
                    ImageSource="/Image/Icon2.jpg",
                },
                new ItemsHeader()
                {
                    ImageSource="/Image/Icon2.jpg",
                },
                new ItemsHeader()
                {
                    ImageSource="/Image/Icon2.jpg",
                },
                new ItemsHeader()
                {
                    ExtendNumber=10
                }               
            };

            IcActivity.ItemsSource = new ObservableCollectionX<ItemsActivity>()
            {
                new ItemsActivity()
                {
                    HeadImage="/Image/Icon2.jpg",
                    DisPlayName="Tom",
                    DisPlayTime=DateTime.Now  
                },
                new ItemsActivity()
                {
                    HeadImage="/Image/Icon2.jpg",
                    DisPlayName="Lucy",
                    DisPlayTime=DateTime.Now
                }
            };
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            WindowState= WindowState.Minimized; 
        }

        private void btnMax_Click(object sender, RoutedEventArgs e)
        {
            if(WindowState==WindowState.Maximized)
            { 
                WindowState= WindowState.Normal;
            }
            else
            {
                WindowState= WindowState.Maximized;    
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

    public class ItemsHeader:NotifyPropertyChangedBase
    {
        private string _imageSource;
        public string ImageSource
        {
           get=>_imageSource; set => Set(ref _imageSource,value);
        }

        private int _extendNumber;

        public int ExtendNumber
        {
            get => _extendNumber;set=> Set(ref _extendNumber,value);
        }
    }

    public class ItemsActivity : NotifyPropertyChangedBase
    {
        private string _headImage;
        public string HeadImage
        {
            get => _headImage; set => Set(ref _headImage, value);
        }

        private string _disPlayName;
        public string DisPlayName
        {
            get => _disPlayName; set => Set(ref _disPlayName, value);
        }

        private DateTime _disPlayTime;
        public DateTime DisPlayTime
        {
            get => _disPlayTime; set => Set(ref _disPlayTime, value);
        }
    }


}
