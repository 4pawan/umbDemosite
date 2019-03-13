using System.Collections.Generic;
using Newtonsoft.Json;
using umbDemosite.Models;

namespace umbDemosite.Implementation.Helper
{
    public class Helper
    {
        public static IEnumerable<CarouselModel> GetCarouselObject(string carouseljson)
        {
            return JsonConvert.DeserializeObject<IEnumerable<CarouselModel>>(carouseljson);
        }
    }
}


