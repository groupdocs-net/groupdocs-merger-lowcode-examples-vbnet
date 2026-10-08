Imports System
Imports GroupDocs.Merger.Domain.Options
Imports GroupDocs.Merger.Exceptions
Imports GroupDocs.Merger.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply the license
        License.Set(publicKey, privateKey)

        Try
            ' The document has 18 pages
            Dim remover As New RemovePagesPdf("business-plan.pdf", New RemoveOptions({50}))
            remover.Save("output/trimmed.pdf")
        Catch ex As GroupDocsMergerException
            ' Page number more than page count.
            Console.WriteLine(ex.Message)
        End Try
    End Sub
End Module
