using System.Collections.Generic;

namespace Trips.Data
{
    public interface ITripService
    {
        List<Trip> GetAllTrips();

        Trip GetTripById(int id);

        void UpdateTrip(int tripId, Trip trip);
        void DeleteTrip(int tripId);
        void AddTrip(Trip trip);
    }
}