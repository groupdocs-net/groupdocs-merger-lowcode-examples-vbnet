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

        ' Save page-2-of-business-plan.pdf and page-4-of-business-plan.pdf
        splitter.Save("output/page-{0}-of-business-plan.pdf")
    End Sub
End Module
