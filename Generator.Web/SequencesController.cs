using Generator.Business;
using System.Collections.Generic;
using System.Web.Http;

namespace Generator.Web
{
    public class SequencesController : ApiController
    {
        private IGeneratorService Service { get; set; }

        public SequencesController(IGeneratorService service)
        {
            Service = service;
        }

        // GET api/sequences/5
        public Dictionary<string, List<string>> Get(int id)
        {
            return Service.Execute(id);
        }
    }
}