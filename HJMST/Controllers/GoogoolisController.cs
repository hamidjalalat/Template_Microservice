using HJMST.Application.Googoolis.Commands;
using HJMST.Application.Googoolis.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace LoggingMicroservice.Api.Controllers
{
    [ApiController]
    [Route(template: "[controller]")]
    public class GoogoolisController : HJMST.Infrastructure.ControllerBase
    {
        public GoogoolisController(IMediator mediator) : base(mediator: mediator)
        {
        }

        #region Post (Create Googooli)
        [HttpPost(template: "/CreateGoogooli")]

        public async Task<IActionResult> CreateGoogooli(CreateGoogooliCommand request)
        {
            var result = await Mediator.Send(request);

            return FluentResult(result: result);
        }
        #endregion /Post (Create Googooli)


        #region Post (Get Googooli)
        [HttpPost(template: "/GetGoogooli")]
        public async Task<IActionResult> GetGoogooli(string googooliname, string password)
        {
            var request =
                new GetByGoogooliNameQuery
                {
                    GoogooliName = googooliname,
                    Password = password,

                };

            var result = await Mediator.Send(request);

            return FluentResult(result: result);
        }
        #endregion Post (Get Googooli)
    }
}
