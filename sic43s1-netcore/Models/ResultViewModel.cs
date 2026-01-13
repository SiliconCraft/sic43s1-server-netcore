namespace sic43s1_netcore.Models
{
    public class ResultViewModel
    {
        public string temporary { get; set; }
        public string aes128cmac { get; set; }
        public string rollingStatus { get; set; }
        public string tfStatus { get; set; }

        public ResultViewModel(string tf, string cmac, string rlc_status, string tf_status)
        {
            temporary = tf;
            aes128cmac = cmac;
            rollingStatus = rlc_status;
            tfStatus = tf_status;
        }
    }
}
