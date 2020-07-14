using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SocialMedia.core.DTOs;
using SocialMedia.core.Entities;
using SocialMedia.core.Interfaces;
using SocialMedia.Infraestructura.Repositorios;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        //inicio de una inyeccion de dependencia, se hace a traves del constructor pasando una interface
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper; 

        public PostController(IPostRepository postRespository, IMapper mapper)
        {
            _postRepository = postRespository;
            _mapper = mapper;
        }

        //devuelve listado
        [HttpGet]
        public async Task<IActionResult> GetPost()
        {
            var posts = await _postRepository.GetPosts();
            var postsDto = posts.Select(x => new PostDto{ 

                PostId = x.PostId,
                Date = x.Date,
                Description = x.Description,
                Image = x.Image,
                UserId = x.UserId
            });
            return Ok(postsDto); //estatus 200
        }

        //devuelve un elemento
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPos(int id)
        {
            var post = await _postRepository.GetPost(id);
            var postDto = new PostDto
            {
                PostId = post.PostId,
                Date = post.Date,
                Description = post.Description,
                Image = post.Image,
                UserId = post.UserId
            };
            return Ok(postDto); //estatus 200
        }

        //Inserta un publicación
        [HttpPost]
        public async Task<IActionResult> InsertPos(PostDto postDto)
        {
            var post = new Post
            {
                Date = postDto.Date,
                Description = postDto.Description,
                Image = postDto.Image,
                UserId = postDto.UserId
            };
            await _postRepository.InsertPost(post);
            return Ok(post); //estatus 200
        }
    }
}
