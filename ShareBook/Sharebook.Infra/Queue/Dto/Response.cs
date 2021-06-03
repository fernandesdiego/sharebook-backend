namespace ShareBook.Infra.Queue.Dto
{
    public class Response
    {
        public string ReceiptHandle { get; set; }
        public string Subject { get; set; }
        public string BodyHTML { get; set; }
        public Destination Destination { get; set; }
    }
}