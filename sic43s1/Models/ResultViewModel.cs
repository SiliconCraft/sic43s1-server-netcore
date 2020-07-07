using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sic43s1.Models
{
    public class ResultViewModel
    {
        public string tamper { get; set; }
        public string aes128cmac { get; set; }
        public string rollingStatus { get; set; }
        public string tamperStatus { get; set; }

        public ResultViewModel(string tf, string cmac, string rlc_status, string tf_status)
        {
            tamper = tf;
            aes128cmac = cmac;
            rollingStatus = rlc_status;
            tamperStatus = tf_status;
        }
    }
}
