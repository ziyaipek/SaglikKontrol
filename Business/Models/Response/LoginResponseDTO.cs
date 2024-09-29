using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class LoginResponseDTO
    {
        public string Token { get; set; }
        public string Role { get; set; }
        public DateTime Expiration { get; set; }
    }
}
