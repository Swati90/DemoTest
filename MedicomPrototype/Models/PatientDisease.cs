using System;
namespace MedicomPrototype.Models
{
    public class PatientDisease : BaseModel
    {
        public string PatientId { get; set; }
		public string DiseaseId { get; set; }
		public string DiseaseName { get; set; }
    }
}
