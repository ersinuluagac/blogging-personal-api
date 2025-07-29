using Entities.DTOs;
using Entities.Models;
using Repositories.Interfaces;
using Services.Interfaces;

namespace Services.Implementations
{
    public class PostService : IPostService
    {
        private readonly IRepositoryManager _manager;

        public PostService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Post> GetAllPosts()
        {
            return _manager.Post.FindAllPosts();
        }
        public Post GetPostById(int id)
        {
            var post = _manager.Post.FindPostById(id).SingleOrDefault();
            if (post is null)
                throw new ArgumentNullException(nameof(post), "Post cannot be null");
            return post;
        }
        public Post CreatePost(PostDto postDto)
        {
            if (postDto is null)
                throw new ArgumentNullException(nameof(postDto), "Post cannot be null");
            var post = new Post
            {
                Title = postDto.Title,
                Content = postDto.Content,
                Category = postDto.Category,
                Tags = postDto.Tags
            };
            _manager.Post.CreatePost(post);
            _manager.Save();
            return post;
        }
        public Post UpdatePost(int id, PostDto postDto)
        {
            var entity = _manager.Post.FindPostById(id).SingleOrDefault();
            if (entity is null)
                throw new ArgumentNullException(nameof(entity), "Post cannot be null");
            entity.Title = postDto.Title;
            entity.Content = postDto.Content;
            entity.Category = postDto.Category;
            entity.Tags = postDto.Tags;
            entity.UpdatedAt = DateTime.UtcNow;
            _manager.Post.UpdatePost(entity);
            _manager.Save();
            return entity;
        }
        public void DeletePost(int id)
        {
            var post = _manager.Post.FindPostById(id).SingleOrDefault();
            if (post is null)
                throw new ArgumentNullException(nameof(post), "Post cannot be null");
            _manager.Post.DeletePost(post);
            _manager.Save();
        }
    }
}
