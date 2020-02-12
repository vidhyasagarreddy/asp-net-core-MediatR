using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleApplicationOnMediatR.Models;

namespace SampleApplicationOnMediatR.Controllers
{
    [ApiController, Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator mediator;

        public UserController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public Task<User> Get()
        {
            var command = new GetUserCommand()
            {
                Name = "Vidhya Sagar Reddy"
            };

            return mediator.Send(command);
        }
    }
}
