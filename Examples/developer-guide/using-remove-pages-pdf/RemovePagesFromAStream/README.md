# Remove Pages from a Stream

The source document can also be a `Stream`. It is read from the beginning, and it stays open after `Save`.

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
        Using stream = File.OpenRead("business-plan.pdf")
            ' Remove pages 2 and 4
            Dim remover As New RemovePagesPdf(stream, New RemoveOptions({2, 4}))

            ' Save the remaining pages
            remover.Save("output/trimmed.pdf")
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

- [Using RemovePagesPdf to Remove Pages from PDF Documents](https://docs.groupdocs.net/merger/developer-guide/using-remove-pages-pdf/) in the GroupDocs.Merger.LowCode documentation
- [GroupDocs.Merger.LowCode](https://www.nuget.org/packages/GroupDocs.Merger.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
