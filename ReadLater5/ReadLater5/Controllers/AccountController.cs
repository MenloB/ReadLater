using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Threading.Tasks;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace ReadLater5.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthenticationService _service;

        public AccountController(IAuthenticationService service)
        {
            _service = service;
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Callback method from Accounts controller for managing external logins from providers such as Microsoft, Google, Facebook etc.
        /// </summary>
        /// <param name="callbackUrl">URL for redirecting after successful logging in of a user</param>
        /// <param name="remoteError">Remote</param>
        /// <returns></returns>
        [AllowAnonymous]
        public async Task<IActionResult> ExternalLoginCallback(string callbackUrl = null, string remoteError = null)
        {
            SignInResult signInResult = new SignInResult();
            try
            {
                signInResult = await _service.SignInUser();
            }
            catch(Exception)
            {
                throw;
            }

            if (signInResult.Succeeded)
                return LocalRedirect(callbackUrl);
            else
                return LocalRedirect("/");

        }
    }
}
