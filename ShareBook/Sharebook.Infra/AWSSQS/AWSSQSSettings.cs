using System;
using System.Collections.Generic;
using System.Text;

namespace ShareBook.Infra.AWSSQS
{
    public class AWSSQSSettings
    {
        public bool IsActive { get; set; }
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
        public string QueueUrl { get; set; }
        public string Region { get; set; }
    }
}
