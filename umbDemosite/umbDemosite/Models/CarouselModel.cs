using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace umbDemosite.Models
{
    public class CarouselModel
    {
        public string key { get; set; }
        public string name { get; set; }
        public string ncContentTypeAlias { get; set; }
        public string carouselHeading { get; set; }
        public string carouselImage { get; set; }
        public string carouselText { get; set; }
        public string slideLink { get; set; }
        public List<AnchorLink> SlideLinkAsObjects => JsonConvert.DeserializeObject<List<AnchorLink>>(this.slideLink);
    }
}