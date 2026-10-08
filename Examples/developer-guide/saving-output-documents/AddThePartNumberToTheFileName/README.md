# Add the Part Number to the File Name

The following example splits out pages 2 and 4 and saves them to a plain path, so the page numbers are added to the file name: `business-plan_2.pdf` and `business-plan_4.pdf`.

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

        ' Select pages 2 and 4
        Dim splitter As New SplitPdf("business-plan.pdf", {2, 4})

        ' Save business-plan_2.pdf and business-plan_4.pdf
        splitter.Save("output/business-plan.pdf")
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

- [Saving Output Documents](https://docs.groupdocs.net/merger/developer-guide/saving-output-documents/) in the GroupDocs.Merger.LowCode documentation
- [GroupDocs.Merger.LowCode](https://www.nuget.org/packages/GroupDocs.Merger.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
