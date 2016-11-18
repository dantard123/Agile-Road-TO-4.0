Public Class PrizeRedemption

    Private Sub lklblAddCustomer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklblAddCustomer.LinkClicked
        AddCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub lklblViewCustomer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklblViewCustomer.LinkClicked
        ViewCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub lklblEditCustomer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklblEditCustomer.LinkClicked
        EditCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub lklblDeleteCustomer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklblDeleteCustomer.LinkClicked
        DeleteCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub lklblPrizeRedemption_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklblPrizeRedemption.LinkClicked
        Me.Show()
    End Sub
End Class