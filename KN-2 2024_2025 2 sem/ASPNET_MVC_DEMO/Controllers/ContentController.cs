using ASPNET_MVC_DEMO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace ASPNET_MVC_DEMO.Controllers
{
    public class ContentController : Controller
    {
        IWebHostEnvironment _env;
        public ContentController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [HttpGet]
        public ActionResult ImageUpload()
        {
            return View();
        }


        [Route("ImageUpload")]
        [HttpPost]
        public ActionResult ImageUpload(ContentViewModel model)
        {
            IFormFile file = Request.Form.Files["ImageData"];

            //check if file is selected
            if (file == null || file.Length == 0)
            {
                return Content("file not selected");
            }

            //write code to save image to local folder on server
            string path = _env.WebRootPath + "\\assets\\img\\" + file.FileName;

            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fs);
            }

            return RedirectToAction("ImagesView");
        }


        public ActionResult ImagesView()
        {
            var dir = new DirectoryInfo(_env.WebRootPath + "\\assets\\img\\");
            var files = dir.GetFiles().Select(x => $"\\assets\\img\\{x.Name}").ToList();
            return View(files);
        }

        public ActionResult ImageViewById(int id = 0)
        {
            var dir = new DirectoryInfo(_env.WebRootPath + "\\assets\\img\\"); 
            var files = dir.GetFiles();

            FileInfo file = files[id];

            if (id <= files.Count())
            {
                file = files[id];
            } 

            byte[] image = System.IO.File.ReadAllBytes(file.FullName);
            if (image != null)
            {
                var provider = new FileExtensionContentTypeProvider();
                if (!provider.TryGetContentType(file.Name, out var contentType))
                {
                    contentType = "application/octet-stream";
                }

                return File(image, contentType);
            }
            else
            {
                return null;
            }
        }

        public ActionResult Leaflet()
        {
            return View(MapModel.Default);
        }

        [HttpPost]
        public ActionResult Leaflet(MapModel model)
        {
            return View(model);
        }

        public ActionResult CKEditor()
        {
            return View(new ContentViewModel());
        }

        [HttpPost]
        public ActionResult CKEditor(ContentViewModel model)
        {
            //save to database
            return View(model);
        }
    }
}
