namespace LoanAxis.Api.Domain.Events
{
    public abstract class DomainEvent
    {
        // Base event properties if needed later
    }

    public class LoanApprovedEvent : DomainEvent
    {
        public int LoanId { get; }

        public LoanApprovedEvent(int loanId)
        {
            LoanId = loanId;
        }
    }
}
