# Merge PPTX Documents from a Stream

The source presentation can also be a `Stream`; the presentations to append are always file paths. The stream is read from the beginning, and it stays open after `Save`.

## Code Example

```vb
Imports System
Imports System.IO
Imports GroupDocs.Merger.Domain.Options
Imports GroupDocs.Merger.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply the license
        License.Set(publicKey, privateKey)

        ' Open the source document as a stream
        Using stream = File.OpenRead("deck-1.pptx")
            ' Append the documents to the source document
            Dim merger As New JoinPptx(stream, {"deck-2.pptx"}, New JoinOptions())

            ' Save the merged document
            merger.Save("output/merged-deck.pptx")
        End Using
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
