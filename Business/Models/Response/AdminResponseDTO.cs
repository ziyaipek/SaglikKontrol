using System;
using Infrastructure.Data.Postgres.Entities;
namespace Business.Models.Response
{
	public class AdminResponseDTO
	{
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string ContactInformation { get; set; } = default!;
        public string Username { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}

