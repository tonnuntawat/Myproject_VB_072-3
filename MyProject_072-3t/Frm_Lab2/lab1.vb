Public Class lab1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub lblTax_Click(sender As Object, e As EventArgs) Handles lblTax.Click

    End Sub

    Private Sub lblSalary_Click(sender As Object, e As EventArgs) Handles lblSalary.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        lblSalary.Text = Val(txtSalary.Text)
        lblTax.Text = Val(txtSalary.Text) * 5 / 100
        lblTotal.Text = Val(lblSalary.Text) - Val(lblTax.Text)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSalary_TextChanged(sender As Object, e As EventArgs) Handles txtSalary.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub lab1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class