using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;
using sic43s1.Models;

namespace sic43s1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string U, string TF, string TS, string SAC, string RLC)
        {
            if ((U != null) && (TF != null) && (TS != null) && ((RLC != null) || (SAC != null)))
            {
                byte[] keyBytes128 = Hex.Decode("FFFF" + U + U);
                byte[] tfByte = Encoding.Default.GetBytes(TF);
                string tfHex = BitConverter.ToString(tfByte).Replace("-", "");
                int tsDecValue = Convert.ToInt32(TS, 16);
                string ts = tsDecValue.ToString();

                byte[] plaintext = Hex.Decode(TS + U + tfHex);

                IMac mac = MacUtilities.GetMac("AESCMAC");
                KeyParameter key = new KeyParameter(keyBytes128);
                mac.Init(key);
                mac.BlockUpdate(plaintext, 0, plaintext.Length);
                byte[] cmac = MacUtilities.DoFinal(mac);

                string rlcStatus;
                if (RLC != null)
                {
                    ViewBag.UrlParameterViewModel = new UrlParameterViewModel(U, TF, ts, RLC);

                    if (RLC == BitConverter.ToString(cmac).Replace("-", ""))
                    {
                        rlcStatus = "Corrected";
                    }
                    else
                    {
                        rlcStatus = "Incorrected";
                    }
                }
                else
                {
                    ViewBag.UrlParameterViewModel = new UrlParameterViewModel(U, TF, ts, SAC);

                    if (SAC == BitConverter.ToString(cmac).Replace("-", ""))
                    {
                        rlcStatus = "Corrected";
                    }
                    else
                    {
                        rlcStatus = "Incorrected";
                    }
                }

                string tamperStatus;
                if (TF == Encoding.UTF8.GetString(tfByte))
                {
                    tamperStatus = "Corrected";
                }
                else
                {
                    tamperStatus = "Incorrected";
                }

                ViewBag.ResultViewModel = new ResultViewModel(
                    Encoding.UTF8.GetString(tfByte),
                    BitConverter.ToString(cmac).Replace("-", ""),
                    rlcStatus,
                    tamperStatus
                    );

                return View();
            }
            else
            {
                return Error();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
