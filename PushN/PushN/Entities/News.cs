using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushN.Entities
{
    public partial class News
    {
        //[Key]
        public long Id { get; set; }

        //[MaxLength(100)]
        public string Title { get; set; }

        //[MaxLength(100)]
        public string Subtitle { get; set; }

        //[MaxLength(500)]
        //[DataType(DataType.MultilineText)]
        public string Body { get; set; }

        //[MaxLength(250)]
        public string Source { get; set; }

        //[MaxLength(500)]
        public string ExternalReference { get; set; }

        public DateTime PublishedDate { get; set; }

        public DateTime CreatedDate { get; set; }

        //[JsonIgnore]
        //[ForeignKey("CreatedBy")]

        //public virtual User CreatedByUser { get; set; }

        public virtual long CreatedBy { get; set; }

        public bool Active { get; set; }

        public string Text{ get; set; }
        public int Value { get; set; }
    }
}
