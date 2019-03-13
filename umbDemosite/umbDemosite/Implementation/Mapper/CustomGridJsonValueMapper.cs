using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Umbraco.Core;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.PropertyEditors;

namespace umbDemosite.Implementation.Mapper
{
    public class JsonValueConverter : PropertyValueConverterBase
    {
        public override bool IsConverter(PublishedPropertyType propertyType)
        {
            return propertyType.Alias.Equals("carousel1");
        }

        //public override bool? IsValue(object value, PropertyValueLevel level)
        //{
        //    throw new NotImplementedException();

        //Server error: Contact administrator, see log for full details.
        //    Type 'umbDemosite.Implementation.Mapper.JsonValueConverter' cannot be an IPropertyValueConverter for property 'carousel'
        //of content type 'home' because type 'Umbraco.Web.PropertyEditors.ValueConverters.NestedContentManyValueConverter' 
        //has already been detected as a converter for that property, and only one converter can exist for a property.

        //}

        public override Type GetPropertyValueType(PublishedPropertyType propertyType)
        {
            return typeof(CarouselModel);
        }

        //public override PropertyCacheLevel GetPropertyCacheLevel(PublishedPropertyType propertyType)
        //{
        //    return PropertyCacheLevel.Snapshot;
        //}

        public override object ConvertSourceToIntermediate(IPublishedElement owner, PublishedPropertyType propertyType, object source,
            bool preview)
        {
            return source;
        }

        public override object ConvertIntermediateToObject(IPublishedElement owner, PublishedPropertyType propertyType,
            PropertyCacheLevel referenceCacheLevel, object inter, bool preview)
        {
            return inter;
        }

        //public override object ConvertIntermediateToXPath(IPublishedElement owner, PublishedPropertyType propertyType,
        //    PropertyCacheLevel referenceCacheLevel, object inter, bool preview)
        //{
        //    throw new NotImplementedException();
        //}
    }

    public class CarouselModel
    {
        public string key { get; set; }
        public string name { get; set; }
        public string ncContentTypeAlias { get; set; }
        public string carouselHeading { get; set; }
        public string carouselImage { get; set; }
        public string carouselText { get; set; }
    }


}