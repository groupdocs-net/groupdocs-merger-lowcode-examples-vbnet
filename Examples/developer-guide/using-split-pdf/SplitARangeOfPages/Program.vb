Imports System
Imports GroupDocs.Merger.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply the license
        License.Set(publicKey, privateKey)

        ' Select pages 2 to 4
        Dim splitter As New SplitPdf("business-plan.pdf", 2, 4)

        ' Save one document per part
        splitter.Save("output/page.pdf")
    End Sub
End Module
