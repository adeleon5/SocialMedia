using AutoMapper;
using SocialMedia.core.DTOs;
using SocialMedia.core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMedia.Infraestructura.Mappings
{
    public class AutomapperProfile : Profile
    {

        public AutomapperProfile()
        {
            CreateMap<Post, PostDto>();
            CreateMap<PostDto, Post>();
        }   
   }
}
    