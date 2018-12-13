using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BackButtonCIick10
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccueilMaster : ContentPage
    {
        public ListView ListView;

        public AccueilMaster()
        {
            InitializeComponent();

            BindingContext = new AccueilMasterViewModel();
            ListView = MenuItemsListView;
        }

        class AccueilMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<AccueilMenuItem> MenuItems { get; set; }
            
            public AccueilMasterViewModel()
            {
                MenuItems = new ObservableCollection<AccueilMenuItem>(new[]
                {
                    new AccueilMenuItem { Id = 0, Title = "Main Page", TargetType=typeof(MainPage) },
                    new AccueilMenuItem { Id = 1, Title = "Page 1", TargetType=typeof(Page1) }                    
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}