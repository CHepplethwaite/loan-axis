namespace LoanAxis.Api.Domain.Events
{
    public abstract class DomainEvent
    {
        // Base event properties if needed later
    }

    public class LoanApprovedEvent(int loanId) : DomainEvent
    {
        public int LoanId { get; } = loanId;
    }
}
