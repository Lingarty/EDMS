using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System.IO;

namespace test.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetReport()
        {
            StiReport report = new StiReport();
            return StiNetCoreDesigner.GetReportResult(this, report);
        }

        public IActionResult CreateReport()
        {
            StiReport report = new StiReport();
            return StiNetCoreDesigner.GetReportResult(this, report);
        }

        public IActionResult DesignerEvent()
        {
            return StiNetCoreDesigner.DesignerEventResult(this);
        }

        public IActionResult SaveReport()
        {
            StiReport report = StiNetCoreDesigner.GetReportObject(this);
            StreamWriter sw = new StreamWriter($"{report.ReportName}.mrt");
            report.Save(sw.BaseStream);
            sw.Close();
            return StiNetCoreDesigner.SaveReportResult(this);
        }
    }
}