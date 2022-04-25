using System.Threading.Tasks;
using WebOlayaDigital.Models;

namespace WebOlayaDigital.Interfaces
{
    public interface IMediaServices
    {
        Task<bool> Save(MediaDto info);
        Task Delete(int id);
    }
}
