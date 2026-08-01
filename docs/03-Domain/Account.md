\# Account



\## Purpose



An Account represents a place where money is stored or managed.



Examples:



\- Current Account

\- Saving Account

\- Cash Wallet

\- Brokerage Account

\- Digital Wallet



An Account belongs to one Portfolio.



\---



\## Fields



| Field | Type | Required | Description |

|--------|------|----------|-------------|

| Id | UUID | Yes | Primary Key |

| ReferenceNo | String(30) | Yes | ACC-00000001 |

| PortfolioId | UUID | Yes | Parent Portfolio |

| BankId | UUID | No | Reference.Bank |

| AccountTypeId | UUID | Yes | Reference.AccountType |

| CurrencyId | UUID | Yes | Reference.Currency |

| Name | String(200) | Yes | Display Name |

| Description | String(500) | No | Notes |

| OpeningBalance | Decimal(18,4) | Yes | Initial Balance |

| CurrentBalance | Decimal(18,4) | Yes | Latest Calculated Balance |

| Status | SmallInt | Yes | Active / Closed / Frozen |

| CreatedOn | Timestamp | Yes | UTC |

| UpdatedOn | Timestamp | Yes | UTC |



\---



\## Relationships



Portfolio



1 → N Accounts



Account



1 → N TransactionLines



Account



1 → N Holdings



\---



\## Business Rules



\- Every account has one currency.

\- Current Balance is calculated from the Ledger.

\- Manual balance modification is not allowed.

\- Closing an account requires zero balance.



\---



\## Domain Events



\- AccountCreated

\- AccountClosed

\- BalanceChanged



\---



\## Future



\- Joint Accounts

\- Linked Accounts

\- External Open Banking Accounts

\- Credit Card Accounts

