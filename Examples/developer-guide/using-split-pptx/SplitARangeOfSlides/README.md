# Split a Range of Slides

Pass the first and the last slide of a range to put every slide of the range into a document of its own. The following example splits out slides 2 to 4.

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

        ' Select slides 2 to 4
        Dim splitter As New SplitPptx("presentation.pptx", 2, 4)

        ' Save one document per part
        splitter.Save("output/slide.pptx")
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

- `presentation.pptx`

## Learn More

- [Using SplitPptx to Split PPTX Documents](https://docs.groupdocs.net/merger/developer-guide/using-split-pptx/) in the GroupDocs.Merger.LowCode documentation
- [GroupDocs.Merger.LowCode](https://www.nuget.org/packages/GroupDocs.Merger.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
