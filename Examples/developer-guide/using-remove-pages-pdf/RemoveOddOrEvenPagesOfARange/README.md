# Remove Odd or Even Pages of a Range

Add a `RangeMode` to narrow the range to its odd or even pages. The following example removes the even pages from 1 to 6: pages 2, 4, and 6.

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

        ' Remove the even pages from 1 to 6
        Dim remover As New RemovePagesPdf("business-plan.pdf", New RemoveOptions(1, 6, RangeMode.EvenPages))

        ' Save the remaining pages
        remover.Save("output/without-even-pages.pdf")
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
