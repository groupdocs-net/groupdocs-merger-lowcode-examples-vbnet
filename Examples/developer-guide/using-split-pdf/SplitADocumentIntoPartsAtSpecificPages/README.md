# Split a Document into Parts at Specific Pages

In `SplitMode.Interval`, the pages you list mark where each new part starts. The following example cuts an 18-page document before pages 7 and 13: `chapter_0.pdf` holds pages 1 to 6, `chapter_1.pdf` holds pages 7 to 12, and `chapter_2.pdf` holds pages 13 to 18. Interval parts are numbered from 0.

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

        ' Start a new part at pages 7 and 13
        Dim splitter As New SplitPdf("business-plan.pdf", {7, 13}, SplitMode.Interval)

        ' Save one document per part
        splitter.Save("output/chapter.pdf")
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

- [Using SplitPdf to Split PDF Documents](https://docs.groupdocs.net/merger/developer-guide/using-split-pdf/) in the GroupDocs.Merger.LowCode documentation
- [GroupDocs.Merger.LowCode](https://www.nuget.org/packages/GroupDocs.Merger.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
