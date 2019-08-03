using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IO;
using WebApplication1.Helpers;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            Person a = Serialize();

            return JsonConvert.SerializeObject(a);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        private Person Serialize()
        {
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlInputData = string.Empty;
            string xmlOutputData = string.Empty;



            path = Directory.GetCurrentDirectory() + @"\Data\XMLFile.xml";
            xmlInputData = ser.Teste(path);

            Person pessoa = ser.Deserialize<Person>(xmlInputData);
            //xmlOutputData = ser.Serialize<Pessoa>(pessoa);

            return pessoa;
        }
    }
}
