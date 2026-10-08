# Split Specific Pages into Separate Documents

The following example puts pages 1, 2, and 3 into documents of their own. Each part is numbered after the source page it holds: `page_1.docx`, `page_2.docx`, and `page_3.docx`.

## Code Example

```vb
Imports System
Imports GroupDocs.Merger.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply the license
        License.Set(publicKey, privateKey)

        ' Select pages 1, 2, and 3
        Dim splitter As New SplitDocx("business-plan.docx", {1, 2, 3})

        ' Save one document per part
        splitter.Save("output/page.docx")
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

- [Using SplitDocx to Split DOCX Documents](https://docs.groupdocs.net/merger/developer-guide/using-split-docx/) in the GroupDocs.Merger.LowCode documentation
- [GroupDocs.Merger.LowCode](https://www.nuget.org/packages/GroupDocs.Merger.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
