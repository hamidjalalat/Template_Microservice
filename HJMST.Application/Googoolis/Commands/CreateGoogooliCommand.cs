using System.ComponentModel.DataAnnotations;

namespace HJMST.Application.Googoolis.Commands
{

	public class CreateGoogooliCommand : Mediator.IRequest<Guid>
	{
		public CreateGoogooliCommand() : base()
		{
		}

        [Required]
        public string GoogooliName { get; set; }



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
