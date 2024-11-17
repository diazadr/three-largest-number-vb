Imports System.Reflection.Emit

Public Class Form1

    Dim nomor1, nomor2, nomor3 As Double

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim angka1 As Integer = Integer.Parse(TextBox1.Text)
        Dim angka2 As Integer = Integer.Parse(TextBox2.Text)
        Dim angka3 As Integer = Integer.Parse(TextBox3.Text)

        Dim terbesar As Integer
        If angka1 >= angka2 AndAlso angka1 >= angka3 Then
            terbesar = angka1
        ElseIf angka2 >= angka1 AndAlso angka2 >= angka3 Then
            terbesar = angka2
        Else
            terbesar = angka3
        End If
        Label1.Text = "Angka terbesar (variabel lokal): " & terbesar.ToString()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nomor1 = CDbl(TextBox1.Text)
        nomor2 = CDbl(TextBox2.Text)
        nomor3 = CDbl(TextBox3.Text)
        Dim terbesarGlobal As Integer

        If nomor1 >= nomor2 AndAlso nomor1 >= nomor3 Then
            terbesarGlobal = nomor1
        ElseIf nomor2 >= nomor1 AndAlso nomor2 >= nomor3 Then
            terbesarGlobal = nomor2
        Else
            terbesarGlobal = nomor3
        End If

        Label2.Text = "Angka terbesar (variabel global): " & terbesarGlobal.ToString()
    End Sub

End Class
