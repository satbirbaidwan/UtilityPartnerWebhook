using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebhook
{
    public class WebhookPayload
    {
        public string Timestamp { get; set; }
        public string WebhookNotificationId { get; set; }
        public string MessageVersion { get; set; }
        public WebhookMessage Message { get; set; }
    }

    public class WebhookMessage
    {
        public string TXTBase64 { get; set; }
        public string UtilityID { get; set; }
        public string UtilityName { get; set; }
        public string StationCode { get; set; }
        public string TicketNumber { get; set; }
        public string SequenceNumber { get; set; }
        public string RequestDate { get; set; }
        public string XMLBase64 { get; set; }
        public string GIFBase64 { get; set; }
        public string GMLBase64 { get; set; }
    }
}
