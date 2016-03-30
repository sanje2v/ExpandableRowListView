using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ExpandableRowListView
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }


        private ObservableCollection<ExpandableRowListViewControlItem> _Items = new ObservableCollection<ExpandableRowListViewControlItem>();
        public ObservableCollection<ExpandableRowListViewControlItem> Items
        {
            get { return _Items; }
            set { _Items = value; OnPropertyChanged(nameof(Items)); }
        }

        protected override void OnNavigatedTo(NavigationEventArgs ev)
        {
            base.OnNavigatedTo(ev);

            // Use either the following with 'control.ItemsSource' or uncomment the following code
            //var item1 = new ExpandableRowListViewControlItem();
            //var header1 = new TextBlock();
            //header1.Text = "Row1";
            //var listview1 = new ListView();
            //var listviewdata1 = new ObservableCollection<ListViewItem>();
            //listviewdata1.Add(new ListViewItem() { Content = "!!" });
            //listviewdata1.Add(new ListViewItem() { Content = "??" });
            //listviewdata1.Add(new ListViewItem() { Content = "##" });
            //listview1.ItemsSource = listviewdata1;
            //item1.RowHeader = header1;
            //item1.Content = listview1;

            //var item2 = new ExpandableRowListViewControlItem();
            //var header2 = new TextBlock();
            //header2.Text = "Row2";
            //var listview2 = new ListView();
            //var listviewdata2 = new ObservableCollection<ListViewItem>();
            //listviewdata2.Add(new ListViewItem() { Content = "1" });
            //listviewdata2.Add(new ListViewItem() { Content = "2" });
            //listviewdata2.Add(new ListViewItem() { Content = "3" });
            //listview2.ItemsSource = listviewdata2;
            //item2.RowHeader = header2;
            //item2.Content = listview2;

            //Items.Add(item1);
            //Items.Add(item2);
        }
    }
}
