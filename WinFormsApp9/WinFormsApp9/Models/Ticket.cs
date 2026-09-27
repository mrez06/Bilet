using System;

namespace WinFormsApp9.Models
{
    public class Ticket
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string Seat { get; set; }

        // Person info
        public string Name { get; set; }
        public string FIN { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{Date:yyyy-MM-dd} {Time} - {From}->{To} ({Name})";
        }
    }
}
