using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBitProjem.Models
{
    public class ContactClass
    {
        [Required(ErrorMessage ="İsim girmek zorunludur.")]
        public string WriterName { get; set; }
        public string WriterMail { get; set; }
        [Required(ErrorMessage = "Konu girmek zorunludur.")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Mesaj girmek zorunludur.")]
        public string Message { get; set; }
        public DateTime ContactDate { get; set; }
    }
}