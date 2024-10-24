namespace RapidApiConsume.Models
{
    public class BookingApiViewModel
    {
        public Data data { get; set; }


        public class Data
        {
            public string __typename { get; set; }
            public Product[] products { get; set; }
            public Filterstats filterStats { get; set; }
            public Sorter[] sorters { get; set; }
            public Defaultsorter defaultSorter { get; set; }
            public Filteroptions filterOptions { get; set; }
        }

        public class Filterstats
        {
            public string __typename { get; set; }
            public int unfilteredProductCount { get; set; }
            public int filteredProductCount { get; set; }
        }

        public class Defaultsorter
        {
            public string __typename { get; set; }
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Filteroptions
        {
            public string __typename { get; set; }
            public Typefilter[] typeFilters { get; set; }
            public Labelfilter[] labelFilters { get; set; }
            public Ufifilter[] ufiFilters { get; set; }
            public Pricefilter[] priceFilters { get; set; }
        }

        public class Typefilter
        {
            public string __typename { get; set; }
            public string name { get; set; }
            public string tagname { get; set; }
            public int productCount { get; set; }
        }

        public class Labelfilter
        {
            public string __typename { get; set; }
            public string name { get; set; }
            public string tagname { get; set; }
            public int productCount { get; set; }
        }

        public class Ufifilter
        {
            public string __typename { get; set; }
            public string name { get; set; }
            public string tagname { get; set; }
            public int productCount { get; set; }
        }

        public class Pricefilter
        {
            public string __typename { get; set; }
            public string name { get; set; }
            public string tagname { get; set; }
            public int productCount { get; set; }
        }

        public class Product
        {
            public string __typename { get; set; }
            public Cancellationpolicy cancellationPolicy { get; set; }
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
            public string shortDescription { get; set; }
            public Representativeprice representativePrice { get; set; }
            public Primaryphoto primaryPhoto { get; set; }
            public Reviewsstats reviewsStats { get; set; }
            public Ufidetails ufiDetails { get; set; }
            public Offer[] offers { get; set; }
            public Supportedfeatures supportedFeatures { get; set; }
            public Flag[] flags { get; set; }
        }

        public class Cancellationpolicy
        {
            public string __typename { get; set; }
            public bool hasFreeCancellation { get; set; }
        }

        public class Representativeprice
        {
            public string __typename { get; set; }
            public float chargeAmount { get; set; }
            public string currency { get; set; }
            public float publicAmount { get; set; }
        }

        public class Primaryphoto
        {
            public string __typename { get; set; }
            public string small { get; set; }
        }

        public class Reviewsstats
        {
            public string __typename { get; set; }
            public int allReviewsCount { get; set; }
            public string percentage { get; set; }
            public Combinednumericstats combinedNumericStats { get; set; }
        }

        public class Combinednumericstats
        {
            public string __typename { get; set; }
            public float average { get; set; }
            public int total { get; set; }
        }

        public class Ufidetails
        {
            public string __typename { get; set; }
            public string bCityName { get; set; }
            public int ufi { get; set; }
            public Url url { get; set; }
        }

        public class Url
        {
            public string __typename { get; set; }
            public string country { get; set; }
        }

        public class Supportedfeatures
        {
            public string __typename { get; set; }
            public bool nativeApp { get; set; }
        }

        public class Offer
        {
            public string __typename { get; set; }
            public Item[] items { get; set; }
        }

        public class Item
        {
            public string __typename { get; set; }
            public string id { get; set; }
        }

        public class Flag
        {
            public string __typename { get; set; }
            public string flag { get; set; }
            public bool value { get; set; }
            public int rank { get; set; }
        }

        public class Sorter
        {
            public string __typename { get; set; }
            public string name { get; set; }
            public string value { get; set; }
        }

    }
}
