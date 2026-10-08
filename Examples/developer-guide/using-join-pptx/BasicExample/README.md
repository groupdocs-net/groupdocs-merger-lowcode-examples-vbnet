# Basic Example

The following example appends a 6-slide deck to a 7-slide deck. The presentations are loaded from the current folder, and the merged presentation is saved to the `output` folder.

## Code Example

```vb
Imports System
Imports GroupDocs.Merger.Domain.Options
Imports GroupDocs.Merger.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply the license
        License.Set(publicKey, privateKey)

        ' Append the documents to the source document
        Dim merger As New JoinPptx("deck-1.pptx", {"deck-2.pptx"}, New JoinOptions())

        ' Save the merged document
        merger.Save("output/merged-deck.pptx")
    End Sub
End Module
```

## How to Run

1. Install the .NET SDK for `net10.0`.
2. Set the `GD_PUBLIC_KEY` and `GD_PRIVATE_KEY` environment variables to your license keys.
3. Open this directory and run the example:
   ```bash
   dotnet run
   ```

## Input Files

- `deck-1.pptx`
- `deck-2.pptx`

## Learn More

- [Using JoinPptx to Merge PPTX Documents](https://docs.groupdocs.net/merger/developer-guide/using-join-pptx/) in the GroupDocs.Merger.LowCode documentation
- [GroupDocs.Merger.LowCode](https://www.nuget.org/packages/GroupDocs.Merger.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
