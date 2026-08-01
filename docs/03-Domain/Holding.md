\# Holding



\## Purpose



A Holding represents any asset owned by the user.



Examples:



\- Certificate

\- T-Bill

\- Gold

\- USD

\- Stock

\- Mutual Fund

\- Real Estate

\- Vehicle

\- Cryptocurrency



A Holding is always linked to one Product Definition.



\---



\## Fields



| Field | Type | Required | Description |

|--------|------|----------|-------------|

| Id | UUID | Yes | Primary Key |

| ReferenceNo | String(30) | Yes | HLD-00000001 |

| PortfolioId | UUID | Yes | Parent Portfolio |

| ProductDefinitionId | UUID | Yes | Product Definition |

| AccountId | UUID | No | Funding Account |

| Name | String(200) | Yes | User Friendly Name |

| PurchaseDate | Date | Yes | Purchase Date |

| PurchaseAmount | Decimal(18,4) | Yes | Initial Cost |

| CurrentValue | Decimal(18,4) | Yes | Latest Valuation Snapshot |

| CurrencyId | UUID | Yes | Holding Currency |

| Status | SmallInt | Yes | Active / Matured / Sold |

| CreatedOn | Timestamp | Yes | UTC |

| UpdatedOn | Timestamp | Yes | UTC |



\---



\## Relationships



Portfolio



1 → N Holdings



Holding



1 → N HoldingProperties



Holding



1 → N HoldingValuationHistory



Holding



1 → N TransactionLines



Holding



N → 1 ProductDefinition



\---



\## Business Rules



\- Every Holding belongs to exactly one Product Definition.

\- Product properties are inherited from Product Definition.

\- Current Value is calculated by the Valuation Engine.

\- Purchase Amount never changes.

\- A Sold Holding becomes read-only.



\---



\## Domain Events



\- HoldingCreated

\- HoldingPurchased

\- HoldingSold

\- HoldingMatured

\- HoldingValuationChanged



\---



\## Future



\- Fractional Ownership

\- Shared Holdings

\- AI Risk Classification

\- Portfolio Allocation

