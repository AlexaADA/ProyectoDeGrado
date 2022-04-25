using System.Collections.Generic;

namespace WebOlayaDigital.Models
{

    public class UserResponse
    {
        public string Msg { get; set; }
        public UserDto Data { get; set; }
    }

    public class GetUserAllResponse
    {
        public string Msg { get; set; }
        public List<UserDto> Data { get; set; }
    }
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
