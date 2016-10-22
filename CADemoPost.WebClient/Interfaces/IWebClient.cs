using System.Collections.Generic;

namespace RamboTweets.WebClient.Interfaces
{
    /// <summary>
    /// Interface IWebClient
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IWebClient<T> where T: class
    {
        /// <summary>
        /// Gets the posts.
        /// </summary>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        IEnumerable<T> GetPosts();
    }
}
