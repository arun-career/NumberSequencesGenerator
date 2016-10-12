using Generator.Business;
using Generator.Web.Models;
using System.Text;
using System.Web.Mvc;

namespace Generator.Web.Controllers
{
    public class SequencesController : Controller
    {
        private IGeneratorService Service { get; set; }

        public SequencesController(IGeneratorService service)
        {
            Service = service;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Instructions()
        {
            //ViewBag.Instructions1 = Properties.Settings.Default.Instructions1;
            //ViewBag.Instructions2 = Properties.Settings.Default.Instructions2;
            //ViewBag.Instructions3 = Properties.Settings.Default.Instructions3;
            //ViewBag.Instructions4 = Properties.Settings.Default.Instructions4;

            return View();
        }

        [HttpGet]
        public ActionResult Generate()
        {
            return View(new SequenceModel());
        }

        [HttpPost]
        public ActionResult Generate(SequenceModel o)
        {
            if (o != null)
            {
                var sequences = Service.Execute(o.Number);

                StringBuilder sb = null;

                foreach (var i in sequences.Keys)
                {
                    sb = new StringBuilder();

                    foreach (var x in sequences[i])
                        sb.AppendFormat("{0}, ", x);

                    if (sb.Length > 1)
                    {
                        sb = sb.Remove(sb.Length - 2, 1);
                    }

                    o.Sequences.Add(i, sb.ToString());
                }
            }

            return View(o);
        }
    }
}