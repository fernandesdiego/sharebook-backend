namespace ShareBook.Infra.AWSSQS.Dto
{
    public class AWSSQSMessageNewBookNotifyRequest
    {
        public string Subject { get; set; }
        public string BodyHTML { get; set; }
        public Destination Destination { get; set; }
    }

    public class Destination
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}