using ErenBankMVC.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErenBankMVC.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Bu Alan Boş Geçilemez!");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Bu alana minimun 2 karakter girilebilir.");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Bu alana maksimum 50 karakter girilebilir.");

            RuleFor(x => x.Surname).NotEmpty().WithMessage("Bu Alan Boş Geçilemez!");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Bu alana minimun 2 karakter girilebilir.");
            RuleFor(x => x.Surname).MaximumLength(50).WithMessage("Bu alana maksimum 50 karakter girilebilir.");

            RuleFor(x => x.Username).NotEmpty().WithMessage("Bu Alan Boş Geçilemez!");
            RuleFor(x => x.Username).MinimumLength(2).WithMessage("Bu alana minimun 2 karakter girilebilir.");
            RuleFor(x => x.Username).MaximumLength(50).WithMessage("Bu alana maksimum 50 karakter girilebilir.");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Bu Alan Boş Geçilemez!");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz.");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Bu Alan Boş Geçilemez!");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Bu Alan Boş Geçilemez!");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Girilen parolalar birbirleriyle eşleşmiyor. Lütfen Tekrar Deneyin!");
        }
    }
}
