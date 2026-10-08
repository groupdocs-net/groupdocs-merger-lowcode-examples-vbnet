# Handle an Unsupported Input Format

The following example passes a DOCX document to the `SplitPdf` plugin and prints the message of the exception.

## Code Example

```vb
Imports System
Imports GroupDocs.Merger.Exceptions
Imports GroupDocs.Merger.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply the license
        License.Set(publicKey, privateKey)

        Try
            ' A DOCX document passed to the PDF plugin
            Dim splitter As New SplitPdf("business-plan.docx", {1})
            splitter.Save("output/page.pdf")
        Catch ex As FileTypeNotSupportedException
            ' Input format does not match the expected format 'PDF'; the supplied file is ...
            Console.WriteLine(ex.Message)
        End Try
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

- `business-plan.docx`

## Learn More

- [Handling Errors](https://docs.groupdocs.net/merger/developer-guide/handling-errors/) in the GroupDocs.Merger.LowCode documentation
- [GroupDocs.Merger.LowCode](https://www.nuget.org/packages/GroupDocs.Merger.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
