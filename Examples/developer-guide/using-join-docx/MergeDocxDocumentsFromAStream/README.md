# Merge DOCX Documents from a Stream

The source document can also be a `Stream`; the documents to append are always file paths. The stream is read from the beginning, and it stays open after `Save`.

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
        Using stream = File.OpenRead("chapter-1.docx")
            ' Append the documents to the source document
            Dim merger As New JoinDocx(stream, {"chapter-2.docx"}, New JoinOptions())

            ' Save the merged document
            merger.Save("output/chapters-1-2.docx")
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

- `chapter-1.docx`
- `chapter-2.docx`

## Learn More

- [Using JoinDocx to Merge DOCX Documents](https://docs.groupdocs.net/merger/developer-guide/using-join-docx/) in the GroupDocs.Merger.LowCode documentation
- [GroupDocs.Merger.LowCode](https://www.nuget.org/packages/GroupDocs.Merger.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
