using System;
namespace MedicomPrototype.Models
{
    public class EventDetail : BaseModel
    {
		public string EventId { get; set; }
		public string Symptoms { get; set; }
        public int Mood { get; set; }
        public int Severity { get; set; }
		public int PainLevel { get; set; }
		public string PictureOfflinePath { get; set; }
		public string BodyPart { get; set; }
        public DateTime DateTime { get; set; }

        public EventDetail()
        {
        }
    }
}
