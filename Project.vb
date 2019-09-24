
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = “alien titties”
        Me.BackColor = Color.Cyan
        Me.Opacity = 0.5
        Me.Size = New Size(1920, 1080)
        MaximizeBox = True
        BackgroundImage = Image.FromFile("C:\Users\pnowy11\Pictures\GiornoSans.png")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("50" & "+" & "50" & "-" & "20" & "*" & "2" & "=" & 50 + 50 - 20 * 2)

    End Sub

    Private Sub JoJo_Protagonists_SelectedIndexChanged(sender As Object, e As EventArgs) Handles JoJo.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
    Dim myitem As String

    Private Sub InputBox_TextChanged(sender As Object, e As EventArgs) Handles InputBox.TextChanged


    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim counter As Integer
        Do While counter <= 1000
            Label3.Text = counter
            counter += 1
        Loop
    End Sub
End Class