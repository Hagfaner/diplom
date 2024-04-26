using Microsoft.AspNetCore.Identity;

namespace diplom
{
    public class AppErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError DuplicateUserName(string userName)
        {
            var error = base.DuplicateUserName(userName);
            error.Description = "Этот логин занят. Используйте другой.";
            return error;
        }
        public override IdentityError PasswordRequiresDigit()
        {
            var error = base.PasswordRequiresDigit();
            error.Description = "В пароле нет цифр";
            return error;
        }
        public override IdentityError PasswordRequiresLower()
        {
            var error = base.PasswordRequiresLower();
            error.Description = "В пароле нет букв в нижнем регистре a-z";
            return error;
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            var error = base.PasswordRequiresNonAlphanumeric();
            error.Description = "В пароле нет специальных символов";
            return error;
        }
        public override IdentityError PasswordRequiresUpper()
        {
            var error = base.PasswordRequiresUpper();
            error.Description = "В пароле нет букв в верхнем регистре A-Z";
            return error;
        }
    }
}
