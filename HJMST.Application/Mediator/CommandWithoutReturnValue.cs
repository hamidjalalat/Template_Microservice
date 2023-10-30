using FluentResults;
using MediatR;

namespace Mediator
{
	public interface ICommandWithoutReturnValue : IRequest<Result>
	{
	}
}
