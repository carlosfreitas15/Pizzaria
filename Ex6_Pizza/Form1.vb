Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim precototal As Double = 0
        Dim quantidade As String = txtQuantidade.Text

        If (cmbPizza.Text = "Margarita") Then
            precototal = precototal + 6
        End If

        If (cmbPizza.Text = "Napolitana") Then
            precototal = precototal + 7
        End If

        If (cmbPizza.Text = "Anchovas") Then
            precototal = precototal + 8
        End If

        If cbxAzeitona.Checked Then
            precototal = precototal + 1
        End If

        If cbxQueijo.Checked Then
            precototal = precototal + 1
        End If

        If cbxPimento.Checked Then
            precototal = precototal + 2
        End If

        quantidade = CInt(Int(txtQuantidade.Text))
        precototal = precototal * quantidade



        If rdbSim.Checked Then
            precototal = precototal - (precototal * 0.1)
        End If

        txtPreco.Text = precototal
    End Sub
End Class
