Imports System
Imports System.IO
Imports GroupDocs.Merger.Domain.Options
Imports GroupDocs.Merger.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply the license
        License.Set(publicKey, privateKey)

        ' Open the source document as a stream
        Using stream = File.OpenRead("business-plan.pdf")
            ' Remove pages 2 and 4
            Dim remover As New RemovePagesPdf(stream, New RemoveOptions({2, 4}))

            ' Save the remaining pages
            remover.Save("output/trimmed.pdf")
        End Using
    End Sub
End Module
