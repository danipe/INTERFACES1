Public Class Form1
    Dim Origen As Integer
    Dim Destino As String
    Private Sub Limpiar(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
    End Sub

    Private Sub Calcular(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButton1.Checked Then
            If RadioButton4.Checked Then
                TextBox2.Text = TextBox1.Text
            ElseIf RadioButton5.Checked Then
                TextBox2.Text = Convert.ToString(Convert.ToInt16(TextBox1.Text), 2)
            ElseIf RadioButton6.Checked Then
                TextBox2.Text = Convert.ToString(Convert.ToInt16(TextBox1.Text), 16)
            End If
        ElseIf RadioButton2.Checked Then
            Dim i As Integer
            i = Convert.ToInt32(TextBox1.Text, 2)
            If RadioButton4.Checked Then
                TextBox2.Text = i
            ElseIf RadioButton5.Checked Then
                TextBox2.Text = Convert.ToString(i, 2)
            ElseIf RadioButton6.Checked Then
                TextBox2.Text = Convert.ToString(i, 16)
            End If

        ElseIf RadioButton3.Checked Then
            Dim i As Integer
            i = Convert.ToInt32(TextBox1.Text, 16)
            If RadioButton4.Checked Then
                TextBox2.Text = i
            ElseIf RadioButton5.Checked Then
                TextBox2.Text = Convert.ToString(i, 2)
            ElseIf RadioButton6.Checked Then
                TextBox2.Text = Convert.ToString(i, 16)
            End If
        End If

    End Sub


End Class
