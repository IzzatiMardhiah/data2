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
        Me.cmdClick = New System.Windows.Forms.Button()
        Me.lbEnter = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblpoliname = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdClick
        '
        Me.cmdClick.Location = New System.Drawing.Point(342, 189)
        Me.cmdClick.Name = "cmdClick"
        Me.cmdClick.Size = New System.Drawing.Size(83, 25)
        Me.cmdClick.TabIndex = 0
        Me.cmdClick.Text = "CLICK HERE"
        Me.cmdClick.UseVisualStyleBackColor = True
        '
        'lbEnter
        '
        Me.lbEnter.AutoSize = True
        Me.lbEnter.Location = New System.Drawing.Point(89, 134)
        Me.lbEnter.Name = "lbEnter"
        Me.lbEnter.Size = New System.Drawing.Size(94, 15)
        Me.lbEnter.TabIndex = 1
        Me.lbEnter.Text = "Enter your name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(205, 131)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(220, 23)
        Me.txtName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Result :"
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(205, 284)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(220, 23)
        Me.lblOutput.TabIndex = 4
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(205, 160)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(220, 23)
        Me.txtState.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter your state"
        '
        'lblpoliname
        '
        Me.lblpoliname.AutoSize = True
        Me.lblpoliname.Location = New System.Drawing.Point(85, 324)
        Me.lblpoliname.Name = "lblpoliname"
        Me.lblpoliname.Size = New System.Drawing.Size(10, 15)
        Me.lblpoliname.TabIndex = 7
        Me.lblpoliname.Text = " "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblpoliname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lbEnter)
        Me.Controls.Add(Me.cmdClick)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdClick As Button
    Friend WithEvents lbEnter As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblOutput As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblpoliname As Label
End Class
