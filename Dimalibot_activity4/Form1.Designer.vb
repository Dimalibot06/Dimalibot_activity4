<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        txtfirstnum = New TextBox()
        txtsecondnum = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btndivision = New Button()
        lblresult = New Label()
        SuspendLayout()
        ' 
        ' txtfirstnum
        ' 
        txtfirstnum.Location = New Point(147, 34)
        txtfirstnum.Name = "txtfirstnum"
        txtfirstnum.Size = New Size(100, 23)
        txtfirstnum.TabIndex = 0
        ' 
        ' txtsecondnum
        ' 
        txtsecondnum.Location = New Point(147, 86)
        txtsecondnum.Name = "txtsecondnum"
        txtsecondnum.Size = New Size(100, 23)
        txtsecondnum.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(48, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 2
        Label1.Text = "First number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(53, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 15)
        Label2.TabIndex = 3
        Label2.Text = "Second number"
        ' 
        ' btndivision
        ' 
        btndivision.Location = New Point(183, 144)
        btndivision.Name = "btndivision"
        btndivision.Size = New Size(75, 23)
        btndivision.TabIndex = 4
        btndivision.Text = "Division"
        btndivision.UseVisualStyleBackColor = True
        ' 
        ' lblresult
        ' 
        lblresult.AutoSize = True
        lblresult.Location = New Point(137, 208)
        lblresult.Name = "lblresult"
        lblresult.Size = New Size(41, 15)
        lblresult.TabIndex = 5
        lblresult.Text = "Label3"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblresult)
        Controls.Add(btndivision)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtsecondnum)
        Controls.Add(txtfirstnum)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtfirstnum As TextBox
    Friend WithEvents txtsecondnum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btndivision As Button
    Friend WithEvents lblresult As Label
End Class
