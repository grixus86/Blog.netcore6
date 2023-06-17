using FluentValidation;
using libBlog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.FluentValidations
{
    public class UserValidator : AbstractValidator<AppUser>
    {
        public UserValidator()
        {
            RuleFor(x => x.FirstName)
             .NotEmpty()
             .MinimumLength(3)
             .MaximumLength(50)
             .WithName("Name");

            RuleFor(x => x.LastName)
             .NotEmpty()
             .MinimumLength(3)
             .MaximumLength(50)
             .WithName("Last name");

            RuleFor(x => x.PhoneNumber)
             .NotEmpty()
             .MinimumLength(11)
             .WithName("Phone number");
        }
    }
}
