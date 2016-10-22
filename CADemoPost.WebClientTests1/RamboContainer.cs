using Microsoft.Practices.Unity;
using RamboTweets.DTO.Models;
using RamboTweets.Proxy;
using RamboTweets.Proxy.Interfaces;
using RamboTweets.VM;
using RamboTweets.WebClient.Implementations;
using RamboTweets.WebClient.Interfaces;

namespace CADemoPost.WebClientTests1
{
    public static class RamboContainer
    {
        private static UnityContainer Container { get; set; }

        public static UnityContainer GetContainer()
        {
            if(Container == null)
            {
                Container = new UnityContainer();
                Container.RegisterType<IWebClient<Post>, WebClient<Post>>();
                Container.RegisterType<IProxy<Post, PostViewModel>, Proxy<Post, PostViewModel>>();
            }
            return Container;
        }
    }
}
