using System;
namespace MedicomPrototype.Models
{
    public class HealthCareProfessional : BaseModel
    {
		public string PatientId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string EmailId { get; set; }
		public bool CanShareInformation { get; set; }

        public HealthCareProfessional()
        {
        }
    }
}
