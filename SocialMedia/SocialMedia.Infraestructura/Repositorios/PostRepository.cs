using Microsoft.EntityFrameworkCore;
using SocialMedia.core.Entities;
using SocialMedia.core.Interfaces;
using SocialMedia.Infraestructura.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Infraestructura.Repositorios
{
    public class PostRepository : IPostRepository
    {
        //inyeccion de dependencia en este caso SocialMediaContext
        private readonly SocialMediaContext _context;
        //método constructor
        public PostRepository(SocialMediaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Post>> GetPosts()
        {
            var posts = await _context.Posts.ToListAsync();
            return posts;
        }

        public async Task<Post> GetPost(int id)
        {
            var post = await _context.Posts.FirstOrDefaultAsync(x => x.PostId == id);
            return post;
        }

        public async Task InsertPost(Post post)
        {
             _context.Posts.Add(post);
            await _context.SaveChangesAsync();
        }
    }
}
