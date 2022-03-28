using System.Threading.Tasks;
using WebOlayaDigital.Models;

namespace WebOlayaDigital.Interfaces
{
    public interface IAdminServices
    {
        Task<Post> CategoriesDropList();
        Task<UserResponse> CrearUser(UserDto userDto);
    }
}
