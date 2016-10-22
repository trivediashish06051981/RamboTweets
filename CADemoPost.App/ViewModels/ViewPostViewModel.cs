using RamboTweets.VM;
using Newtonsoft.Json;

namespace RamboTweets.App.ViewModels
{
    /// <summary>
    /// Class ViewPostViewModel.
    /// </summary>
    /// <seealso cref="RamboTweets.App.ViewModels.BaseViewModel" />
    public class ViewPostViewModel:BaseViewModel
    {
        /// <summary>
        /// Gets or sets the post view model.
        /// </summary>
        /// <value>The post view model.</value>
        public PostViewModel PostViewModel { get; set; }

        public string Json { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewPostViewModel"/> class.
        /// </summary>
        /// <param name="postViewModel">The post view model.</param>
        public ViewPostViewModel(PostViewModel postViewModel)
        {
            this.PostViewModel = postViewModel;
            Json = JsonConvert.SerializeObject(postViewModel);
        }
    }
}
