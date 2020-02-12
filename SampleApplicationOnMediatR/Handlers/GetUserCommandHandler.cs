using MediatR;
using SampleApplicationOnMediatR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SampleApplicationOnMediatR.Handlers
{
    public class GetUserCommandHandler : IRequestHandler<GetUserCommand, User>
    {
        public Task<User> Handle(GetUserCommand request, CancellationToken cancellationToken)
        {
            User user = new User
            {
                Email = "mattavidhyasagarreddy@gmail.com",
                Identifier = "some-guid"
            };

            return Task.FromResult(user);
        }
    }
}
