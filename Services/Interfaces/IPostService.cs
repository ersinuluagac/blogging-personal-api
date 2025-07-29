using Entities.DTOs;
using Entities.Models;

namespace Services.Interfaces
{
    public interface IPostService
    {
        IEnumerable<Post> GetAllPosts();
        Post GetPostById(int id);
        Post CreatePost(PostDto post);
        Post UpdatePost(int id, PostDto post);
        void DeletePost(int postId);
    }
}
