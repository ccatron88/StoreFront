using System;
using System.ComponentModel.DataAnnotations;
namespace StorefrontApp.Models

{
	public class UserDataForm
	{
		[Required]
		public string? FirstName { get; set; }

		[Required]
		public string? LastName { get; set; }

		[Required]
		public string? EmailAddress { get; set; }

		public UserDataForm()
		{
		}
	}
}

