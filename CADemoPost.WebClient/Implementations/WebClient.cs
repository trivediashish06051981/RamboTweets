using RamboTweets.WebClient.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace RamboTweets.WebClient.Implementations
{
    /// <summary>
    /// Class WebClient.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="RamboTweets.WebClient.Interfaces.IWebClient{T}" />
    public class WebClient<T> : IWebClient<T> where T: class
    {
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get; set; }
        /// <summary>
        /// Gets or sets the HTTP client.
        /// </summary>
        /// <value>The HTTP client.</value>
        public HttpClient HttpClient { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebClient{T}"/> class.
        /// </summary>
        /// <param name="url">The URL.</param>
        public WebClient(string url)
        {
            this.Url = url;
            this.HttpClient = new HttpClient();
            this.HttpClient.BaseAddress = new Uri(this.Url);
        }

        /// <summary>
        /// Gets the posts.
        /// </summary>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        public IEnumerable<T> GetPosts()
        {
            try
            {
                HttpResponseMessage response = HttpClient.GetAsync(Url).Result;
                return response.Content.ReadAsAsync<IEnumerable<T>>().Result;
            }
            catch (AggregateException exception)
            {
                //Logging to Database if any
                //Used catch if we have any network issues
                return new List<T>();
            }
        } 
    }
}
