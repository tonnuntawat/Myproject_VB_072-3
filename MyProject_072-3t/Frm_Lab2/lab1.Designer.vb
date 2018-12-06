<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lab1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(193, 267)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(116, 23)
        Me.lblTotal.TabIndex = 21
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTax.Location = New System.Drawing.Point(193, 214)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(116, 23)
        Me.lblTax.TabIndex = 20
        '
        'lblSalary
        '
        Me.lblSalary.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSalary.Location = New System.Drawing.Point(193, 171)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(119, 33)
        Me.lblSalary.TabIndex = 19
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(300, 335)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 37)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "ปิด"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnCal
        '
        Me.btnCal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCal.Location = New System.Drawing.Point(135, 335)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(97, 37)
        Me.btnCal.TabIndex = 17
        Me.btnCal.Text = "คำนวณ"
        Me.btnCal.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 24)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "เงินสุทธิ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "ภาษี"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 24)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "เงินประจำปี"
        '
        'txtSalary
        '
        Me.txtSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(197, 97)
        Me.txtSalary.Multiline = True
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(178, 37)
        Me.txtSalary.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Input Salary>"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 31)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "คำนวณเงินเดือน"
        '
        'lab1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 450)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "lab1"
        Me.Text = "lab1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCal As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
