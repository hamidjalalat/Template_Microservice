using HJMST.Base;
using HJMST.Base.Enums;

namespace HJMST.Persistence.Base
{
	public class Options 
	{
		public Options() : base()
		{
		}

		public Provider Provider { get; set; }

		public string ConnectionString { get; set; }

		public string InMemoryDatabaseName { get; set; }
	}
}
