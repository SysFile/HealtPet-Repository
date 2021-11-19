using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace health.models.settings
{
    public class AppSettings
    {
        public string ConnectionStrings { get; set; }
        public string Secret { get; set; }
        public double ExpiracionJWT { get; set; }
        public string IssuerJWT { get; set; }
        public string AudienceJWT { get; set; }
    }
}
