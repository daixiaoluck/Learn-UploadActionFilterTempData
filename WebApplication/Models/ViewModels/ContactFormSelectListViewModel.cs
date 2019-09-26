using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learn_Upload.Models.ViewModels
{
    public class ContactFormSelectListViewModel
    {
        public ContactForm contactForm { get; set; }
        public SelectList selectItems { get; set; }
    }
}