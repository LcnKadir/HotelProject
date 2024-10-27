namespace RapidApiConsume.Models
{
    public class BookingApiViewModel
    {
        public Datum[] data { get; set; }

        public class Datum
        {
            public float avgRating { get; set; }
            public int bathrooms { get; set; }
            public int? bedrooms { get; set; }
            public int? beds { get; set; }
            public string city { get; set; }
            public string id { get; set; }
            public string localizedCityName { get; set; }
            public string listingName { get; set; }
            public string publicAddress { get; set; }
            public string title { get; set; }
            public string avgRatingLocalized { get; set; }
            public string accessibilityLabel { get; set; }
            public bool concatQualifierLeft { get; set; }
            public string discountedPrice { get; set; }
            public string originalPrice { get; set; }
            public string qualifier { get; set; }
            public object trailingContent { get; set; }
            public int children { get; set; }
            public int infants { get; set; }
            public string checkin { get; set; }
            public string checkout { get; set; }
            public object relaxedAmenityIds { get; set; }
            public object categoryTag { get; set; }
            public int pets { get; set; }
            public string webURL { get; set; }
            public string[] images { get; set; }
            public string price { get; set; }
        }

    }
}
