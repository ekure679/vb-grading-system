<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        lblGrade = New Label()
        TxtMarks = New TextBox()
        txtGrades = New TextBox()
        btnEvaluate = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(340, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 15)
        Label1.TabIndex = 0
        Label1.Text = "Grading system"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(169, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 15)
        Label2.TabIndex = 1
        Label2.Text = "Enter marks"
        ' 
        ' lblGrade
        ' 
        lblGrade.AutoSize = True
        lblGrade.Location = New Point(169, 178)
        lblGrade.Name = "lblGrade"
        lblGrade.Size = New Size(43, 15)
        lblGrade.TabIndex = 2
        lblGrade.Text = "Grades"
        ' 
        ' TxtMarks
        ' 
        TxtMarks.Location = New Point(303, 120)
        TxtMarks.Name = "TxtMarks"
        TxtMarks.Size = New Size(324, 23)
        TxtMarks.TabIndex = 3
        ' 
        ' txtGrades
        ' 
        txtGrades.Location = New Point(303, 178)
        txtGrades.Name = "txtGrades"
        txtGrades.Size = New Size(324, 23)
        txtGrades.TabIndex = 4
        ' 
        ' btnEvaluate
        ' 
        btnEvaluate.Location = New Point(317, 228)
        btnEvaluate.Name = "btnEvaluate"
        btnEvaluate.Size = New Size(304, 34)
        btnEvaluate.TabIndex = 5
        btnEvaluate.Text = "Evaluate"
        btnEvaluate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnEvaluate)
        Controls.Add(txtGrades)
        Controls.Add(TxtMarks)
        Controls.Add(lblGrade)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblGrade As Label
    Friend WithEvents TxtMarks As TextBox
    Friend WithEvents txtGrades As TextBox
    Friend WithEvents btnEvaluate As Button

End Class
