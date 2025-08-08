namespace LoanAxis.Api.Domain.Events
{
    public class LoanRejectedEvent : DomainEvent
    {
        public int LoanId { get; }
        public string Reason { get; }

        public LoanRejectedEvent(int loanId, string reason)
        {
            LoanId = loanId;
            Reason = reason;
        }
    }
}
