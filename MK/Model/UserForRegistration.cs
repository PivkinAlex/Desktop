using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MK.Model
{
    public class UserForRegistration
    {
        public string UserName { get; set; } 
        public string Password { get; set; }    
        public string Email { get; set; }
        public IEnumerable <string> Roles { get; set; }
    }
}
