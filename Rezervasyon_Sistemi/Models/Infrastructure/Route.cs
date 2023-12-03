using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Models.Infrastructure
{
    public class Route
    {
        public int BigRouteId { get; set; }
        public string startPosition { get; set; }
        public string endPosition { get; set; }
        public int distance { get; set; }
        public List<String> cities { get; set; }

        public Route(int bigRouteId, string startPosition, string endPosition, int distance, List<string> cities)
        {
            BigRouteId = bigRouteId;
            this.startPosition = startPosition;
            this.endPosition = endPosition;
            this.distance = distance;
            this.cities = cities;
        }
    }
}
