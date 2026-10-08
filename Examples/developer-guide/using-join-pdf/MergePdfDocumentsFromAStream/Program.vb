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
            ' Append the documents to the source document
            Dim merger As New JoinPdf(stream, {"cost-analysis.pdf"}, New JoinOptions())

            ' Save the merged document
            merger.Save("output/business-plan-with-costs.pdf")
        End Using
    End Sub
End Module
