# Merge Documents with a Source Stream

The merge plugins (`JoinPdf`, `JoinDocx`, and `JoinPptx`) accept the source document as a path or a stream, but the documents to append are always file paths.

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
        Using stream = File.OpenRead("chapter-1.pdf")
            ' The documents to append are file paths
            Dim merger As New JoinPdf(stream, {"chapter-2.pdf", "chapter-3.pdf"}, New JoinOptions())

            ' Save the merged document
            merger.Save("output/merged-chapters.pdf")
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

- `chapter-1.pdf`
- `chapter-2.pdf`
- `chapter-3.pdf`

## Learn More

- [Loading Source Documents](https://docs.groupdocs.net/merger/developer-guide/loading-source-documents/) in the GroupDocs.Merger.LowCode documentation
- [GroupDocs.Merger.LowCode](https://www.nuget.org/packages/GroupDocs.Merger.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
