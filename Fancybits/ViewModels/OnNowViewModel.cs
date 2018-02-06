using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;

namespace Fancybits.ViewModels
{
    public class OnNowViewModel : ViewModelBase
    {
        public OnNowViewModel()
        {
           
        }
        ObservableCollection<SampleDataItem> _ListMovies;
        public ObservableCollection<SampleDataItem> ListMovies { get { return _ListMovies; } set { Set(ref _ListMovies, value); } }
        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> suspensionState)
        {
            ListMovies = new ObservableCollection<SampleDataItem>();
            ListMovies.Add(new SampleDataItem("","","","","","") );
            ListMovies.Add(new SampleDataItem("", "", "", "", "", ""));
            ListMovies.Add(new SampleDataItem("", "", "", "", "", ""));
            await Task.CompletedTask;
        }
        public override async Task OnNavigatedFromAsync(IDictionary<string, object> suspensionState, bool suspending)
        {
            
            await Task.CompletedTask;
        }

        public override async Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            args.Cancel = false;
            await Task.CompletedTask;
        }
        public class SampleDataItem
        {
            public SampleDataItem(String uniqueId, String title, String subtitle, String imagePath, String description, String content)
            {
                this.UniqueId = uniqueId;
                this.Title = title;
                this.Subtitle = subtitle;
                this.Description = description;
                this.ImagePath = imagePath;
                this.Content = content;
            }

            public string UniqueId { get; private set; }
            public string Title { get; private set; }
            public string Subtitle { get; private set; }
            public string Description { get; private set; }
            public string ImagePath { get; private set; }
            public string Content { get; private set; }

            public override string ToString()
            {
                return this.Title;
            }
        }
    }
}
