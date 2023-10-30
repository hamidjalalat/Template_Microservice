using HJMST.Application.Users.Commands;
using HJMST.Application.Users.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace LoggingMicroservice.Api.Controllers
{
    [ApiController]
    [Route(template: "[controller]")]
    public class UsersController : HJMST.Infrastructure.ControllerBase
    {
        public UsersController(IMediator mediator) : base(mediator: mediator)
        {
        }

        #region Post (Create user)
        [HttpPost(template: "/CreateUser")]

        public async Task<IActionResult> CreateUser(CreateUserCommand request)
        {
            var result = await Mediator.Send(request);

            return FluentResult(result: result);
        }
        #endregion /Post (Create user)


        #region Post (Get User)
        [HttpPost(template: "/GetUser")]
        public async Task<IActionResult> GetUser(string username, string password)
        {
            var request =
                new GetByUserNameQuery
                {
                    UserName = username,
                    Password = password,

                };

            var result = await Mediator.Send(request);

            return FluentResult(result: result);
        }
        #endregion Post (Get User)
    }
}
