
# Transaction Code

An identifier classifying the transaction type.

This field is only populated for European institutions. For institutions in the US and Canada, this field is set to `null`.

`adjustment:` Bank adjustment

`atm:` Cash deposit or withdrawal via an automated teller machine

`bank charge:` Charge or fee levied by the institution

`bill payment`: Payment of a bill

`cash:` Cash deposit or withdrawal

`cashback:` Cash withdrawal while making a debit card purchase

`cheque:` Document ordering the payment of money to another person or organization

`direct debit:` Automatic withdrawal of funds initiated by a third party at a regular interval

`interest:` Interest earned or incurred

`purchase:` Purchase made with a debit or credit card

`standing order:` Payment instructed by the account holder to a third party at a regular interval

`transfer:` Transfer of money between accounts

*This model accepts additional fields of type object.*

## Enumeration

`TransactionCode`

## Fields

| Name |
|  --- |
| `Adjustment` |
| `Atm` |
| `EnumBankCharge` |
| `EnumBillPayment` |
| `Cash` |
| `Cashback` |
| `Cheque` |
| `EnumDirectDebit` |
| `Interest` |
| `Purchase` |
| `EnumStandingOrder` |
| `Transfer` |

