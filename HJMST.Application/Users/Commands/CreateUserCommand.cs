using System.ComponentModel.DataAnnotations;

namespace HJMST.Application.Users.Commands
{

	public class CreateUserCommand : Mediator.IRequest<Guid>
	{
		public CreateUserCommand() : base()
		{
		}

        [Required]
        public string UserName { get; set; }



        [Required]
        public string LastName { get; set; }



        [Required]
        public string FirstName { get; set; }



        [Required]
        public string EmailAddress { get; set; }


        [Required]
        public string Password { get; set; }


    }
}
