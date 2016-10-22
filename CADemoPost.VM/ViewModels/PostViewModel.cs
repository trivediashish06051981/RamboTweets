using System;
using RamboTweets.VM.ViewModels;
using  System.Linq;

namespace RamboTweets.VM
{
    /// <summary>
    /// Class PostViewModel.
    /// </summary>
    /// <seealso cref="RamboTweets.VM.ViewModels.BaseViewModel" />
    public class PostViewModel : BaseViewModel
    {
        /// <summary>
        /// The userid
        /// </summary>
        private int userid;
        /// <summary>
        /// The identifier
        /// </summary>
        private int id;
        /// <summary>
        /// The title
        /// </summary>
        private string title;
        /// <summary>
        /// The body
        /// </summary>
        private string body;

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>The user identifier.</value>
        public int UserId
        {
            get { return userid; }
            set
            {
                userid = value;
                NotifyPropertyChanged("UserId");
            }
        }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                NotifyPropertyChanged("Id");
            }
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                NotifyPropertyChanged("Title");
            }
        }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        /// <value>The body.</value>
        public string Body
        {
            get { return body; }
            set
            {
                body = value;
                NotifyPropertyChanged("Body");
            }
        }
    }
}
