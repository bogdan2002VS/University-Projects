namespace Logic
{
    public class RFIDControl
    {
        private bool isAssigned;
        private string serialNumber;

        public bool IsAssigned
        {
            get { return this.isAssigned; }
            set { this.isAssigned = value; }
        }
        public string SerialNumber { get; set; }

        public RFIDControl(string serial, bool isAssigned)
        {
            this.serialNumber = serial;
            this.isAssigned = isAssigned;
        }

        public RFIDControl(string serial)
        {
            this.serialNumber = serial;
        }

        public RFIDControl()
        {
        }

        public override string ToString()
        {
            return this.serialNumber;
        }
    }
}