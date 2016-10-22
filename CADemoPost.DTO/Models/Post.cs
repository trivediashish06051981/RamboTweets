using System.ComponentModel;

namespace RamboTweets.DTO.Models
{
    /// <summary>
    /// Class Post.
    /// </summary>
    public class Post
    {
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>The user identifier.</value>
        [DisplayName("UserId")]
        public int userId { get; set; }

        public int UserId
        {
            get { return this.userId; }
            set
            {
                
            }
        }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [DisplayName("Id")]
        public int id { get; set; }

        public int Id
        {
            get { return this.id; }
            set
            {
                
            }
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        [DisplayName("Title")]
        public string title { get; set; }

        public string Title
        {
            get { return title; }
            set
            {
                
            }
        }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        /// <value>The body.</value>
        [DisplayName("Body")]
        public string body { get; set; }

        public string Body
        {
            get { return body; }
            set { }
        }
    }
}
