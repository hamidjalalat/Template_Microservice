using FluentResults;

namespace Mediator
{
	public class Query<TValue> : MediatR.IRequest<Result<TValue>>
	{
		public Query() : base()
		{
		}
	}
}
