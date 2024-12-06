using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishingHouse.Abstractions.Entity
{
    public interface IOrderRequest
    {
        public int OrderRequestId { get; set; }
        public int CustomerId { get; set; }
        public string? BookName { get; set; }
        public string? AuthorName { get; set; }
        public string? Genre { get; set; }
        public int PublicationYear { get; set; }
        public int Quantity { get; set; }
        public string? PrintType { get; set; }
        public string? PaperType { get; set; }
        public string? CoverType { get; set; }
        public string? FasteningType { get; set; }
        public bool? IsLaminated { get; set; }
        public string? CoverImagePath { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public ICustomer Customer { get; set; }
    }
}
