using RamboTweets.VM;
using RamboTweets.App.Commands;
using RamboTweets.DTO.Models;
using RamboTweets.Proxy;
using RamboTweets.Proxy.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using System.Configuration;

namespace RamboTweets.App.ViewModels
{
    /// <summary>
    /// Class MainViewModel.
    /// </summary>
    /// <seealso cref="CADemoPost.App.ViewModels.BaseViewModel" />
    public class MainViewModel: BaseViewModel
    {
        /// <summary>
        /// The main window
        /// </summary>
        private MainWindow _MainWindow;
        /// <summary>
        /// Gets or sets the post view models.
        /// </summary>
        /// <value>The post view models.</value>
        public IEnumerable<PostViewModel> PostViewModels { get; set; }
        /// <summary>
        /// Gets or sets the proxy.
        /// </summary>
        /// <value>The proxy.</value>
        public IProxy<PostViewModel, Post> Proxy { get; set; }

        public string SortOrder { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        /// <param name="mainWindow">The main window.</param>
        public MainViewModel(MainWindow mainWindow)
        {
            this._MainWindow = mainWindow;
            PostViewModels = GetData();
            SortOrder = "Descending";
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns>IEnumerable&lt;PostViewModel&gt;.</returns>
        private IEnumerable<PostViewModel> GetData()
        {
            Proxy = new Proxy<PostViewModel, Post>(ConfigurationSettings.AppSettings["Url"]);
            return Proxy.GetAll();
        }

        /// <summary>
        /// Gets the refresh command.
        /// </summary>
        /// <value>The refresh command.</value>
        public ICommand RefreshCommand
        {
            get
            {
                return new DelegateCommand(Refresh);
            }
            set
            {
                
            }
        }

        /// <summary>
        /// Gets the view post command.
        /// </summary>
        /// <value>The view post command.</value>
        public ICommand ViewPostCommand
        {
            get
            {
                return new RelayCommand(ViewPost);
            }
            set
            {
                
            }
        }

        /// <summary>
        /// Refreshes this instance.
        /// </summary>
        private void Refresh()
        {
            if (string.CompareOrdinal(SortOrder, "Ascending") == 0)
            {
                SortOrder = "Descending";
                PostViewModels = GetData().OrderBy(i => i.Id);
            }
            else
            {
                SortOrder = "Ascending";
                PostViewModels = GetData().OrderByDescending(i => i.Id);
            }
            NotifyPropertyChanged("PostViewModels");
        }

        /// <summary>
        /// Views the post.
        /// </summary>
        /// <param name="post">The post.</param>
        private void ViewPost(object post)
        {
            if (post != null)
            {
                ViewPost child = new ViewPost();
                child.DataContext = new ViewPostViewModel(post as PostViewModel);
                child.ShowDialog();
            }
        }
    }
}

