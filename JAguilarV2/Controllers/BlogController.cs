﻿using System;
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

        public IActionResult SSHWithLinux()
        {
            return View("~/Views/Blog/Networking/SSHWithLinux.cshtml");
        }

        public IActionResult CodingCategory()
        {
            return View("~/Views/Blog/Coding/CodingCategory.cshtml");
        }

        public IActionResult PythonBasics()
        {
            return View("~/Views/Blog/Coding/PythonBasics.cshtml");
        }

        public IActionResult LinuxGamingProton()
        {
            return View("~/Views/Blog/Linux/LinuxGamingProton.cshtml");
        }

        public IActionResult PackageManagers()
        {
            return View("~/Views/Blog/Linux/PackageManagers.cshtml");
        }

        public IActionResult ServerRack()
        {
            return View("~/Views/Blog/Hardware/ServerRack.cshtml");
        }

        public IActionResult EthernetPatchPanel()
        {
            return View("~/Views/Blog/Hardware/EthernetPatchPanel.cshtml");
        }

        public IActionResult WiFiOverview()
        {
            return View("~/Views/Blog/Networking/WiFiOverview.cshtml");
        }

        public IActionResult APTAndYUM()
        {
            return View("~/Views/Blog/Linux/APTAndYUM.cshtml");
        }

        public IActionResult NetworkSwitchOverview()
        {
            return View("~/Views/Blog/Hardware/NetworkSwitchOverview.cshtml");
        }

        public IActionResult RAIDLevels()
        {
            return View("~/Views/Blog/Hardware/RAIDLevels.cshtml");
        }

        public IActionResult LinuxFileSystem()
        {
            return View("~/Views/Blog/Linux/LinuxFileSystem.cshtml");
        }
    }
}