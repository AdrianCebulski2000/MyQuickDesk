﻿using Microsoft.AspNetCore.Identity;

namespace MyQuickDesk.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; } = string.Empty!;
        public int ReservationId { get; set; }
        public string Password { get; set; } = string.Empty!;
        public string Name { get; set; } = string.Empty!;
        public bool Owner { get; set; }
        public string Email { get; set; } = string.Empty!;

        public string? CreatedById { get; set; }
        public IdentityUser? CreatedBy { get; set; }

        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }

}
