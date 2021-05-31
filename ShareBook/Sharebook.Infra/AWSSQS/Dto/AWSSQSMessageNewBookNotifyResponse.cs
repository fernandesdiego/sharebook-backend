namespace ShareBook.Infra.AWSSQS.Dto
{
    public class AWSSQSMessageNewBookNotifyResponse
    {
        public string ReceiptHandle { get; set; }
        public string Subject { get; set; }
        public string BodyHTML { get; set; }
        public Destination Destination { get; set; }
    }
}