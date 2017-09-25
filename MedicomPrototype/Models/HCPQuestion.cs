using System;
namespace MedicomPrototype.Models
{
    public class HCPQuestion : BaseModel
    {
		public string PatientId { get; set; }
		public string HealthCareProfessionalId { get; set; }
		public string Question { get; set; }
        public string PictureOfflinePath { get; set; }

        public HCPQuestion()
        {
        }
    }
}
