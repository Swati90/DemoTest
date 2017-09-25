using System;
namespace MedicomPrototype.ViewModels
{
    public class PatientConditionViewModel : BaseModel
    {
		public string DiseaseId { get; set; }
		public string DiseaseName { get; set; }
        public bool IsPresent { get; set; }

        public PatientConditionViewModel()
        {
        }
    }
}
