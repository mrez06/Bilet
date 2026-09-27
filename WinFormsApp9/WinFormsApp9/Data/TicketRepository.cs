using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WinFormsApp9.Models;

namespace WinFormsApp9.Data
{
    public class TicketRepository
    {
        private readonly List<Ticket> _tickets = new List<Ticket>();

        public IReadOnlyList<Ticket> Tickets => _tickets.AsReadOnly();

        public void Add(Ticket ticket)
        {
            if (ticket == null) throw new ArgumentNullException(nameof(ticket));
            _tickets.Add(ticket);
        }

        public void Remove(Guid id)
        {
            var t = _tickets.FirstOrDefault(x => x.Id == id);
            if (t != null) _tickets.Remove(t);
        }

        public void Clear() => _tickets.Clear();

        public void LoadFromCsv(string filePath)
        {
            _tickets.Clear();
            if (!File.Exists(filePath)) return;
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var parts = line.Split('|');
                // Expected: Id|From|To|Date|Time|Seat|Name|FIN|Phone|Email
                if (parts.Length < 10) continue;
                try
                {
                    var ticket = new Ticket
                    {
                        Id = Guid.Parse(parts[0]),
                        From = parts[1],
                        To = parts[2],
                        Date = DateTime.Parse(parts[3]),
                        Time = parts[4],
                        Seat = parts[5],
                        Name = parts[6],
                        FIN = parts[7],
                        Phone = parts[8],
                        Email = parts[9]
                    };
                    _tickets.Add(ticket);
                }
                catch
                {
                    // skip malformed lines
                }
            }
        }

        public void SaveToCsv(string filePath)
        {
            var lines = _tickets.Select(t => string.Join('|', new[] {
                t.Id.ToString(),
                t.From ?? string.Empty,
                t.To ?? string.Empty,
                t.Date.ToString("yyyy-MM-dd"),
                t.Time ?? string.Empty,
                t.Seat ?? string.Empty,
                t.Name ?? string.Empty,
                t.FIN ?? string.Empty,
                t.Phone ?? string.Empty,
                t.Email ?? string.Empty
            }));
            File.WriteAllLines(filePath, lines);
        }
    }
}
