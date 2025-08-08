using LoanAxis.Api.Domain.Enums;
using LoanAxis.Api.Domain.Events;
using LoanAxis.Api.Domain.Exceptions;
using LoanAxis.Api.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LoanAxis.Api.Domain.Entities
{
    public class Loan
    {
        private Loan() { }

        public Loan(int customerId, Money principalAmount, InterestRate interestRate,
                   LoanTerm term, DateTime startDate, ApplicationType applicationType)
        {
            CustomerId = customerId;
            PrincipalAmount = principalAmount ?? throw new ArgumentNullException(nameof(principalAmount));
            InterestRate = interestRate ?? throw new ArgumentNullException(nameof(interestRate));
            Term = term ?? throw new ArgumentNullException(nameof(term));
            StartDate = startDate;
            ApplicationType = applicationType;
            Status = LoanStatus.Pending;
        }

        public int Id { get; private set; }
        public int CustomerId { get; private set; }
        public Customer Customer { get; private set; }

        public Money PrincipalAmount { get; private set; }
        public InterestRate InterestRate { get; private set; }
        public LoanTerm Term { get; private set; }

        public DateTime StartDate { get; private set; }
        public LoanStatus Status { get; private set; }
        public ApplicationType ApplicationType { get; private set; }

        private readonly Collection<RepaymentSchedule> _schedules = new Collection<RepaymentSchedule>();
        public IReadOnlyCollection<RepaymentSchedule> Schedules => _schedules;

        private readonly Collection<RepaymentTransaction> _transactions = new Collection<RepaymentTransaction>();
        public IReadOnlyCollection<RepaymentTransaction> Transactions => _transactions;

        private readonly List<DomainEvent> _domainEvents = new List<DomainEvent>();
        public IReadOnlyCollection<DomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        public void Approve()
        {
            if (Status != LoanStatus.Pending)
                throw new DomainException("Only pending loans can be approved");

            Status = LoanStatus.Approved;
            AddDomainEvent(new LoanApprovedEvent(Id));
        }

        public void Reject(string reason)
        {
            if (Status != LoanStatus.Pending)
                throw new DomainException("Only pending loans can be rejected");

            Status = LoanStatus.Rejected;
            AddDomainEvent(new LoanRejectedEvent(Id, reason));
        }

        public void AddDomainEvent(DomainEvent eventItem) => _domainEvents.Add(eventItem);
        public void ClearDomainEvents() => _domainEvents.Clear();
    }
}
