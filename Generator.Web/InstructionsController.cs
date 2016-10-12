using Generator.Web.Properties;
using System.Web.Http;

namespace Generator.Web
{
    public class InstructionsController : ApiController
    {
        // GET api/instructions
        public string Get()
        {
            return Settings.Default.Instructions;
        }
    }
}