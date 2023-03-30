namespace Logic
{
    public class Address
    {
        private string streetName;
        private string streetNumber;
        private string zip;
        private string city;
        private string country;


        public string? StreetName { get; set; }
        public string? StreetNumber { get; set; }
        public string? Zip { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }

        public Address(string streetName, string streetNumber, string zip, string city, string country)
        {
            this.streetName = streetName;
            this.streetNumber = streetNumber;
            this.zip = zip;
            this.city = city;
            this.country = country;
        }

        public Address()
        {

        }
    }
}