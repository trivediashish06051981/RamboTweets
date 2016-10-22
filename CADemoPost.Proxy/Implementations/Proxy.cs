using AutoMapper;
using RamboTweets.Proxy.Interfaces;
using RamboTweets.WebClient.Implementations;
using RamboTweets.WebClient.Interfaces;
using System;
using System.Collections.Generic;

namespace RamboTweets.Proxy
{
    /// <summary>
    /// Class Proxy.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="L"></typeparam>
    /// <seealso cref="RamboTweets.Proxy.Interfaces.IProxy{T, L}" />
    public class Proxy<T,L> : IProxy<T,L> where T : class
        where L : class 
    {
        /// <summary>
        /// Gets or sets the proxy URL.
        /// </summary>
        /// <value>The proxy URL.</value>
        public string ProxyUrl { get; set; }
        /// <summary>
        /// Gets or sets the web client.
        /// </summary>
        /// <value>The web client.</value>
        public IWebClient<L> WebClient { get; set; }
        /// <summary>
        /// Gets or sets the dto list.
        /// </summary>
        /// <value>The dto list.</value>
        public IEnumerable<L> DTOList { get; set; }
        /// <summary>
        /// Gets or sets the return list.
        /// </summary>
        /// <value>The return list.</value>
        public IEnumerable<T> ReturnList { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Proxy{T, L}"/> class.
        /// </summary>
        /// <param name="url">The URL.</param>
        public Proxy(string url)
        {
            ProxyUrl = url;
            WebClient = new WebClient<L>(this.ProxyUrl);
            DTOList = new List<L>();
            ReturnList = new List<T>();
        }
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        public IEnumerable<T> GetAll()
        {
            DTOList = WebClient.GetPosts();
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<L, T>();
            });
            ReturnList = Mapper.Map<List<T>>(DTOList);
            return ReturnList;
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>T.</returns>
        public T GetById(int id)
        {
            return Activator.CreateInstance<T>();
        }
        
    }
}
