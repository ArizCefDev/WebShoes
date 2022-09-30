using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class SocialMedia
    {
        public int ID { get; set; }
        public string FacebookURL { get; set; }
        public string TwitterURL { get; set; }
        public string InstagramURL { get; set; }
        public string WhatsappURL { get; set; }
        public string TelegramURL { get; set; }
        public string GithubURL { get; set; }
        public bool Status { get; set; }
    }
}
