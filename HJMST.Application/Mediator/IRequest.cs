using FluentResults;
using MediatR;

namespace Mediator
{
	public interface IRequest : IRequest<Result>
	{
	}

	public interface IRequest<TReturnValue> :MediatR.IRequest<Result<TReturnValue>>
	{
	}
}
