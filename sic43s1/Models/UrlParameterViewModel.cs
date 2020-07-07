using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sic43s1.Models
{
    public class UrlParameterViewModel
    {
        public string Uid { get; set; }
        public string Tf { get; set; }
        public string Ts { get; set; }
        public string Sac { get; set; }
        public string Key { get; set; }

        public UrlParameterViewModel(string uid, string tf, string ts, string sac)
        {
            Uid = uid;
            Tf = tf;
            Ts = ts;
            Sac = sac;
            Key = "FFFF" + uid + uid;
        }
    }
}
