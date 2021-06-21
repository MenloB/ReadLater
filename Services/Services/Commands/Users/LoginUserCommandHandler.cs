using Entity.ApplicationUsers;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Commands.Users
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, SignInResult>
    {
        private readonly UserManager<BookmarkingUser> _userManager;
        private readonly SignInManager<BookmarkingUser> _signinManager;

        public LoginUserCommandHandler(UserManager<BookmarkingUser> userManager, SignInManager<BookmarkingUser> signinManager)
        {
            _userManager = userManager;
            _signinManager = signinManager;
        }

        public async Task<SignInResult> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            ExternalLoginInfo info = await _signinManager.GetExternalLoginInfoAsync();

            var SignInResult = await _signinManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, false, false);

            if(SignInResult.Succeeded)
            {
                return SignInResult;
            }
            else
            {
                await CheckIfExistingUser(info);
                return SignInResult;
            }
        }

        private async Task CheckIfExistingUser(ExternalLoginInfo info)
        {
            var email = info.Principal.FindFirstValue(ClaimTypes.Email);

            if(email != null)
            {
                var user = await _userManager.FindByEmailAsync(email);

                await _userManager.AddLoginAsync(user, info);
                await _signinManager.SignInAsync(user, false);
            }
        }
    }
}
