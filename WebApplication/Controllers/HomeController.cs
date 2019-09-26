using System.Web.Mvc;
using Library;
using Learn_Upload.Models.ViewModels;
using System;
using System.IO;

namespace Learn_Upload.Controllers
{
    public class HomeController : Controller
    {
        private Repository _repository = new Repository();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult ContactForm()
        {
            SelectList selectItems = new SelectList(_repository.Subjects, "Value", "Text");
            ContactFormSelectListViewModel dataForDisplay = new ContactFormSelectListViewModel
            {
                selectItems = selectItems
            };
            return View(dataForDisplay);
        }

        [HttpPost]
        public ActionResult ContactForm(ContactFormSelectListViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                if(viewModel.contactForm.Attachment != null)
                {
                    string extension = Path.GetExtension(viewModel.contactForm.Attachment.FileName);
                    string fileName = Guid.NewGuid().ToString();
                    // 保存文件要完整路径
                    viewModel.contactForm.Attachment.SaveAs(Path.Combine(Server.MapPath("~/Attachment"), fileName + extension));

                    TempData["Message"] = "Succeed in submitting.";
                }
            }
            viewModel.selectItems = new SelectList(_repository.Subjects, "Value", "Text");
            return View(viewModel);
        }
    }
}