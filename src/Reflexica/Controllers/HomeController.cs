using System.Collections;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace Reflexica.Controllers
{
    public class HomeController : Controller
    {
      private const string TEMP_PATH = @"D:\Gaurav";
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        //public ActionResult About()
        //{
        //    return View();
        //}

          [HttpPost]
        public ActionResult UploadFiles(IEnumerable files)
        {
            foreach (HttpPostedFileBase file in files)
            {
                string filePath = Path.Combine(TEMP_PATH, file.FileName);
                System.IO.File.WriteAllBytes(filePath, ReadData(file.InputStream));
            }

            return Json("All files have been successfully stored.");
        }

        private byte[] ReadData(Stream stream)
        {
            byte[] buffer = new byte[16 * 1024];

            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }

                return ms.ToArray();
            }
        }
    }
}