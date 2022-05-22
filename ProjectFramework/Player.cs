using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMayhemContentFramework
{
    [Serializable]
    public class Player
    {
        public string Username { get; set; }
        public string ID { get; set; }

        public string SessionTicket { get; set; }
         

        public string AvatarImage { get; set; }
    }
}
