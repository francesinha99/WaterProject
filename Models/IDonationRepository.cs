using System;
using System.Linq;

namespace WaterProject.Models
{
    public interface IDonationRepository
    {
        IQueryable<Donation> Donation { get; }

        void SaveDonation(Donation donation);
    }
}
