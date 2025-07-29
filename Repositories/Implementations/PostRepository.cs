using Entities.Models;
using Repositories.Contexts;
using Repositories.Interfaces;

namespace Repositories.Implementations
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public PostRepository(RepositoryContext context) : base(context)
        {

        }

        public IQueryable<Post> FindAllPosts()
        {
            return FindAll();
        }
        public IQueryable<Post> FindPostById(int id)
        {
            return FindByCondition(post => post.Id.Equals(id));
        }
        public void CreatePost(Post post)
        {
            Create(post);
        }
        public void UpdatePost(Post post)
        {
            Update(post);
        }
        public void DeletePost(Post post)
        {
            Delete(post);
        }
    }
}
