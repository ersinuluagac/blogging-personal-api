using Entities.DTOs;
using Entities.Models;

namespace Services.Interfaces
{
    public interface IPostService
    {
        IEnumerable<Post> GetAllPosts();
        Post GetPostById(int id);
        Post CreatePost(PostDtoForCreation post);
        Post UpdatePost(int id, PostDtoForCreation post);
        void DeletePost(int postId);
    }
}
