namespace HJMST.Persistence.ViewModels
{
	public class GetGoogoolisQueryResponseViewModel : object
	{
		public GetGoogoolisQueryResponseViewModel() : base()
		{
		}

		 
		public Guid Id { get; set; }

        public string GoogooliName { get; set; }


        public string LastName { get; set; }


        public string FirstName { get; set; }


        public string EmailAddress { get; set; }


        public string Password { get; set; }


        public string Message { get; set; }
		 
	}
}
