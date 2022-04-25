using System.Threading.Tasks;
using WebOlayaDigital.Models;

namespace WebOlayaDigital.Interfaces
{
    public interface IAdminServices
    {
        Task<GetUserAllResponse> getAllUser();
        Task<Post> CategoriesDropList();
        Task<UserResponse> CrearUser(UserDto userDto);
        Task<UserResponse> CrearCategory(Category category);
    }
}
