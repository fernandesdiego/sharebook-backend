using System;
using System.Threading.Tasks;

namespace ShareBook.Infra.AWSSQS
{
    public interface IAWSSQSService
    {
        Task SendMessageAsync(AWSSQSMessageNewBookNotifyRequest message);
        Task<AWSSQSMessageNewBookNotifyResponse> GetMessageAsync();
        Task DeleteMessageAsync(string receiptHandle);
    }
}