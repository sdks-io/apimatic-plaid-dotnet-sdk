using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The core attributes object contains additional data that can be used to assess the ACH return risk, such as past ACH return events, balance/transaction history, the Item’s connection history in the Plaid network, and identity change history.
/// </summary>
public record SignalEvaluateCoreAttributes
{
    /// <summary>
    /// We parse and analyze historical transaction metadata to identify the number of possible past returns due to unauthorized transactions over the past 7 days from the account that will be debited.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unauthorized_transactions_count_7d")]
    public int? UnauthorizedTransactionsCount7D { get; init; }

    /// <summary>
    /// We parse and analyze historical transaction metadata to identify the number of possible past returns due to unauthorized transactions over the past 30 days from the account that will be debited.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unauthorized_transactions_count_30d")]
    public int? UnauthorizedTransactionsCount30D { get; init; }

    /// <summary>
    /// We parse and analyze historical transaction metadata to identify the number of possible past returns due to unauthorized transactions over the past 60 days from the account that will be debited.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unauthorized_transactions_count_60d")]
    public int? UnauthorizedTransactionsCount60D { get; init; }

    /// <summary>
    /// We parse and analyze historical transaction metadata to identify the number of possible past returns due to unauthorized transactions over the past 90 days from the account that will be debited.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unauthorized_transactions_count_90d")]
    public int? UnauthorizedTransactionsCount90D { get; init; }

    /// <summary>
    /// We parse and analyze historical transaction metadata to identify the number of possible past returns due to non-sufficient funds/overdrafts over the past 7 days from the account that will be debited.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nsf_overdraft_transactions_count_7d")]
    public int? NsfOverdraftTransactionsCount7D { get; init; }

    /// <summary>
    /// We parse and analyze historical transaction metadata to identify the number of possible past returns due to non-sufficient funds/overdrafts over the past 30 days from the account that will be debited.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nsf_overdraft_transactions_count_30d")]
    public int? NsfOverdraftTransactionsCount30D { get; init; }

    /// <summary>
    /// We parse and analyze historical transaction metadata to identify the number of possible past returns due to non-sufficient funds/overdrafts over the past 60 days from the account that will be debited.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nsf_overdraft_transactions_count_60d")]
    public int? NsfOverdraftTransactionsCount60D { get; init; }

    /// <summary>
    /// We parse and analyze historical transaction metadata to identify the number of possible past returns due to non-sufficient funds/overdrafts over the past 90 days from the account that will be debited.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nsf_overdraft_transactions_count_90d")]
    public int? NsfOverdraftTransactionsCount90D { get; init; }

    /// <summary>
    /// The number of days since the first time the Item was connected to an application via Plaid
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_since_first_plaid_connection")]
    public int? DaysSinceFirstPlaidConnection { get; init; }

    /// <summary>
    /// The number of times the Item has been connected to applications via Plaid over the past 7 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("plaid_connections_count_7d")]
    public int? PlaidConnectionsCount7D { get; init; }

    /// <summary>
    /// The number of times the Item has been connected to applications via Plaid over the past 30 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("plaid_connections_count_30d")]
    public int? PlaidConnectionsCount30D { get; init; }

    /// <summary>
    /// The total number of times the Item has been connected to applications via Plaid
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_plaid_connections_count")]
    public int? TotalPlaidConnectionsCount { get; init; }

    /// <summary>
    /// Indicates if the ACH transaction funding account is a savings/money market account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_savings_or_money_market_account")]
    public bool? IsSavingsOrMoneyMarketAccount { get; init; }

    /// <summary>
    /// The total credit (inflow) transaction amount over the past 10 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_credit_transactions_amount_10d")]
    public double? TotalCreditTransactionsAmount10D { get; init; }

    /// <summary>
    /// The total debit (outflow) transaction amount over the past 10 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_debit_transactions_amount_10d")]
    public double? TotalDebitTransactionsAmount10D { get; init; }

    /// <summary>
    /// The 50th percentile of all credit (inflow) transaction amounts over the past 28 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p50_credit_transactions_amount_28d")]
    public double? P50CreditTransactionsAmount28D { get; init; }

    /// <summary>
    /// The 50th percentile of all debit (outflow) transaction amounts over the past 28 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p50_debit_transactions_amount_28d")]
    public double? P50DebitTransactionsAmount28D { get; init; }

    /// <summary>
    /// The 95th percentile of all credit (inflow) transaction amounts over the past 28 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p95_credit_transactions_amount_28d")]
    public double? P95CreditTransactionsAmount28D { get; init; }

    /// <summary>
    /// The 95th percentile of all debit (outflow) transaction amounts over the past 28 days from the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p95_debit_transactions_amount_28d")]
    public double? P95DebitTransactionsAmount28D { get; init; }

    /// <summary>
    /// The number of days within the past 90 days when the account that will be debited had a negative end-of-day available balance
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_with_negative_balance_count_90d")]
    public int? DaysWithNegativeBalanceCount90D { get; init; }

    /// <summary>
    /// The 90th percentile of the end-of-day available balance over the past 30 days of the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p90_eod_balance_30d")]
    public double? P90EodBalance30D { get; init; }

    /// <summary>
    /// The 90th percentile of the end-of-day available balance over the past 60 days of the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p90_eod_balance_60d")]
    public double? P90EodBalance60D { get; init; }

    /// <summary>
    /// The 90th percentile of the end-of-day available balance over the past 90 days of the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p90_eod_balance_90d")]
    public double? P90EodBalance90D { get; init; }

    /// <summary>
    /// The 10th percentile of the end-of-day available balance over the past 30 days of the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p10_eod_balance_30d")]
    public double? P10EodBalance30D { get; init; }

    /// <summary>
    /// The 10th percentile of the end-of-day available balance over the past 60 days of the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p10_eod_balance_60d")]
    public double? P10EodBalance60D { get; init; }

    /// <summary>
    /// The 10th percentile of the end-of-day available balance over the past 90 days of the account that will be debited
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("p10_eod_balance_90d")]
    public double? P10EodBalance90D { get; init; }

    /// <summary>
    /// Available balance, as of the <c>balance_last_updated</c> time. The available balance is the current balance less any outstanding holds or debits that have not yet posted to the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("available_balance")]
    public double? AvailableBalance { get; init; }

    /// <summary>
    /// Current balance, as of the <c>balance_last_updated</c> time. The current balance is the total amount of funds in the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("current_balance")]
    public double? CurrentBalance { get; init; }

    /// <summary>
    /// Timestamp in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DDTHH:mm:ssZ) indicating the last time that the balance for the given account has been updated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balance_last_updated")]
    public DateTimeOffset? BalanceLastUpdated { get; init; }

    /// <summary>
    /// The number of times the account's phone numbers on file have changed over the past 28 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_change_count_28d")]
    public int? PhoneChangeCount28D { get; init; }

    /// <summary>
    /// The number of times the account's phone numbers on file have changed over the past 90 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_change_count_90d")]
    public int? PhoneChangeCount90D { get; init; }

    /// <summary>
    /// The number of times the account's email addresses on file have changed over the past 28 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_change_count_28d")]
    public int? EmailChangeCount28D { get; init; }

    /// <summary>
    /// The number of times the account's email addresses on file have changed over the past 90 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_change_count_90d")]
    public int? EmailChangeCount90D { get; init; }

    /// <summary>
    /// The number of times the account's addresses on file have changed over the past 28 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address_change_count_28d")]
    public int? AddressChangeCount28D { get; init; }

    /// <summary>
    /// The number of times the account's addresses on file have changed over the past 90 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address_change_count_90d")]
    public int? AddressChangeCount90D { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
