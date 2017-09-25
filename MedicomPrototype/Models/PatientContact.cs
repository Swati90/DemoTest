using System;
namespace MedicomPrototype.Models
{
    public class PatientContact : BaseModel
    {
		public string PatientId { get; set; }
		public string ContactId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PhoneNumber { get; set; }
        public string EmailId { get; set; }
		public string Relationship { get; set; }

		public PatientContact()
        {
            
        }
    }
}
