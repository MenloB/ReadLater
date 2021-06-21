using MediatR;
using Microsoft.AspNetCore.Identity;
using Services.Commands.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IMediator _mediator;

        public AuthenticationService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<SignInResult> SignInUser()
        {
            var command = new LoginUserCommand();
            var result = await _mediator.Send(command);
            return result;
        }
    }
}
