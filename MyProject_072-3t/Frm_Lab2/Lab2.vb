Public Class lab2
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles lblMis.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles lblVisMis.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vis, fri As Integer
        Dim toVis, ToFri, MisVis, MisFri, Total, Mis As Double
        vis = Val(txtVis.Text)
        fri = Val(txtFri.Text)
        MisVis = vis * 5 / 100
        MisFri = fri * 10 / 100
        Total = vis + fri
        Mis = MisVis + MisFri
        lblVis.Text = vis
        lblFri.Text = fri
        lblVisMis.Text = MisVis
        lblFriMis.Text = MisFri
        lblTotal.Text = Total
        lblMis.Text = Mis





    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub lblVis_Click(sender As Object, e As EventArgs) Handles lblVis.Click

    End Sub

    Private Sub txtFri_TextChanged(sender As Object, e As EventArgs) Handles txtFri.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub lblFri_Click(sender As Object, e As EventArgs) Handles lblFri.Click

    End Sub
End Class
