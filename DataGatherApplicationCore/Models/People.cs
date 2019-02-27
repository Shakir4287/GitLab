
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataGatherApplicationCore.Models
{
	public class People
	{
		[Key]
		public int PeopleID { get; set; }
		[Column(TypeName ="nvarchar(100)")]
		[Required(ErrorMessage="Enter First Name")]
		[DisplayName("First Name")]
		public string PeopleFirstName { get; set; }
		[Required(ErrorMessage = "Enter Last Name")]
		[DisplayName("Last Name")]
		public string PeopleLastName { get; set; }
		[Required(ErrorMessage = "Enter Profession")]
		[DisplayName("Profession")]
		public string PeopleProfession { get; set; }



		[Required(ErrorMessage = "Enter Phone")]
		[DisplayName("Phone")]
		[DataType(DataType.PhoneNumber)]
		public string PeoplePhoneNumber { get; set; }


		[Required(ErrorMessage = "Enter Address")]
		[DisplayName("Address")]
		public string PeopleAddress { get; set; }
		[Required(ErrorMessage = "Enter City")]
		[DisplayName("City")]
		public string PeopleCity { get; set; }
		[Required(ErrorMessage = "Enter Country")]
		[DisplayName("Country")]
		public string PeopleCountry { get; set; }




	}
}
