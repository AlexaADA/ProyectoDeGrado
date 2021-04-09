﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlayaDigitalAPI.Response
{
    public class ApiResponse<T>
    {
        public string Msg { get; set; }
        public ApiResponse(T data)
        {
            Data = data;
        }
        public T Data { get; set; } 

    }
}
