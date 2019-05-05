using Abp.Authorization;
using Grape.Authorization.Roles;
using Grape.Authorization.Users;

namespace Grape.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
