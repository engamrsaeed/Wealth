# Portfolio

## Purpose

The Portfolio is the root aggregate of the Wealth platform.

It represents the complete financial position of a user and owns all financial objects.

A Portfolio contains:

- Accounts
- Holdings
- Transactions
- Financial Plans
- Events
- Snapshots

---

## Fields

| Field | Type | Required | Description |
|--------|------|----------|-------------|
| Id | UUID | Yes | Primary Key |
| ReferenceNo | String(30) | Yes | Portfolio Reference Number |
| TenantId | UUID | Yes | Reserved for future multi-tenancy |
| Name | String(200) | Yes | Portfolio Name |
| BaseCurrencyId | UUID | Yes | Default reporting currency |
| Description | String(500) | No | User notes |
| Status | SmallInt | Yes | Active / Closed |
| CreatedOn | Timestamp | Yes | UTC |
| UpdatedOn | Timestamp | Yes | UTC |

---

## Relationships

Portfolio

1 → N Accounts

1 → N Holdings

1 → N TransactionHeaders

1 → N FinancialPlans

1 → N Events

1 → N Snapshots

---

## Business Rules

- Every user owns one active portfolio in V1.
- Portfolio cannot be deleted.
- Base Currency cannot change after the first financial transaction.
- Reference Number is generated automatically.

---

## Domain Events

- PortfolioCreated
- PortfolioClosed
- PortfolioCurrencyChanged

---

## Future

- Multiple portfolios
- Family portfolios
- Shared portfolios
- Advisor managed portfolios