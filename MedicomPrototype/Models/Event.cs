using System;
namespace MedicomPrototype.Models
{
    public class Event : BaseModel
    {
		public string PatientId { get; set; }
		public string DevcieId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
		public string LocationLatLong { get; set; }
        public bool IsEmergency { get; set; }
        public bool IsEndConfirmed { get; set; }
		public string Actors { get; set; }

        public Event()
        {
        }
    }
}
