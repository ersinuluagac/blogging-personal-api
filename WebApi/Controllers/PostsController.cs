using Entities.DTOs;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace WebApi.Controllers
{
    [Route("api/posts")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public PostsController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public IActionResult GetAllPosts()
        {
            var posts = _serviceManager.PostService.GetAllPosts();
            return Ok(posts);
        }
        [HttpGet("{id}")]
        public IActionResult GetPost([FromRoute(Name = "id")] int id)
        {
            var post = _serviceManager.PostService.GetPostById(id);
            return Ok(post);
        }
        [HttpPost]
        public IActionResult CreatePost([FromBody] PostDto postDto)
        {
            var post = _serviceManager.PostService.CreatePost(postDto);
            return Ok(post);
        }
        [HttpPut("{id}")]
        public IActionResult UpdatePost([FromRoute(Name = "id")] int id, [FromBody] PostDto postDto)
        {
            var post = _serviceManager.PostService.UpdatePost(id, postDto);
            return Ok(post);
        }
        [HttpDelete("{id}")]
        public IActionResult DeletePost([FromRoute(Name = "id")] int id)
        {
            _serviceManager.PostService.DeletePost(id);
            return NoContent();
        }
    }
}
