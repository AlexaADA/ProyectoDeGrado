﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OlayaDigital.Core.DTOs;
using OlayaDigital.Core.Entities;
using OlayaDigital.Core.Intarfaces;
using OlayaDigital.Infrastructure.Repositories;
using OlayaDigitalAPI.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlayaDigitalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        private readonly IMapper _mapper;
        //private readonly IRepository _postRepository;

        public PostController(IPostService postService,
            IMapper mapper)
        {
            _postService = postService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetPosts()
        {
            #region "De Interés"
            //Forma de traer una clase sin hacer una inyección de dependencia
            //var _posts = new PostRepository().GetPosts();

            //Mapeo Manuel
            //var _postDto = _post.Select(x => new PostDto
            //{
            //    Tittle = x.Tittle,
            //    Description = x.Description,
            //    Url = x.Url,
            //    IdCategory = x.IdCategory,
            //    IdUser = x.IdUser
            //});
            #endregion

            var _post = _postService.GetPosts();

            //Mapeo con AutoMapper
            var _postMapper = _mapper.Map<IEnumerable<PostDto>>(_post);

            //Estructurar el response del api
            var _response = new ApiResponse<IEnumerable<PostDto>>(_postMapper) {
                Msg = "Resultado de la busqueda"
            };
            return Ok(_response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPost(int id)
        {
            var post = await _postService.GetById(id);
            var postDto = _mapper.Map<PostDto>(post);

            //Estructurar el response del api
            var _response = new ApiResponse<PostDto>(postDto);
            return Ok(_response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(PostDto postDto)
        {
            var post = _mapper.Map<Post>(postDto);
            await _postService.InsertPost(post);
            postDto = _mapper.Map<PostDto>(post);

            //Estructurar el response del api
            var _response = new ApiResponse<PostDto>(postDto);
            return Ok(_response);
        }



        //Ejemplo para actualizar una entidad https: //localhost:44389/api/post?id=1
        [HttpPut]
        public async Task<IActionResult> Put(int id, PostDto postDto)
        {
            var post = _mapper.Map<Post>(postDto);
            post.Id = id;
            var _result = await _postService.UpdatePost(post);

            //Estructurar el response del api
            var _response = new ApiResponse<bool>(_result);
            return Ok(_response);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var _result = await _postService.DeletePost(id);

            //Estructurar el response del api
            var _response = new ApiResponse<bool>(_result);
            return Ok(_response);
        }

    }
}