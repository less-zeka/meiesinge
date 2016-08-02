using System;

namespace Meiesinge.WebClient.Models
{
    public class Invitee
    {
        public Guid Id { get; set; }
        public string InviteeName { get; set; }

        //public virtual ICollection<Enrollment> Enrollments { get; set; }
    }

    public class Artist
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}