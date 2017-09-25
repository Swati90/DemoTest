using System;
namespace MedicomPrototype
{
    public abstract class BaseModel
    {
		public string Id { get; set; }
		public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
		public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int IsActive { get; set; }
    }
}
