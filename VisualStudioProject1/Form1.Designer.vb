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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnDataType = New System.Windows.Forms.Button()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.btnNameGo = New System.Windows.Forms.Button()
        Me.lstOccupation = New System.Windows.Forms.ListBox()
        Me.lblOccupation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        ' 
        ' btnStart
        ' 
        Me.btnStart.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnStart.Location = New System.Drawing.Point(89, 362)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(207, 66)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Press here"
        Me.btnStart.UseVisualStyleBackColor = False
        ' 
        ' btnDataType
        ' 
        Me.btnDataType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDataType.Location = New System.Drawing.Point(381, 362)
        Me.btnDataType.Name = "btnDataType"
        Me.btnDataType.Size = New System.Drawing.Size(217, 61)
        Me.btnDataType.TabIndex = 1
        Me.btnDataType.Text = "datatype"
        Me.btnDataType.UseVisualStyleBackColor = False
        ' 
        ' txtFirstName
        ' 
        Me.txtFirstName.Location = New System.Drawing.Point(173, 35)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(316, 31)
        Me.txtFirstName.TabIndex = 2
        ' 
        ' lblFirstName
        ' 
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(23, 35)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(97, 25)
        Me.lblFirstName.TabIndex = 3
        Me.lblFirstName.Text = "First Name"
        ' 
        ' txtLastName
        ' 
        Me.txtLastName.Location = New System.Drawing.Point(173, 80)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(316, 31)
        Me.txtLastName.TabIndex = 4
        ' 
        ' lblLastName
        ' 
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(23, 80)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(95, 25)
        Me.lblLastName.TabIndex = 5
        Me.lblLastName.Text = "Last Name"
        ' 
        ' lblGender
        ' 
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(23, 129)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(69, 25)
        Me.lblGender.TabIndex = 6
        Me.lblGender.Text = "Gender"
        ' 
        ' txtGender
        ' 
        Me.txtGender.Location = New System.Drawing.Point(173, 129)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(316, 31)
        Me.txtGender.TabIndex = 7
        ' 
        ' btnNameGo
        ' 
        Me.btnNameGo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNameGo.Location = New System.Drawing.Point(706, 362)
        Me.btnNameGo.Name = "btnNameGo"
        Me.btnNameGo.Size = New System.Drawing.Size(112, 66)
        Me.btnNameGo.TabIndex = 8
        Me.btnNameGo.Text = "Go"
        Me.btnNameGo.UseVisualStyleBackColor = False
        ' 
        ' lstOccupation
        ' 
        Me.lstOccupation.FormattingEnabled = True
        Me.lstOccupation.ItemHeight = 25
        Me.lstOccupation.Items.AddRange(New Object() {"Doctor", "Teacher", "Pilot", "Entrepreneur", "Athelete"})
        Me.lstOccupation.Location = New System.Drawing.Point(638, 37)
        Me.lstOccupation.Name = "lstOccupation"
        Me.lstOccupation.Size = New System.Drawing.Size(180, 179)
        Me.lstOccupation.TabIndex = 9
        ' 
        ' lblOccupation
        ' 
        Me.lblOccupation.AutoSize = True
        Me.lblOccupation.Location = New System.Drawing.Point(638, 9)
        Me.lblOccupation.Name = "lblOccupation"
        Me.lblOccupation.Size = New System.Drawing.Size(103, 25)
        Me.lblOccupation.TabIndex = 10
        Me.lblOccupation.Text = "Occupation"
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 450)
        Me.Controls.Add(Me.lblOccupation)
        Me.Controls.Add(Me.lstOccupation)
        Me.Controls.Add(Me.btnNameGo)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.btnDataType)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnDataType As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents btnNameGo As Button
    Friend WithEvents lstOccupation As ListBox
    Friend WithEvents lblOccupation As Label

End Class
