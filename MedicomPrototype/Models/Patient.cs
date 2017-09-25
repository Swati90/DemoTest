using System;
namespace MedicomPrototype.Models
{
    public class Patient : BaseModel
    {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
		public string PhoneNumber { get; set; }
		public string EmailId { get; set; }
    }
}
