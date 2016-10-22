using RamboTweets.DTO.Models;
using RamboTweets.WebClient.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CADemoPost.WebClientTests1;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using RamboTweets.Proxy.Interfaces;
using RamboTweets.VM;

namespace RamboTweets.WebClient.Implementations.Tests
{
    [TestClass()]
    public class WebClientTests
    {
        [TestMethod()]
        public void GetPostsTest()
        {
            IWebClient<Post> webClient = RamboContainer.GetContainer().Resolve<IWebClient<Post>>(
                new ResolverOverride[]
        {
            new ParameterOverride("url", @"http://jsonplaceholder.typicode.com/posts")
        });
            var list = webClient.GetPosts();

            Assert.IsNotNull(list);
            Assert.IsInstanceOfType(list, typeof(IEnumerable<Post>));
        }

        [TestMethod()]
        public void GetPostsTestProxy()
        {
            IProxy<Post, PostViewModel> proxyClient = RamboContainer.GetContainer().Resolve<IProxy<Post, PostViewModel>>(
                new ResolverOverride[]
        {
            new ParameterOverride("url", @"http://jsonplaceholder.typicode.com/posts")
        });
            var list = proxyClient.GetAll();

            Assert.IsNotNull(list);
            Assert.IsInstanceOfType(list, typeof(IEnumerable<PostViewModel>));
        }
    }
}
