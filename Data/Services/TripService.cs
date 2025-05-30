using System.Collections.Generic;
using System.Linq;

namespace Trips.Data
{
    public class TripService : ITripService
    {
        public void AddTrip(Trip trip)
        {
           Data.Trips.Add(trip);
        }

        public void DeleteTrip(int tripId)
        {
            var trip = Data.Trips.FirstOrDefault(n => n.Id == tripId);
            if (trip != null)
            {
                Data.Trips.Remove(trip);
            }
        }

        public List<Trip> GetAllTrips()
        {
            return Data.Trips;
        }

        public Trip GetTripById(int id)
        {
            return Data.Trips.FirstOrDefault(n => n.Id == id);
        }

        public void UpdateTrip(int tripId, Trip trip)
        {
            var oldtrip = Data.Trips.FirstOrDefault(n => n.Id == tripId);
            if(oldtrip != null)
            {
                oldtrip.Name = trip.Name;
                oldtrip.Description = trip.Description;
                oldtrip.DateStarted = trip.DateStarted;
                oldtrip.DateCompleted = trip.DateCompleted;
            }
        }
    }
}