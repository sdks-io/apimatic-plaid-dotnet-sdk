
# Health Incident

*This model accepts additional fields of type object.*

## Structure

`HealthIncident`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartDate` | `DateTime` | Required | The start date of the incident, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format, e.g. `"2020-10-30T15:26:48Z"`. |
| `EndDate` | `DateTime?` | Optional | The end date of the incident, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format, e.g. `"2020-10-30T15:26:48Z"`. |
| `Title` | `string` | Required | The title of the incident |
| `IncidentUpdates` | [`List<IncidentUpdate>`](../../doc/models/incident-update.md) | Required | Updates on the health incident. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "start_date": "2016-03-13T12:52:32.123Z",
  "title": "title6",
  "incident_updates": [
    {
      "description": "description2",
      "status": "UNKNOWN",
      "updated_date": "2016-03-13T12:52:32.123Z",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "end_date": "2016-03-13T12:52:32.123Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

