﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WebOlayaDigital.Models;

namespace WebOlayaDigital.Interfaces
{
    public interface IPostService
    {
        Task<ResponsePOST> TopPost();
        Task<string> AddPost(Post requestPost);
    }
}
