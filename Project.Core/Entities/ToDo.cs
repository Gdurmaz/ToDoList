using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Entities
{
    public class ToDo
    {
        public Guid ID { get; set; }
        [DisplayName("Başlık")]
        public string Title { get; set; }
        [DisplayName("Özet")]
        public string Summary { get; set; }
        [DisplayName("Açıklama")]
        public string Description { get; set; }
        [DisplayName("Önem Derecesi")]
        public int ImportanceLevel { get; set; }
        [DisplayName("Durum")]
        public string Status { get; set; }
        [DisplayName("Oluşturulma Tarihi")]
        public DateTime CreationDate { get; set; }

    }
}
