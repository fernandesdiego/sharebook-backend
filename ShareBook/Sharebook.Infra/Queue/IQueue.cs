using ShareBook.Infra.Queue.Dto;
using System.Threading.Tasks;

namespace ShareBook.Infra.Queue
{
    public interface IQueue
    {
        Task SendMessageAsync(Request message);
        Task<Response> GetMessageAsync();
        Task DeleteMessageAsync(string receiptHandle);
    }
}