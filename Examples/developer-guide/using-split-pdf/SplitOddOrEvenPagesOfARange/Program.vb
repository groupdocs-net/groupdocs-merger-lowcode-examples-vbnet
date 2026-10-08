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

        ' Select the even pages from 1 to 6
        Dim splitter As New SplitPdf("business-plan.pdf", 1, 6, RangeMode.EvenPages)

        ' Save one document per part
        splitter.Save("output/even-page.pdf")
    End Sub
End Module
