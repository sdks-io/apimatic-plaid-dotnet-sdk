using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A broad categorization of the error. Safe for programatic use.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ErrorType>))]
public sealed record ErrorType : OpenStringEnum<ErrorType>
{
    private ErrorType(string value) : base(value)
    {
    }

    public static readonly ErrorType InvalidRequest = new("INVALID_REQUEST");

    public static readonly ErrorType InvalidResult = new("INVALID_RESULT");

    public static readonly ErrorType InvalidInput = new("INVALID_INPUT");

    public static readonly ErrorType InstitutionError = new("INSTITUTION_ERROR");

    public static readonly ErrorType RateLimitExceeded = new("RATE_LIMIT_EXCEEDED");

    public static readonly ErrorType ApiError = new("API_ERROR");

    public static readonly ErrorType ItemError = new("ITEM_ERROR");

    public static readonly ErrorType AssetReportError = new("ASSET_REPORT_ERROR");

    public static readonly ErrorType RecaptchaError = new("RECAPTCHA_ERROR");

    public static readonly ErrorType OauthError = new("OAUTH_ERROR");

    public static readonly ErrorType PaymentError = new("PAYMENT_ERROR");

    public static readonly ErrorType BankTransferError = new("BANK_TRANSFER_ERROR");

    public TResult Match<TResult>(Func<TResult> onInvalidRequest,
        Func<TResult> onInvalidResult,
        Func<TResult> onInvalidInput,
        Func<TResult> onInstitutionError,
        Func<TResult> onRateLimitExceeded,
        Func<TResult> onApiError,
        Func<TResult> onItemError,
        Func<TResult> onAssetReportError,
        Func<TResult> onRecaptchaError,
        Func<TResult> onOauthError,
        Func<TResult> onPaymentError,
        Func<TResult> onBankTransferError,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == InvalidRequest => onInvalidRequest(),
            _ when this == InvalidResult => onInvalidResult(),
            _ when this == InvalidInput => onInvalidInput(),
            _ when this == InstitutionError => onInstitutionError(),
            _ when this == RateLimitExceeded => onRateLimitExceeded(),
            _ when this == ApiError => onApiError(),
            _ when this == ItemError => onItemError(),
            _ when this == AssetReportError => onAssetReportError(),
            _ when this == RecaptchaError => onRecaptchaError(),
            _ when this == OauthError => onOauthError(),
            _ when this == PaymentError => onPaymentError(),
            _ when this == BankTransferError => onBankTransferError(),
            _ => otherwise(Value)
        };

    public void Match(Action onInvalidRequest,
        Action onInvalidResult,
        Action onInvalidInput,
        Action onInstitutionError,
        Action onRateLimitExceeded,
        Action onApiError,
        Action onItemError,
        Action onAssetReportError,
        Action onRecaptchaError,
        Action onOauthError,
        Action onPaymentError,
        Action onBankTransferError,
        Action<string> otherwise)
    {
        if (this == InvalidRequest) onInvalidRequest();
        else if (this == InvalidResult) onInvalidResult();
        else if (this == InvalidInput) onInvalidInput();
        else if (this == InstitutionError) onInstitutionError();
        else if (this == RateLimitExceeded) onRateLimitExceeded();
        else if (this == ApiError) onApiError();
        else if (this == ItemError) onItemError();
        else if (this == AssetReportError) onAssetReportError();
        else if (this == RecaptchaError) onRecaptchaError();
        else if (this == OauthError) onOauthError();
        else if (this == PaymentError) onPaymentError();
        else if (this == BankTransferError) onBankTransferError();
        else otherwise(Value);
    }
}
