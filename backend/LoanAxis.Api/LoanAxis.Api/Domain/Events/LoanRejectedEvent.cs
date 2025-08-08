namespace LoanAxis.Api.Domain.Events
{
    public class LoanRejectedEvent(int loanId, string reason) : DomainEvent
    {
        public int LoanId { get; } = loanId;
        public string Reason { get; } = reason;
    }
}
