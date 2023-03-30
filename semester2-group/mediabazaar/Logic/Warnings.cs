namespace Logic
{
    public class Warnings
    {
        private string reason;

        public string Reson { get; set; }
        public Warnings(string reson)
        {
            Reson = reson;
        }

        public Warnings()
        {

        }
    }
}