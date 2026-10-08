# Load a Document from a Stream

Pass a `Stream` that contains the source document. The plugin reads the stream from the beginning, regardless of its current position, so pass a stream whose content starts at offset 0. The stream stays open after `Save`; disposing of it remains your responsibility.

## Code Example

```vb
Imports System
Imports System.IO
Imports GroupDocs.Merger.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply the license
        License.Set(publicKey, privateKey)

        ' Open the source document as a stream
        Using stream = File.OpenRead("business-plan.pdf")
            ' Load the source document from the stream
            Dim splitter As New SplitPdf(stream, {1, 2})

            ' Save one document per page
            splitter.Save("output/page.pdf")
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

- `business-plan.pdf`

## Learn More

- [Loading Source Documents](https://docs.groupdocs.net/merger/developer-guide/loading-source-documents/) in the GroupDocs.Merger.LowCode documentation
- [GroupDocs.Merger.LowCode](https://www.nuget.org/packages/GroupDocs.Merger.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
