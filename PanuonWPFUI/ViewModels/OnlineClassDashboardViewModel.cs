using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanuonWPFUI.ViewModels
{
    public class OnlineClassDashboardViewModel:BindableBase
    {
        public OnlineClassDashboardViewModel()
        {
            DataLoad();
        }

        private ObservableCollection<DataBorad> db;

        public ObservableCollection<DataBorad> Db
        {
            get { return db; }
            set { db = value;RaisePropertyChanged(); }
        }

        void DataLoad()
        {
            db = new ObservableCollection<DataBorad>();
            // db.Add(new DataBorad() { Name="Mark",Icon1= "&#xe970;",Icon2= "&#xe971;",Icon3= "&#xe972;",Text="Class1"});
            DataBorad dataBorad1 = new DataBorad()
            {
                content = new Content()
                {
                    Icon1 = @"&#xe970;",
                    Icon2 = @"&#xe970;",
                    Icon3 = @"&#xe970;",
                    Name="Mark",
                    Text="This is Mark"
                },
            };

            DataBorad dataBorad2 = new DataBorad()
            {
                content = new Content()
                {
                    Icon1 = @"&#xe970;",
                    Icon2 = @"&#xe970;",
                    Icon3 = @"&#xe970;",
                    Name = "Mark",
                    Text = "This is Mark"
                },
            };

            DataBorad dataBorad3 = new DataBorad()
            {
                content = new Content()
                {
                    Icon1 = @"&#xe970;",
                    Icon2 = @"&#xe970;",
                    Icon3 = @"&#xe970;",
                    Name = "Mark",
                    Text = "This is Mark"
                },
            };

            db.Add(dataBorad1);
            db.Add(dataBorad2);
            db.Add(dataBorad3);
        }


    }

    public class DataBorad
    {
        public Content content { get; set; }
    }

    public class Content
    {
        public string Name { get; set; }
        public string Icon1 { get; set; }
        public string Icon2 { get; set; }
        public string Icon3 { get; set; }
        public string Text { get; set; }
    }

}
