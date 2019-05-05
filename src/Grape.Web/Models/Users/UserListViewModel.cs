using System.Collections.Generic;
using Grape.Roles.Dto;
using Grape.Users.Dto;

namespace Grape.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}