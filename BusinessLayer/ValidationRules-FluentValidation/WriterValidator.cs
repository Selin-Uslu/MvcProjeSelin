using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules_FluentValidation
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar Soyadını Boş Geçemezsiniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkımda Kısmını Boş Geçemezsiniz");
            RuleFor(x => x.WriterSurName).MinimumLength(2).WithMessage("Lütfen En Az 2 Karakter Girişi Yapın");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("Lütfen 50 Karakterden Fazla Değer Girişi Yapmayın");
        }
    }
}
