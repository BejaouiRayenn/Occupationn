Public Class Form1
    Private Sub btngo_Click(sender As Object, e As EventArgs) Handles btngo.Click
        Dim stfirstname As String
        Dim stlastname As String
        Dim stgender As String
        Dim stoccupation As String
        stfirstname = txtFirstname.Text
        stlastname = Txtlastname.Text
        stgender = TxtGender.Text
        If Lstoccupation.SelectedItems.Count > 0 Then
            stoccupation = Lstoccupation.SelectedItems(0).Text
        Else
            stoccupation = "No occupation selected "
        End If
        MessageBox.Show("Hello " & stfirstname & " " &
                       stlastname & "you are a  " & stgender & " : " & stoccupation)






    End Sub
End Class
