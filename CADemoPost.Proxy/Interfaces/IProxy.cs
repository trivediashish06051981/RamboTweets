using System.Collections.Generic;

namespace RamboTweets.Proxy.Interfaces
{
    /// <summary>
    /// Interface IProxy
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="L"></typeparam>
    public interface IProxy<T,L> where T: class
        where L:class 
    {
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        IEnumerable<T> GetAll();
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>T.</returns>
        T GetById(int id);
    }
}
