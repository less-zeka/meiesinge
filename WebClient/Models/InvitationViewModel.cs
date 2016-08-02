using System;

namespace Meiesinge.WebClient.Models
{
    public class InvitationViewModel
    {
        public Guid Guid { get; set; }

        public string Host { get; set; }

        public string Invitee { get; set; }

        public bool InvitationOk => Guid != Guid.Empty && !string.IsNullOrEmpty(Host);
    }
}