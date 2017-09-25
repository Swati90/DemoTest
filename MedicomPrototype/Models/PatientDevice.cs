using System;
namespace MedicomPrototype.Models
{
    public class PatientDevice : BaseModel
    {
		public string PatientId { get; set; }
		public string DeviceId { get; set; }
		public string MacAddress { get; set; }
		public string DeviceLeafletURL { get; set; }
		public string DeviceName { get; set; }
		public string SerialNumber { get; set; }
        public float CurrentMedicineLevel { get; set; }
		public string DeviceVideoURL { get; set; }
		public string DevcieTutorial { get; set; }
		public string QRCode { get; set; }
        public float ThresholdLevel { get; set; }
        public DateTime MedicineLevelUpdatedOn { get; set; }
        public bool IsGuidedMode { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
