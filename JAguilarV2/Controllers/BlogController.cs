using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JAguilarV2.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LinuxCategory()
        {
            return View("~/Views/Blog/Linux/LinuxCategory.cshtml");
        }

        public IActionResult LinuxBasicCommands()
        {
            return View("~/Views/Blog/Linux/LinuxBasicCommands.cshtml");
        }

        public IActionResult HardwareCategory()
        {
            return View("~/Views/Blog/Hardware/HardwareCategory.cshtml");
        }

        public IActionResult DesktopInternalHardDriveBuyingGuide()
        {
            return View("~/Views/Blog/Hardware/DesktopInternalHardDriveBuyingGuide.cshtml");
        }

        public IActionResult DesktopInternalSSDBuyingGuide()
        {
            return View("~/Views/Blog/Hardware/DesktopInternalSSDBuyingGuide.cshtml");
        }

        public IActionResult DesktopRAMBuyingGuide()
        {
            return View("~/Views/Blog/Hardware/DesktopRAMBuyingGuide.cshtml");
        }

        public IActionResult DesktopPowerSupplyBuyingGuide()
        {
            return View("~/Views/Blog/Hardware/DesktopPowerSupplyBuyingGuide.cshtml");
        }

        public IActionResult DesktopGamingGraphicsCardBuyingGuide()
        {
            return View("~/Views/Blog/Hardware/DesktopGamingGraphicsCardBuyingGuide.cshtml");
        }

        public IActionResult DesktopMonitorBuyingGuide()
        {
            return View("~/Views/Blog/Hardware/DesktopMonitorBuyingGuide.cshtml");
        }

        public IActionResult DesktopProcessorBuyingGuide()
        {
            return View("~/Views/Blog/Hardware/DesktopProcessorBuyingGuide.cshtml");
        }

        public IActionResult DesktopMotherboardBuyingGuide()
        {
            return View("~/Views/Blog/Hardware/DesktopMotherboardBuyingGuide.cshtml");
        }

        public IActionResult NetworkingCategory()
        {
            return View("~/Views/Blog/Networking/NetworkingCategory.cshtml");
        }

        public IActionResult TCPIPAndOSINetworkingModel()
        {
            return View("~/Views/Blog/Networking/TCPIPAndOSINetworkingModel.cshtml");
        }

        public IActionResult EthernetAndTwistedPairCables()
        {
            return View("~/Views/Blog/Networking/EthernetAndTwistedPairCables.cshtml");
        }

        public IActionResult WideAreaNetworkWAN()
        {
            return View("~/Views/Blog/Networking/WideAreaNetworkWAN.cshtml");
        }

        public IActionResult IPv4()
        {
            return View("~/Views/Blog/Networking/IPv4.cshtml");
        }

        public IActionResult IPv6()
        {
            return View("~/Views/Blog/Networking/IPv6.cshtml");
        }
    }
}