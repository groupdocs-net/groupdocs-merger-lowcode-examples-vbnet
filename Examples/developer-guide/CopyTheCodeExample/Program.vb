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

        ' Append the cost analysis to the business plan
        Dim merger As New JoinPdf("business-plan.pdf", {"cost-analysis.pdf"}, New JoinOptions())

        ' Save the merged document
        merger.Save("output/business-plan-with-costs.pdf")
    End Sub
End Module
