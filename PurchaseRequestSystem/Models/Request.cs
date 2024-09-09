namespace PurchaseRequestSystem.Models
{
    internal class Request
    {
        public string UserId {get; set;}
        public string Description {get; set;}
        public string Justification {get; set;}
        public DateTime DateNeeded {get; set;}
        public DateTime SubmittedDate {get; set;}
        public string DeliveryMode {get; set;}

    }
}
