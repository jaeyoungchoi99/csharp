using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaeyoung
{
    internal class UserDto
    {
        public string u_id { get; set; }
        public string u_name { get; set; }
        public string u_pw { get; set; }
        public string u_birth { get; set;  }
        public string u_phone { get; set; }
        public DateTime u_createdate { get; set; }
    }
}
