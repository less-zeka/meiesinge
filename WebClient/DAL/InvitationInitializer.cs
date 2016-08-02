using System;
using System.Collections.Generic;
using Meiesinge.WebClient.Models;

namespace Meiesinge.WebClient.DAL
{

    public class InvitationInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MeiesingeContext>
    {
        protected override void Seed(MeiesingeContext context)
        {
            var invitees = new List<Invitee>
            {
                new Invitee {Id = Guid.NewGuid(), InviteeName = "Alexander"},
                new Invitee {Id = Guid.NewGuid(), InviteeName = "Alonso"},
                new Invitee {Id = Guid.NewGuid(), InviteeName = "Anand"},
                new Invitee {Id = Guid.NewGuid(), InviteeName = "Barzdukas"},
            };

            invitees.ForEach(i => context.Invitees.Add(i));
            context.SaveChanges();
        }
    }
}