using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules_FluentValidation
{
    public class ContactValidatorr:AbstractValidator<Contact>
    {
        public ContactValidatorr() 
        {
            RuleFor(x=>x.ContactUserMail).NotEmpty().WithMessage("Mail Adresini Boş Geçemezsiniz");
            RuleFor(x => x.ContactSubject).NotEmpty().WithMessage("Konuyu Boş Geçemezsiniz");
            RuleFor(x => x.ContactUserName).NotEmpty().WithMessage("Kullanıcı Adını Boş Geçemezsiniz");
            RuleFor(x => x.ContactSubject).MinimumLength(3).WithMessage("En Az 3 Karakter Girişi Yapınız");
            RuleFor(x => x.ContactUserName).MinimumLength(3).WithMessage("En Az 3 Karakter Girişi Yapınız");
            RuleFor(x => x.ContactSubject).MaximumLength(50).WithMessage("Lütfen 50 Karakterden Fazla Giriş Yapmayınız.");


        }

    }
}
