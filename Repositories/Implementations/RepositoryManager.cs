using Repositories.Contexts;
using Repositories.Interfaces;

namespace Repositories.Implementations
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly IPostRepository _postRepository;

        public RepositoryManager(RepositoryContext context, IPostRepository postRepository)
        {
            _context = context;
            _postRepository = postRepository;
        }

        public IPostRepository Post => _postRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
