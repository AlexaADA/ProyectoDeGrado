using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OlayaDigital.Core.DTOs;
using OlayaDigital.Core.Entities;
using OlayaDigital.Core.Intarfaces;
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
        private readonly IUnitOfWork _unitOfWork;

        public PostController(IPostService postService,
            IMapper mapper, IUnitOfWork unitOfWork)
        {
            _postService = postService;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }


        //[HttpGet]
        //public async Task<IActionResult> GetPosts()
        //{
        //    #region "De Interés"
        //    //Forma de traer una clase sin hacer una inyección de dependencia
        //    //var _posts = new PostRepository().GetPosts();

        //    //Mapeo Manuel
        //    //var _postDto = _post.Select(x => new PostDto
        //    //{
        //    //    Tittle = x.Tittle,
        //    //    Description = x.Description,
        //    //    Url = x.Url,
        //    //    IdCategory = x.IdCategory,
        //    //    IdUser = x.IdUser
        //    //});
        //    #endregion

        //    var _post = _postService.GetPosts();

        //    //Mapeo con AutoMapper
        //    var _postMapper = _mapper.Map<IEnumerable<PostDto>>(_post);

        //    //Estructurar el response del api
        //    var _response = new ApiResponse<IEnumerable<PostDto>>(_postMapper)
        //    {
        //        Msg = "Resultado de la busqueda"
        //    };
        //    return Ok(_response);
        //}

        [HttpGet]
        public async Task<IActionResult> GetPostWithAudiMedia()
        {
            var _getPostWithAudiMedia = _postService.GetPostWithAudiMedia();

            List<GetPostWithTableRelation> _getPostWithTableRelationList = 
                new List<GetPostWithTableRelation>();

            if (_getPostWithAudiMedia != null)
            {

                foreach (var item in _getPostWithAudiMedia)
                {
                    GetPostWithTableRelation _getPostWithTableRelation = new GetPostWithTableRelation();
                    _getPostWithTableRelation.Id = item.Id;
                    _getPostWithTableRelation.Tittle = item.Tittle;
                    _getPostWithTableRelation.Url = item.Url;
                    _getPostWithTableRelation.Description = item.Description;
                    _getPostWithTableRelation.IdCategory = item.IdCategory;
                    _getPostWithTableRelation.IdUser = item.IdUser;

                    _getPostWithTableRelation.Comments = _mapper.Map<List<CommentDto>>(item.Coments);
                    _getPostWithTableRelation.AuditDto = _mapper.Map<List<AuditDto>>(item.Audits);

                    var mediaUnitOfWork = _unitOfWork.MediaRepository.GetAll()
                        .Where(x => x.IdPost != null && x.IdPost == item.Id && x.Cover == true);
                    _getPostWithTableRelation.MediaDto = _mapper.Map<List<MediaDto>>(mediaUnitOfWork);

                    _getPostWithTableRelationList.Add(_getPostWithTableRelation);
                }
            }

            //Estructurar el response del api
            var _response = new ApiResponse<IEnumerable
                <GetPostWithTableRelation>>(_getPostWithTableRelationList)
            {
                Msg = "Resultado de la busqueda"
            };

            await Task.CompletedTask;
            return Ok(_response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPost(int id)
        {
            UserwithAllTheInformationDto postDto = await _postService.UserwithAllTheInformation(id);

            //Estructurar el response del api
            ApiResponse<UserwithAllTheInformationDto> _response = new ApiResponse<UserwithAllTheInformationDto>(postDto);
            _response.Msg = "Detalle de la informacion";
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
