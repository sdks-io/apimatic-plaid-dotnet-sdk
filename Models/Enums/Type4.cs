using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Value is one of the following:
/// <c>buy</c>: Buying an investment
/// <c>sell</c>: Selling an investment
/// <c>cancel</c>: A cancellation of a pending transaction
/// <c>cash</c>: Activity that modifies a cash position
/// <c>fee</c>: A fee on the account
/// <c>transfer</c>: Activity which modifies a position, but not through buy/sell activity e.g. options exercise, portfolio transfer
/// <para>
/// For descriptions of possible transaction types and subtypes, see the <see href="https://plaid.com/docs/api/accounts/#investment-transaction-types-schema">Investment transaction types schema</see>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type4>))]
public sealed record Type4 : OpenStringEnum<Type4>
{
    private Type4(string value) : base(value)
    {
    }

    public static readonly Type4 Buy = new("buy");

    public static readonly Type4 Sell = new("sell");

    public static readonly Type4 Cancel = new("cancel");

    public static readonly Type4 Cash = new("cash");

    public static readonly Type4 Fee = new("fee");

    public static readonly Type4 Transfer = new("transfer");

    public TResult Match<TResult>(Func<TResult> onBuy,
        Func<TResult> onSell,
        Func<TResult> onCancel,
        Func<TResult> onCash,
        Func<TResult> onFee,
        Func<TResult> onTransfer,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Buy => onBuy(),
            _ when this == Sell => onSell(),
            _ when this == Cancel => onCancel(),
            _ when this == Cash => onCash(),
            _ when this == Fee => onFee(),
            _ when this == Transfer => onTransfer(),
            _ => otherwise(Value)
        };

    public void Match(Action onBuy,
        Action onSell,
        Action onCancel,
        Action onCash,
        Action onFee,
        Action onTransfer,
        Action<string> otherwise)
    {
        if (this == Buy) onBuy();
        else if (this == Sell) onSell();
        else if (this == Cancel) onCancel();
        else if (this == Cash) onCash();
        else if (this == Fee) onFee();
        else if (this == Transfer) onTransfer();
        else otherwise(Value);
    }
}
