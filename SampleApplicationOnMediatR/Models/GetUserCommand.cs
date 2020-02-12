using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApplicationOnMediatR.Models
{
    public class GetUserCommand : IRequest<User>
    {
        public string Name { get; set; }
    }
}
