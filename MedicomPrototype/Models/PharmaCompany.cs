using System;
namespace MedicomPrototype.Models
{
    public class PharmaCompany : BaseModel
    {
		public string PatientId { get; set; }
		public string CompanyName { get; set; }
		public string EmailSubscription { get; set; }
        public bool CanShareInformation { get; set; }
        public bool CanParticipateInClinicalTrials { get; set; }

        public PharmaCompany()
        {
        }
    }
}
