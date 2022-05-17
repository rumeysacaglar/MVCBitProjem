using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail adresini boş geçemezsiniz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu boş geçemezsiniz!");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adını boş geçemezsiniz!");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karaker girin.");
            RuleFor(x => x.Username).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girin.");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girin.");
        }
    }
}
