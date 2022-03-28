using System.Collections.Generic;
using System.Threading.Tasks;
using WebOlayaDigital.Models;

namespace WebOlayaDigital.Interfaces
{
    public interface IPostService
    {
        Task<PostResponse> TopPost();
        Task<Post> AddPost(Post requestPost);
        Task<bool> AddUpdate(Post requestPost);
        Task<DetailResponse> DetailById(int id);
    }
}
