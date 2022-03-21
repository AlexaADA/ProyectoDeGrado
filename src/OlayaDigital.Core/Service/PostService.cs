using OlayaDigital.Core.DTOs;
using OlayaDigital.Core.Entities;
using OlayaDigital.Core.Exceptions;
using OlayaDigital.Core.Intarfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OlayaDigital.Core.Service
{
    public class PostService : IPostService
    {

        private readonly IUnitOfWork _unitOfWork;
        public PostService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Post> GetPosts()
        {
            #region "De interés"
            //var _post = Enumerable.Range(1, 10).Select(x => new IdPost
            //{
            //    Id = x,
            //    Tittle = $"Tittle {x}",
            //    Url = $"Url {x}",
            //    Description = $"Description {x}",
            //    IdCategory =  x * 3,
            //    IdUser = x * 5
            //});

            //Crea una tarea que se completa después de 
            //un número específico de milisegundos.
            //await Task.Delay(10);
            #endregion

            var _post = _unitOfWork.PostRepository.GetAll();
            return _post;
        }

        public IEnumerable<Post> GetPostWithAudiMedia()
        {
            return _unitOfWork.PostRepository.GetPostWithAudiMedia();
        }

        public async Task<Post> GetById(int id) => await _unitOfWork.PostRepository.GetById(id);


        public async Task InsertPost(Post post)
        {
            Audit audit = new Audit()
            {
                DateCreate = DateTime.UtcNow,
                DateUpdate = DateTime.UtcNow,
            };

            await _unitOfWork.AuditRepository.Add(audit);
            await _unitOfWork.PostRepository.Add(post);
            await _unitOfWork.saveChangesAsync();
        }
        public async Task<bool> UpdatePost(Post post)
        {
            _unitOfWork.PostRepository.Update(post);
            await _unitOfWork.saveChangesAsync();
            return true;
        }

        public async Task<bool> DeletePost(int id)
        {
            await _unitOfWork.PostRepository.Delete(id);
            await _unitOfWork.saveChangesAsync();
            return true;
        }

        public async Task<UserwithAllTheInformationDto> UserwithAllTheInformation(int id)
        {
            Post post = await _unitOfWork.PostRepository.GetById(id);
            Category category = await _unitOfWork.CategoryRepository.GetById((int)post.IdCategory);
            User user = await _unitOfWork.UserRepository.GetById((int)post.IdUser);
            IEnumerable<Media> media = _unitOfWork.MediaRepository.GetAll();
            IEnumerable<Comment> comments = _unitOfWork.CommentRepository.GetAll();

            UserwithAllTheInformationDto userwithAllTheInformationDto = new UserwithAllTheInformationDto();
            userwithAllTheInformationDto.IdPost = post.Id;
            userwithAllTheInformationDto.Tittle = post.Tittle;
            userwithAllTheInformationDto.Url = post.Url;
            userwithAllTheInformationDto.Description = post.Description;

            userwithAllTheInformationDto.IdCategory = category.Id;
            userwithAllTheInformationDto.NameCategory = category.Name;
            userwithAllTheInformationDto.UrlCategory = category.Url;
            userwithAllTheInformationDto.Media = media.Where(x => x.IdPost == post.Id).Select( select => new MediaDto()
            {
                Cover = select.Cover,
                Extension = select.Extension,
                FileName = select.FileName,
                FileSize = select.FileSize,
                Route = select.Route,
                Id = select.Id,
                IdPost = select.IdPost
            }) .ToList();

            userwithAllTheInformationDto.Comments = comments.Where(x => x.IdPost == post.Id).Select(select => new CommentDto()
            {
                Id = select.Id,
                Description = select.Description,
                IdPost = select.IdPost,
                IdUser = user.Id
            }).ToList();

            userwithAllTheInformationDto.IdUser = user.Id;
            userwithAllTheInformationDto.Name = user.Name;
            userwithAllTheInformationDto.Phone = user.Phone;
            userwithAllTheInformationDto.Email = user.Email;

            return userwithAllTheInformationDto;
        }


    }
}
