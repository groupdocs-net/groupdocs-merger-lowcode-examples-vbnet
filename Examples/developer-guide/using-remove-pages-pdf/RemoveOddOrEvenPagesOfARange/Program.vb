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
