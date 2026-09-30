using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// A representation of a transaction
/// </summary>
public record Transaction
{
    /// <summary>
    /// Please use the <c>payment_channel</c> field, <c>transaction_type</c> will be deprecated in the future.
    /// <para>
    /// <c>digital:</c> transactions that took place online.
    /// </para>
    /// <para>
    /// <c>place:</c> transactions that were made at a physical location.
    /// </para>
    /// <para>
    /// <c>special:</c> transactions that relate to banks, e.g. fees or deposits.
    /// </para>
    /// <para>
    /// <c>unresolved:</c> transactions that do not fit into the other three types.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transaction_type")]
    public TransactionType? TransactionType { get; init; }

    /// <summary>
    /// The ID of a posted transaction's associated pending transaction, where applicable.
    /// </summary>
    [JsonPropertyName("pending_transaction_id")]
    public required string? PendingTransactionId { get; init; }

    /// <summary>
    /// The ID of the category to which this transaction belongs. See <see href="https://plaid.com/docs/#category-overview">Categories</see>.
    /// <para>
    /// If the <c>transactions</c> object was returned by an Assets endpoint such as <c>/asset_report/get/</c> or <c>/asset_report/pdf/get</c>, this field will only appear in an Asset Report with Insights.
    /// </para>
    /// </summary>
    [JsonPropertyName("category_id")]
    public required string? CategoryId { get; init; }

    /// <summary>
    /// A hierarchical array of the categories to which this transaction belongs. See <see href="https://plaid.com/docs/#category-overview">Categories</see>.
    /// <para>
    /// If the <c>transactions</c> object was returned by an Assets endpoint such as <c>/asset_report/get/</c> or <c>/asset_report/pdf/get</c>, this field will only appear in an Asset Report with Insights.
    /// </para>
    /// </summary>
    [JsonPropertyName("category")]
    public required IReadOnlyList<string?> Category { get; init; }

    /// <summary>
    /// A representation of where a transaction took place
    /// </summary>
    [JsonPropertyName("location")]
    public required TransactionLocation Location { get; init; }

    /// <summary>
    /// Transaction information specific to inter-bank transfers. If the transaction was not an inter-bank transfer, all fields will be <c>null</c>.
    /// <para>
    /// If the <c>transactions</c> object was returned by a Transactions endpoint such as <c>/transactions/get</c>, the <c>payment_meta</c> key will always appear, but no data elements are guaranteed. If the <c>transactions</c> object was returned by an Assets endpoint such as <c>/asset_report/get/</c> or <c>/asset_report/pdf/get</c>, this field will only appear in an Asset Report with Insights.
    /// </para>
    /// </summary>
    [JsonPropertyName("payment_meta")]
    public required PaymentMeta PaymentMeta { get; init; }

    /// <summary>
    /// The name of the account owner. This field is not typically populated and only relevant when dealing with sub-accounts.
    /// </summary>
    [JsonPropertyName("account_owner")]
    public required string? AccountOwner { get; init; }

    /// <summary>
    /// The merchant name or transaction description.
    /// <para>
    /// If the <c>transactions</c> object was returned by a Transactions endpoint such as <c>/transactions/get</c>, this field will always appear. If the <c>transactions</c> object was returned by an Assets endpoint such as <c>/asset_report/get/</c> or <c>/asset_report/pdf/get</c>, this field will only appear in an Asset Report with Insights.
    /// </para>
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The string returned by the financial institution to describe the transaction. For transactions returned by <c>/transactions/get</c>, this field is in beta and will be omitted unless the client is both enrolled in the closed beta program and has set <c>options.include_original_description</c> to <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("original_description")]
    public string? OriginalDescription { get; init; }

    /// <summary>
    /// The ID of the account in which this transaction occurred.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The settled value of the transaction, denominated in the account's currency, as stated in <c>iso_currency_code</c> or <c>unofficial_currency_code</c>. Positive values when money moves out of the account; negative values when money moves in. For example, debit card purchases are positive; credit card payments, direct deposits, and refunds are negative.
    /// </summary>
    [JsonPropertyName("amount")]
    public required double Amount { get; init; }

    /// <summary>
    /// The ISO-4217 currency code of the transaction. Always <c>null</c> if <c>unofficial_currency_code</c> is non-null.
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string? IsoCurrencyCode { get; init; }

    /// <summary>
    /// The unofficial currency code associated with the transaction. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.
    /// <para>
    /// See the <see href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</see> for a full listing of supported <c>iso_currency_code</c>s.
    /// </para>
    /// </summary>
    [JsonPropertyName("unofficial_currency_code")]
    public required string? UnofficialCurrencyCode { get; init; }

    /// <summary>
    /// For pending transactions, the date that the transaction occurred; for posted transactions, the date that the transaction posted. Both dates are returned in an <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format ( <c>YYYY-MM-DD</c> ).
    /// </summary>
    [JsonPropertyName("date")]
    public required DateTimeOffset Date { get; init; }

    /// <summary>
    /// When <c>true</c>, identifies the transaction as pending or unsettled. Pending transaction details (name, type, amount, category ID) may change before they are settled.
    /// </summary>
    [JsonPropertyName("pending")]
    public required bool Pending { get; init; }

    /// <summary>
    /// The unique ID of the transaction. Like all Plaid identifiers, the <c>transaction_id</c> is case sensitive.
    /// </summary>
    [JsonPropertyName("transaction_id")]
    public required string TransactionId { get; init; }

    /// <summary>
    /// The channel used to make a payment.
    /// <c>online:</c> transactions that took place online.
    /// <para>
    /// <c>in store:</c> transactions that were made at a physical location.
    /// </para>
    /// <para>
    /// <c>other:</c> transactions that relate to banks, e.g. fees or deposits.
    /// </para>
    /// <para>
    /// This field replaces the <c>transaction_type</c> field.
    /// </para>
    /// </summary>
    [JsonPropertyName("payment_channel")]
    public required PaymentChannel PaymentChannel { get; init; }

    /// <summary>
    /// The merchant name, as extracted by Plaid from the <c>name</c> field.
    /// </summary>
    [JsonPropertyName("merchant_name")]
    public required string? MerchantName { get; init; }

    /// <summary>
    /// The date that the transaction was authorized. Dates are returned in an <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format ( <c>YYYY-MM-DD</c> ).
    /// </summary>
    [JsonPropertyName("authorized_date")]
    public required DateTimeOffset? AuthorizedDate { get; init; }

    /// <summary>
    /// Date and time when a transaction was authorized in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format ( <c>YYYY-MM-DDTHH:mm:ssZ</c> ).
    /// <para>
    /// This field is only populated for UK institutions. For institutions in other countries, will be <c>null</c>.
    /// </para>
    /// </summary>
    [JsonPropertyName("authorized_datetime")]
    public required DateTimeOffset? AuthorizedDatetime { get; init; }

    /// <summary>
    /// Date and time when a transaction was posted in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format ( <c>YYYY-MM-DDTHH:mm:ssZ</c> ).
    /// <para>
    /// This field is only populated for UK institutions. For institutions in other countries, will be <c>null</c>.
    /// </para>
    /// </summary>
    [JsonPropertyName("datetime")]
    public required DateTimeOffset? Datetime { get; init; }

    /// <summary>
    /// The check number of the transaction. This field is only populated for check transactions.
    /// </summary>
    [JsonPropertyName("check_number")]
    public required string? CheckNumber { get; init; }

    /// <summary>
    /// An identifier classifying the transaction type.
    /// <para>
    /// This field is only populated for European institutions. For institutions in the US and Canada, this field is set to <c>null</c>.
    /// </para>
    /// <para>
    /// <c>adjustment:</c> Bank adjustment
    /// </para>
    /// <para>
    /// <c>atm:</c> Cash deposit or withdrawal via an automated teller machine
    /// </para>
    /// <para>
    /// <c>bank charge:</c> Charge or fee levied by the institution
    /// </para>
    /// <para>
    /// <c>bill payment</c>: Payment of a bill
    /// </para>
    /// <para>
    /// <c>cash:</c> Cash deposit or withdrawal
    /// </para>
    /// <para>
    /// <c>cashback:</c> Cash withdrawal while making a debit card purchase
    /// </para>
    /// <para>
    /// <c>cheque:</c> Document ordering the payment of money to another person or organization
    /// </para>
    /// <para>
    /// <c>direct debit:</c> Automatic withdrawal of funds initiated by a third party at a regular interval
    /// </para>
    /// <para>
    /// <c>interest:</c> Interest earned or incurred
    /// </para>
    /// <para>
    /// <c>purchase:</c> Purchase made with a debit or credit card
    /// </para>
    /// <para>
    /// <c>standing order:</c> Payment instructed by the account holder to a third party at a regular interval
    /// </para>
    /// <para>
    /// <c>transfer:</c> Transfer of money between accounts
    /// </para>
    /// </summary>
    [JsonPropertyName("transaction_code")]
    public required TransactionCode TransactionCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("personal_finance_category")]
    public PersonalFinanceCategory2? PersonalFinanceCategory { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
