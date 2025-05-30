using Microsoft.AspNetCore.Mvc;
using Trips.Data;

namespace Trips.Controllers
{
    [Route("api/[controller]")]
    public class TripsController : Controller
    {
        private ITripService _service;
        public TripsController(ITripService service)
        {
            this._service = service;
        }

        [HttpGet("GetAllTrips")]
        public IActionResult GetAllTrips()
        {
            var trips = _service.GetAllTrips();
            return Ok(trips);
        }
        [HttpGet("GetTripById/{tripId}")]
        public IActionResult GetTripById(int tripId)
        {
            var trip = _service.GetTripById(tripId);
            if (trip != null)
            {
                return Ok(trip);
            }
            return NotFound();
        }

        [HttpPost("AddTrip")]
        public IActionResult AddTrip([FromBody]Trip trip)
        {
            if (trip != null)
            {
                _service.AddTrip(trip);
            }
            return Ok();
        }

        [HttpPut("UpdateTrip/{tripId}")]
        public IActionResult UpdateTrip(int tripId, [FromBody] Trip trip)
        {
            if (trip != null)
            {
                _service.UpdateTrip(tripId, trip);
            }
            return Ok();
        }
        [HttpDelete("DeleteTrip/{tripId}")]
        public IActionResult DeleteTrip(int tripId)
        {
            _service.DeleteTrip(tripId);
            return Ok();
        }
      
    }
}