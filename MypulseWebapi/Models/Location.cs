namespace MypulseWebapi.Models
{
    public class Location
    {
        public string Id { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string FullAddress { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string District { get; set; }
        public string Sublocality { get; set; }
        public string Owner { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public long _lastChangedAt { get; set; }
        public int _version { get; set; }
        public string __typeName { get; set; }
    }

}
