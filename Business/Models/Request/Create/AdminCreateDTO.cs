using System;
namespace Business.Models.Request.Create
{
	public class AdminCreateDTO
	{


        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string ContactInformation { get; set; } = default!;
        public string Username { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}

