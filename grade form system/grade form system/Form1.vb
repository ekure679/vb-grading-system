Public Class Form1
    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        Dim marks As Integer

        'input validation for marks to ensure numeric input
        If Not Integer.TryParse(TxtMarks.Text, marks) Then
            MessageBox.Show("Please enter  Valid numeric value for marks")
        End If

        If marks > 100 Then
            MessageBox.Show("wrong entry, please try again")

        End If
        ' using select case method to input marks
        Select Case marks
            Case 90 To 100
                txtGrades.Text = "Excellent"

            Case 80 To 89
                txtGrades.Text = "very good"

            Case 70 To 79
                txtGrades.Text = "Good"

            Case 60 To 69
                txtGrades.Text = "medium"
            Case 50 To 59
                txtGrades.Text = "pass"
            Case 0 To 49
                txtGrades.Text = "Fail"
            Case Else
                txtGrades.Text = "Invalid Marks"
        End Select

    End Sub



End Class
