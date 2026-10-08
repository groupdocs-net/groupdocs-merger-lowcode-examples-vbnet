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

        ' Remove pages 15 to 18
        Dim remover As New RemovePagesPdf("business-plan.pdf", New RemoveOptions(15, 18))

        ' Save the remaining pages
        remover.Save("output/without-appendix.pdf")
    End Sub
End Module
