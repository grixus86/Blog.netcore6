using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Describers
{
    public class CustomIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresUniqueChars(int uniqueChars)
        {
            return new IdentityError { Code = "PasswordRequiresUniqueChars", Description = $"Least {uniqueChars} must contain different characters." };
        }
        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError { Code = "DublicateEmail", Description = $"This email {email} An account already exists." };
        }
        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError { Code = "DuplicateUserName", Description = $"This email {userName} An account already exists." };
        }
        public override IdentityError DuplicateRoleName(string role)
        {
            return new IdentityError { Code = "DublicateRoleName", Description = $"This role {role} name already exists." };
        }
        public override IdentityError InvalidEmail(string email)
        {
            return new IdentityError { Code = "InvalidEmail", Description = $"Specified email {email} address is invalid." };
        }
        public override IdentityError InvalidRoleName(string role)
        {
            return new IdentityError { Code = "InvalidRoleName", Description = $"specified role {role} name is invalid." };
        }
        public override IdentityError InvalidUserName(string userName)
        {
            return new IdentityError { Code = "InvalidUserName", Description = $"Specified email {userName} address is invalid." };
        }
        public override IdentityError PasswordTooShort(int lenght)
        {
            return new IdentityError { Code = "PasswordTooShort", Description = $"Password is too short ({lenght})." };
        }
        public override IdentityError UserAlreadyInRole(string role)
        {
            return new IdentityError { Code = "UserAlreadyInRole", Description = $"User already has this role {role} sahip." };
        }
        public override IdentityError UserNotInRole(string role)
        {
            return new IdentityError { Code = "UserNotInRole", Description = $"User to this role {role} does not have!" };
        }
        public override IdentityError ConcurrencyFailure()
        {
            return new IdentityError { Code = "ConcurrencyFailture", Description = "Multiple users tried to modify the same data! Changes will be undone!" };
        }
        public override IdentityError LoginAlreadyAssociated()
        {
            return new IdentityError { Code = "LoginAlreadyAssociated", Description = "This session is already associated with an account." };
        }
        public override IdentityError PasswordMismatch()
        {
            return new IdentityError { Code = "PasswordMismatch", Description = "Password information does not match." };
        }
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError { Code = "PasswordRequiresDigit", Description = "The password must contain at least 1 number." };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError { Code = "PasswordRequiresNonAlphanumeric", Description = "Your password must have at least 2 different characters." };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError { Code = "PasswordRequiresUpper", Description = "Your password must contain at least 1 capital letter." };
        }
        public override IdentityError RecoveryCodeRedemptionFailed()
        {
            return new IdentityError { Code = "RecoveryCodeRedemptionFailed", Description = "Account recovery code is invalid!" };
        }
        public override IdentityError UserAlreadyHasPassword()
        {
            return new IdentityError { Code = "UserAlreadyHasPassword", Description = "The user already has a password." };
        }
        public override IdentityError DefaultError()
        {
            return new IdentityError { Code = "DefaultError", Description = "Something went wrong." };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError { Code = "PasswordRequiresLower", Description = "Your password must contain at least 1 lowercase letter." };
        }
        public override IdentityError UserLockoutNotEnabled()
        {
            return new IdentityError { Code = "UserLockoutNotEnabled", Description = "This account is currently locked! Please try again later." };
        }
    }
}
