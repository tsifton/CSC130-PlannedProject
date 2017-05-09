using PlannedWaterfall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlannedWaterfall.Controllers
{
    
    public class HomeController : Controller
    {
        public static List<string> FeatureName = new List<string>();
        public static List<int> LowEstimate     = new List<int>()  ;
        public static List<int> HighEstimate    = new List<int>()  ;
        public static List<int> Expected        = new List<int>()  ;
        public static List<int> Actual          = new List<int>()  ;
        public ActionResult ExcelPage()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ToExcel()
        {
            ToExcelModel tempModel = new ToExcelModel();
            tempModel.FeatureName = FeatureName;
            tempModel.LowEstimate = LowEstimate;
            tempModel.HighEstimate = HighEstimate;
            tempModel.Expected = Expected;
            tempModel.Actual = Actual;
            return View(tempModel);
        }

        [HttpPost]
        public ActionResult ToExcel(Models.ExcelModel model)
        {
            FeatureName.Add(model.FeatureName);
            LowEstimate.Add(model.LowEstimate);
            HighEstimate.Add(model.HighEstimate);
            Expected.Add(model.Expected);
            Actual.Add(model.Actual);

            ToExcelModel tempModel = new ToExcelModel();
            tempModel.FeatureName = FeatureName;
            tempModel.LowEstimate = LowEstimate;
            tempModel.HighEstimate = HighEstimate;
            tempModel.Expected = Expected;
            tempModel.Actual = Actual;
            return View(tempModel);
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}