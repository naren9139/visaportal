using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Services.Client;
using gov.data.util;
using VisaPortal.ServiceDOLAgency;
using VisaPortal.ServiceDOLSummerJobs;

namespace VisaPortal.Controllers
{
    public class VisitorVisaController : Controller
    {
        // GET: VisitorVisa
        public ActionResult Index()
        {
            AgencyEntities entity = new AgencyEntities(new Uri("http://api.dol.gov/V1/DOLAgency"));
            entity.SendingRequest += new EventHandler<SendingRequestEventArgs>(GOVDataUtil.service_SendingRequest);

            return View(entity.Agencies.ToList<Agencies>());

            //ViewBag.Message = "Welcome to ASP.NET MVC!";
            //SummerJobsCall proxy = new SummerJobsCall(new Uri("http://api.dol.gov/V1/SummerJobs"));
            //proxy.SendingRequest += new EventHandler<System.Data.Services.Client.SendingRequestEventArgs>(GOVDataUtil.service_SendingRequest);

            //string jsonData = proxy.Execute<string>(
            //    new Uri("getJobsListing?format=json&region=&locality=&zip=&employmentType=%27Any%27SkipCount=1&query=%27Nurse%27", UriKind.Relative)
            //    ).FirstOrDefault().Replace("\\n", "").Replace("\\\"", "\"").Trim('\"');

        }
    }
}