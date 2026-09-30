using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The method used to make the deposit switch.
/// <list type="bullet">
///   <item><description><c>instant</c> – User instantly switched their direct deposit to a new or existing bank account by connecting their payroll or employer account.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>mail</c> – User requested that Plaid contact their employer by mail to make the direct deposit switch.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>pdf</c> – User generated a PDF or email to be sent to their employer with the information necessary to make the deposit switch.'</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SwitchMethod>))]
public sealed record SwitchMethod : OpenStringEnum<SwitchMethod>
{
    private SwitchMethod(string value) : base(value)
    {
    }

    public static readonly SwitchMethod Instant = new("instant");

    public static readonly SwitchMethod Mail = new("mail");

    public static readonly SwitchMethod Pdf = new("pdf");

    public TResult Match<TResult>(Func<TResult> onInstant,
        Func<TResult> onMail,
        Func<TResult> onPdf,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Instant => onInstant(),
            _ when this == Mail => onMail(),
            _ when this == Pdf => onPdf(),
            _ => otherwise(Value)
        };

    public void Match(Action onInstant, Action onMail, Action onPdf, Action<string> otherwise)
    {
        if (this == Instant) onInstant();
        else if (this == Mail) onMail();
        else if (this == Pdf) onPdf();
        else otherwise(Value);
    }
}
