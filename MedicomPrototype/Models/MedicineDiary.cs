using System;
namespace MedicomPrototype.Models
{
    public class MedicineDiary : BaseModel
    {
		public string MedicineId { get; set; }
		public string PatientId { get; set; }
		public string DeviceId { get; set; }
		public string EventId { get; set; }
        public float DoseQty { get; set; }
        public DateTime DoseDateTime { get; set; }
		public string Notes { get; set; }

        public MedicineDiary()
        {
        }
    }
}
