using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ProductDataType>))]
public sealed record ProductDataType : OpenStringEnum<ProductDataType>
{
    private ProductDataType(string value) : base(value)
    {
    }

    public static readonly ProductDataType AccountBalance = new("ACCOUNT_BALANCE");

    public static readonly ProductDataType AccountUserInfo = new("ACCOUNT_USER_INFO");

    public static readonly ProductDataType AccountTransactions = new("ACCOUNT_TRANSACTIONS");

    public TResult Match<TResult>(Func<TResult> onAccountBalance,
        Func<TResult> onAccountUserInfo,
        Func<TResult> onAccountTransactions,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AccountBalance => onAccountBalance(),
            _ when this == AccountUserInfo => onAccountUserInfo(),
            _ when this == AccountTransactions => onAccountTransactions(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccountBalance,
        Action onAccountUserInfo,
        Action onAccountTransactions,
        Action<string> otherwise)
    {
        if (this == AccountBalance) onAccountBalance();
        else if (this == AccountUserInfo) onAccountUserInfo();
        else if (this == AccountTransactions) onAccountTransactions();
        else otherwise(Value);
    }
}
