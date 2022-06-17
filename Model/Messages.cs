using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Messages")]
    public partial class Messages
    {

        public int Id { get; set; }
        public string MessageType { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSecondName { get; set; }
        public string AuthorPhoneNumber { get; set; }
        public string AuthorEmail { get; set; }
        public string Report { get; set; }
        public string ReportDetails { get; set; }
        public string Message { get; set; }
        public string Date { get; set; }

    }
}
