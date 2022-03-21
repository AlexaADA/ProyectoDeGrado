using System.Collections.Generic;
using System.Threading.Tasks;
using WebOlayaDigital.Models;

namespace WebOlayaDigital.Interfaces
{
    public interface IPostService
    {
        Task<PostResponse> TopPost();
        Task<string> AddPost(Post requestPost);
        Task<DetailResponse> DetailById(int id);
    }
}
