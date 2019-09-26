using Learn_Upload.App_LocalResources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learn_Upload.Models
{
    public class ContactForm
    {
        [Display(Name = "Subject", ResourceType = typeof(GlobalRes))]
        [Required(ErrorMessageResourceName = "RequiredForSelect", ErrorMessageResourceType = typeof(GlobalRes))]
        public int Subject { get; set; }
        [Display(Name = "Name", ResourceType = typeof(GlobalRes))]
        [Required(ErrorMessageResourceName = "RequiredForInput", ErrorMessageResourceType = typeof(GlobalRes))]
        public string Name { get; set; }
        [Display(Name = "Email", ResourceType = typeof(GlobalRes))]
        [Required(ErrorMessageResourceName = "RequiredForInput", ErrorMessageResourceType = typeof(GlobalRes))]
        [EmailAddress(ErrorMessageResourceName = "EmailAddress", ErrorMessageResourceType = typeof(GlobalRes))]
        public string Email { get; set; }
        [Display(Name = "Question", ResourceType = typeof(GlobalRes))]
        [Required(ErrorMessageResourceName = "RequiredForInput", ErrorMessageResourceType = typeof(GlobalRes))]
        public string Question { get; set; }
        [Display(Name = "Attachment", ResourceType = typeof(GlobalRes))]
        public HttpPostedFileBase Attachment { get; set; }
    }
}