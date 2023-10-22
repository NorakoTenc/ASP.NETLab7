using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;

namespace ASP.NETLab7.Controllers
{
    [Route("[controller]/[action]")]
    public class FileController : Controller
    {
        [HttpGet]
        public IActionResult DownloadFile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DownloadFile(string firstName, string lastName, string fileName)
        {
            var content = $"Name: {firstName}\nSurname: {lastName}";
            var byteArray = Encoding.UTF8.GetBytes(content);
            var stream = new MemoryStream(byteArray);

            return File(stream, "text/plain", $"{fileName}.txt");
        }
    }
}
