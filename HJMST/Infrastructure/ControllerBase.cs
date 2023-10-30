using FluentResults;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HJMST.Infrastructure
{
	public abstract class ControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
	{
		protected ControllerBase(IMediator mediator) : base()
		{
			Mediator = mediator;
		}

		protected IMediator Mediator { get; }

		protected IActionResult
			FluentResult<T>(Result<T> result)
		{
			if (result.IsSuccess)
			{
				return Ok(value: result);
			}
			else
			{
				return BadRequest(error: result.ToResult());
			}
		}
	}
}
