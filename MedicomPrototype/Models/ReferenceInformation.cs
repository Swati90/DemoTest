using System;
namespace MedicomPrototype.Models
{
    public class ReferenceInformation : BaseModel
    {
		public string Title { get; set; }
		public string URL { get; set; }
		public string URLType { get; set; }
		public string MedicalCondition { get; set; }

        public ReferenceInformation()
        {
        }
    }
}
