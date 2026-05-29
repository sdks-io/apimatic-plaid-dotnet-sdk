
# Incident Update

*This model accepts additional fields of type object.*

## Structure

`IncidentUpdate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | The content of the update. |
| `Status` | [`Status1?`](../../doc/models/status-1.md) | Optional | The status of the incident. |
| `UpdatedDate` | `DateTime?` | Optional | The date when the update was published, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format, e.g. `"2020-10-30T15:26:48Z"`. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "description": "description8",
  "status": "INVESTIGATING",
  "updated_date": "2016-03-13T12:52:32.123Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

