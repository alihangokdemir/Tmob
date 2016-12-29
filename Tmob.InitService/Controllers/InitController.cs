using InitService.Models;
using Newtonsoft.Json;
using ServiceStack;
using System;
using System.Web.Http;

namespace InitService.Controllers
{
    public class InitController : ApiController
    {
        public const string versionConstant = "1.1.3";
        
        public InitModels Get(string versionOfApp)
        {
            bool isGreater = versionCheck(versionOfApp);

            InitModels model = new InitModels();
            model.needsUpdate = isGreater;

            return model;
        }

        public bool versionCheck(string valueToCheck)
        {
            string v1 = versionConstant;
            string v2 = valueToCheck;

            var constantVersion = new Version(v1);
            var appVersion = new Version(v2);

            var result = constantVersion.CompareTo(appVersion);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        // POST: api/Init
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Init/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Init/5
        public void Delete(int id)
        {
        }

    }
}
