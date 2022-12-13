﻿using Panuon.WPF.UI;
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
        }
    }
}
