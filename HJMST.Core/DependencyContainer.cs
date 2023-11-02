using MediatR;
using FluentValidation;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using HJMST.Application.Googoolis;
using HJMST.Application.Googoolis.Commands;
using Mediator;
using HJMST.Persistence;
using HJMST.Base.Enums;
using HJMST.Persistence.Base;

namespace HJMST.Core
{
	public static class DependencyContainer : object
	{
		static DependencyContainer()
		{
		}

		public static void ConfigureServices
			(IConfiguration configuration,IServiceCollection services)
		{
			services.AddTransient<IHttpContextAccessor,HttpContextAccessor>();

			services.AddMediatR(typeof(MappingProfile).GetTypeInfo().Assembly);

			services.AddValidatorsFromAssembly(assembly: typeof(CreateGoogooliCommandValidator).Assembly);

			services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

			services.AddAutoMapper(profileAssemblyMarkerTypes: typeof(MappingProfile));

			services.AddTransient<HJMST.Persistence.IUnitOfWork, HJMST.Persistence.UnitOfWork>(current =>
			{
				string databaseConnectionString =configuration
					.GetSection(key: "ConnectionStrings")
					.GetSection(key: "CommandsConnectionString")
					.Value;

				string databaseProviderString =
					configuration
					.GetSection(key: "CommandsDatabaseProvider")
					.Value;

               Provider databaseProvider =(Provider)Convert.ToInt32(databaseProviderString);

               Options options =
					new Options
					{
						Provider = databaseProvider,
						ConnectionString = databaseConnectionString,
					};

				return new UnitOfWork(options: options);
			});

			services.AddTransient<HJMST.Persistence.IQueryUnitOfWork, HJMST.Persistence.QueryUnitOfWork>(current =>
			{
				string databaseConnectionString =
					configuration
					.GetSection(key: "ConnectionStrings")
					.GetSection(key: "QueriesConnectionString")
					.Value;

				string databaseProviderString =
					configuration
					.GetSection(key: "QueriesDatabaseProvider")
					.Value;

                Provider databaseProvider =(Provider) Convert.ToInt32(databaseProviderString);

              Options options =
				new Options
					{
						Provider = databaseProvider,
						ConnectionString = databaseConnectionString,
					};

				return new QueryUnitOfWork(options: options);
			});
		}
	}
}
