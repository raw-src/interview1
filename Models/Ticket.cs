using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ticket_system_api.Interfaces;

namespace ticket_system_api.Models
{
    public class Ticket: Table
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string TicketTitle { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public TicketType TicketType { get; set; } = TicketType.bug;

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string TicketDescription { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(40)")]
        public string TitleDate { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string TicketEffort { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public TicketState TicketDescription { get; set; } = TicketState.NotStarted;

        [Column(TypeName = "nvarchar(200)")]
        public string Product { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string ClientDescription { get; set; }
    }
}
