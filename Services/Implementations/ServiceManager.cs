using Repositories.Interfaces;
using Services.Interfaces;

namespace Services.Implementations
{
    public class ServiceManager : IServiceManager
    {
        private readonly IPostService _postService;

        public ServiceManager(IPostService postService)
        {
            _postService = postService;
        }

        public IPostService PostService => _postService;
    }
}
