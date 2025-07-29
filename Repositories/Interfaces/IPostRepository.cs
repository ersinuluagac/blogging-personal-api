using Entities.Models;

namespace Repositories.Interfaces
{
    public interface IPostRepository : IBaseRepository<Post>
    {
        IQueryable<Post> FindAllPosts();
        IQueryable<Post> FindPostById(int id);
        void CreatePost(Post post);
        void UpdatePost(Post post);
        void DeletePost(Post post);
    }
}
