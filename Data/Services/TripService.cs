using System.Collections.Generic;

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
            throw new System.NotImplementedException();
        }

        public List<Trip> GetAllTrips()
        {
            return Data.Trips;
        }

        public Trip GetTripById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateTrip(int tripId, Trip trip)
        {
            throw new System.NotImplementedException();
        }
    }
}