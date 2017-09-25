using System;
namespace MedicomPrototype.Models
{
    public class DeviceMedicine : BaseModel
    {
        public string PatientId { get; set; }
		public string DeviceId { get; set; }
		public string MedicineId { get; set; }
		public string MedicineName { get; set; }
		public string MedicineLeafletURL { get; set; }
		public string SerialNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public float MaxTemperature { get; set; }
        public float MinTemperature { get; set; }
        public float MaxHumidity { get; set; }
        public float MinHumidity { get; set; }
		public string QRCode { get; set; }

        public DeviceMedicine()
        {
        }
    }
}
