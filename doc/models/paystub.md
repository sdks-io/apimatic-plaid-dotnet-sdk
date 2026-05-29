
# Paystub

An object representing data extracted from the end user's paystub.

*This model accepts additional fields of type object.*

## Structure

`Paystub`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Deductions` | [`Deductions`](../../doc/models/deductions.md) | Optional | An object with the deduction information found on a paystub. |
| `DocId` | `string` | Optional | An identifier of the document referenced by the document metadata. |
| `Earnings` | [`Earnings`](../../doc/models/earnings.md) | Optional | An object representing both a breakdown of earnings on a paystub and the total earnings. |
| `Employer` | [`Employer2`](../../doc/models/employer-2.md) | Required | - |
| `Employee` | [`Employee`](../../doc/models/employee.md) | Required | Data about the employee. |
| `EmploymentDetails` | [`EmploymentDetails`](../../doc/models/employment-details.md) | Optional | An object representing employment details found on a paystub. |
| `NetPay` | [`NetPay`](../../doc/models/net-pay.md) | Optional | An object representing information about the net pay amount on the paystub. |
| `PayPeriodDetails` | [`PayPeriodDetails`](../../doc/models/pay-period-details.md) | Required | Details about the pay period. |
| `PaystubDetails` | [`PaystubDetails`](../../doc/models/paystub-details.md) | Optional | An object representing details that can be found on the paystub. |
| `IncomeBreakdown` | [`List<IncomeBreakdown>`](../../doc/models/income-breakdown.md) | Required | - |
| `YtdEarnings` | [`PaystubYtdDetails`](../../doc/models/paystub-ytd-details.md) | Required | The amount of income earned year to date, as based on paystub data. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "employer": {
    "name": "name2",
    "address": {
      "city": "city6",
      "street": "street6",
      "line1": "line18",
      "line2": "line20",
      "postal_code": "postal_code8",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "employee": {
    "name": "name8",
    "address": {
      "city": "city6",
      "street": "street6",
      "line1": "line18",
      "line2": "line20",
      "postal_code": "postal_code8",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "marital_status": "marital_status6",
    "taxpayer_id": {
      "id_type": "id_type8",
      "last_4_digits": "last_4_digits6",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "pay_period_details": {
    "start_date": "2016-03-13",
    "end_date": "2016-03-13",
    "pay_day": "2016-03-13",
    "gross_earnings": 59.04,
    "check_amount": 134.86,
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "income_breakdown": [
    {
      "type": "bonus",
      "rate": 29.56,
      "hours": 6.52,
      "total": 118.76,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "ytd_earnings": {
    "gross_earnings": 4.84,
    "net_earnings": 206.94,
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "deductions": {
    "subtotals": [
      {
        "canonical_description": "OVERTIME",
        "description": "description8",
        "current_pay": {
          "amount": 45.16,
          "currency": "currency4",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        "ytd_pay": {
          "amount": 28.98,
          "currency": "currency0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      }
    ],
    "totals": [
      {
        "canonical_description": "BONUS",
        "description": "description8",
        "current_pay": {
          "amount": 45.16,
          "currency": "currency4",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        "ytd_pay": {
          "amount": 28.98,
          "currency": "currency0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      {
        "canonical_description": "BONUS",
        "description": "description8",
        "current_pay": {
          "amount": 45.16,
          "currency": "currency4",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        "ytd_pay": {
          "amount": 28.98,
          "currency": "currency0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      {
        "canonical_description": "BONUS",
        "description": "description8",
        "current_pay": {
          "amount": 45.16,
          "currency": "currency4",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        "ytd_pay": {
          "amount": 28.98,
          "currency": "currency0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      }
    ],
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "doc_id": "doc_id2",
  "earnings": {
    "subtotals": [
      {
        "canonical_description": "OVERTIME",
        "description": "description8",
        "current_pay": {
          "amount": 45.16,
          "currency": "currency4",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        "ytd_pay": {
          "amount": 28.98,
          "currency": "currency0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        "current_hours": "current_hours0",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      }
    ],
    "totals": [
      {
        "canonical_description": "BONUS",
        "description": "description8",
        "current_pay": {
          "amount": 45.16,
          "currency": "currency4",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        "ytd_pay": {
          "amount": 28.98,
          "currency": "currency0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        "current_hours": "current_hours4",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      {
        "canonical_description": "BONUS",
        "description": "description8",
        "current_pay": {
          "amount": 45.16,
          "currency": "currency4",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        "ytd_pay": {
          "amount": 28.98,
          "currency": "currency0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        "current_hours": "current_hours4",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      {
        "canonical_description": "BONUS",
        "description": "description8",
        "current_pay": {
          "amount": 45.16,
          "currency": "currency4",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        "ytd_pay": {
          "amount": 28.98,
          "currency": "currency0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        "current_hours": "current_hours4",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      }
    ],
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "employment_details": {
    "annual_salary": {
      "amount": 106.22,
      "currency": "currency0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "hire_date": "2016-03-13",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "net_pay": {
    "distribution_details": [
      {
        "account_number": "account_number0",
        "bank_account_type": "bank_account_type8",
        "bank_name": "bank_name4",
        "current_pay": {
          "amount": 45.16,
          "currency": "currency4",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        "description": "description0",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      {
        "account_number": "account_number0",
        "bank_account_type": "bank_account_type8",
        "bank_name": "bank_name4",
        "current_pay": {
          "amount": 45.16,
          "currency": "currency4",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        "description": "description0",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      }
    ],
    "total": {
      "canonical_description": "NOT_FOUND",
      "description": "description0",
      "current_pay": {
        "amount": 45.16,
        "currency": "currency4",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      "ytd_pay": {
        "amount": 28.98,
        "currency": "currency0",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

