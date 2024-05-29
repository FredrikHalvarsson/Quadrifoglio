using IlQuadrifoglioAPI.Models;

namespace IlQuadrifoglioAPI.DTOs
{
    public class LocationPartialViewModel
    {
        public ApplicationUser User { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string GoogleMapsApiKey { get; set; }
    }
}
