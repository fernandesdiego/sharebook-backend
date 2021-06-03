using ShareBook.Domain;
using ShareBook.Domain.Enums;
using ShareBook.Repository;
using ShareBook.Service;

namespace Sharebook.Jobs
{
    public class NewBookNotify : GenericJob, IJob
    {
        private readonly IEmailService _emailService;

        public NewBookNotify(
            IJobHistoryRepository jobHistoryRepo,
            IEmailService emailService) : base(jobHistoryRepo)
        {

            JobName = "NewBookNotify";
            Description = "Assim que um novo livro é aprovado, notifica, por e-mail, os usuários que já solicitaram algum livro da mesma categoria do novo. " +
                          "Para isso é utilizada a leitura de uma fila da Amazon SQS.";
            Interval = Interval.Each5Minutes;
            Active = true;
            BestTimeToExecute = null;

            _emailService = emailService;
        }

        public override JobHistory Work()
        {

            // TODO: reformular esse job
            return new JobHistory();


            //int qtDestinations = 0;

            //var message = _AWSSQSService.GetMessageAsync().Result;

            //if (message != null)
            //{
            //    foreach (var destination in message.Destinations)
            //    {
            //        _emailService.Send(destination.Email, destination.Name, message.BodyHTML.Replace("{name}", destination.Name), message.Subject).Wait();

            //        // freio lógico
            //        Thread.Sleep(1000);
            //    }

            //    var receiptHandle = message.ReceiptHandle;
            //    _AWSSQSService.DeleteMessageAsync(receiptHandle).Wait();

            //    qtDestinations = message.Destinations.Count();
            //}

            //return new JobHistory()
            //{
            //    JobName = JobName,
            //    IsSuccess = true,
            //    Details = String.Join("\n", $"{qtDestinations} e-mails enviados.")
            //};
        }
    }

}
