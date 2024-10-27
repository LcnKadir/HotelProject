namespace RapidApiConsume.Models
{
    public class BookingApiLocationSearchViewModel
    {
        public string id { get; set; }
    }

    public class BookingApiResponseViewModel
    {
        public List<BookingApiLocationSearchViewModel> data { get; set; }
    }
}
