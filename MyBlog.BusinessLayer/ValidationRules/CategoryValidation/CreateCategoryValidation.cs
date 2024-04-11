using FluentValidation;
using MyBlog.EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.BusinessLayer.ValidationRules.CategoryValidation
{
    public class CreateCategoryValidation : AbstractValidator<Category>
    {
        public CreateCategoryValidation()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adı boş olamaz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter giriniz");
            RuleFor(x => x.CategoryName).MaximumLength(30).WithMessage("Lütfn en fazla 30 karakter giriniz");

        }
    }
}
