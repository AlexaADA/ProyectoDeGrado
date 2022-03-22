using System.Threading.Tasks;

namespace WebOlayaDigital.Interfaces
{
    public interface ICommentService
    {
        Task<bool> Save(int idPost, int idUser, string comment);
    }
}
