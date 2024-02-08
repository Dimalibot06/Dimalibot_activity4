Public Class Form1
    Private Sub btndivision_Click(sender As Object, e As EventArgs) Handles btndivision.Click
        Dim a As Integer
        Dim b As Integer
        a = txtfirstnum.Text
        b = txtsecondnum.Text
        lblresult.Text = a / b
    End Sub
End Class
