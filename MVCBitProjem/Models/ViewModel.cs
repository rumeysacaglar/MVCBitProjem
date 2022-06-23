using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCBitProjem.Models;

namespace MVCBitProjem.Models
{
    public class ViewModel
    {
        public List<Heading> Headings { get; set; }
        public List<Content> Contents { get; set; }
        public List<Writer> Writers { get; set; }
        public List<Message> Messages { get; set; }
        public int HeadingCount { get; set; }
        public int ContentCount { get; set; }
        public int WriterCount { get; set; }
        public int MessageCount { get; set; }


        public string UserName { get; set; }
        public string UserMail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime ContactDate { get; set; }
    }
}