
# Document Metadata

An object representing metadata from the end user's uploaded document.

*This model accepts additional fields of type object.*

## Structure

`DocumentMetadata`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | The name of the document. |
| `Status` | `string` | Optional | The processing status of the document. |
| `DocId` | `string` | Optional | An identifier of the document that is also present in the paystub response. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name4",
  "status": "status6",
  "doc_id": "doc_id8",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

