using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Net;

namespace WeApiApplication.Tests
{
    [TestClass]
    public class MyWebApiTests
    {
        [TestMethod]
        
            public string Get_Request_Response()
            {
                 string Url = "http://localhost:18688/api/values";
                WebRequest req = WebRequest.Create(Url);
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                string Out = sr.ReadToEnd();
                sr.Close();
                return Out;
            }


            // assert
        
    }
}
