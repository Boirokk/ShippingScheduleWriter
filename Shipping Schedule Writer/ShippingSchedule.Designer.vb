<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShippingSchedule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShippingSchedule))
        Me.addItem = New System.Windows.Forms.Button()
        Me.sItems = New System.Windows.Forms.Button()
        Me.tbAddText = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnMoveD = New System.Windows.Forms.Button()
        Me.btnMoveUp = New System.Windows.Forms.Button()
        Me.deleteItem = New System.Windows.Forms.Button()
        Me.tbDate = New System.Windows.Forms.TextBox()
        Me.tbdeck = New System.Windows.Forms.TextBox()
        Me.tbjob = New System.Windows.Forms.TextBox()
        Me.tbwo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'addItem
        '
        Me.addItem.ForeColor = System.Drawing.Color.Black
        Me.addItem.Location = New System.Drawing.Point(199, 355)
        Me.addItem.Name = "addItem"
        Me.addItem.Size = New System.Drawing.Size(75, 23)
        Me.addItem.TabIndex = 4
        Me.addItem.TabStop = False
        Me.addItem.Text = "Add"
        Me.addItem.UseVisualStyleBackColor = True
        '
        'sItems
        '
        Me.sItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sItems.ForeColor = System.Drawing.Color.Black
        Me.sItems.Location = New System.Drawing.Point(653, 355)
        Me.sItems.Name = "sItems"
        Me.sItems.Size = New System.Drawing.Size(75, 23)
        Me.sItems.TabIndex = 4
        Me.sItems.Text = "Save"
        Me.sItems.UseVisualStyleBackColor = True
        '
        'tbAddText
        '
        Me.tbAddText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbAddText.Location = New System.Drawing.Point(174, 394)
        Me.tbAddText.Name = "tbAddText"
        Me.tbAddText.Size = New System.Drawing.Size(635, 20)
        Me.tbAddText.TabIndex = 1
        Me.tbAddText.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(260, 9)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(549, 329)
        Me.ListBox1.TabIndex = 3
        Me.ListBox1.TabStop = False
        '
        'btnMoveD
        '
        Me.btnMoveD.ForeColor = System.Drawing.Color.Black
        Me.btnMoveD.Location = New System.Drawing.Point(49, 391)
        Me.btnMoveD.Name = "btnMoveD"
        Me.btnMoveD.Size = New System.Drawing.Size(75, 23)
        Me.btnMoveD.TabIndex = 6
        Me.btnMoveD.Text = "Move down"
        Me.btnMoveD.UseVisualStyleBackColor = True
        '
        'btnMoveUp
        '
        Me.btnMoveUp.ForeColor = System.Drawing.Color.Black
        Me.btnMoveUp.Location = New System.Drawing.Point(49, 356)
        Me.btnMoveUp.Name = "btnMoveUp"
        Me.btnMoveUp.Size = New System.Drawing.Size(75, 23)
        Me.btnMoveUp.TabIndex = 5
        Me.btnMoveUp.Text = "Move up"
        Me.btnMoveUp.UseVisualStyleBackColor = True
        '
        'deleteItem
        '
        Me.deleteItem.ForeColor = System.Drawing.Color.Black
        Me.deleteItem.Location = New System.Drawing.Point(361, 355)
        Me.deleteItem.Name = "deleteItem"
        Me.deleteItem.Size = New System.Drawing.Size(75, 23)
        Me.deleteItem.TabIndex = 7
        Me.deleteItem.Text = "Delete"
        Me.deleteItem.UseVisualStyleBackColor = True
        '
        'tbDate
        '
        Me.tbDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDate.Location = New System.Drawing.Point(174, 420)
        Me.tbDate.Name = "tbDate"
        Me.tbDate.Size = New System.Drawing.Size(100, 20)
        Me.tbDate.TabIndex = 0
        '
        'tbdeck
        '
        Me.tbdeck.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbdeck.Location = New System.Drawing.Point(599, 420)
        Me.tbdeck.Name = "tbdeck"
        Me.tbdeck.Size = New System.Drawing.Size(210, 20)
        Me.tbdeck.TabIndex = 3
        '
        'tbjob
        '
        Me.tbjob.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbjob.Location = New System.Drawing.Point(345, 420)
        Me.tbjob.Name = "tbjob"
        Me.tbjob.Size = New System.Drawing.Size(248, 20)
        Me.tbjob.TabIndex = 2
        '
        'tbwo
        '
        Me.tbwo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbwo.Location = New System.Drawing.Point(280, 420)
        Me.tbwo.Name = "tbwo"
        Me.tbwo.Size = New System.Drawing.Size(59, 20)
        Me.tbwo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(595, 443)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "DECK AREA"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.Color.Transparent
        Me.lbl3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl3.Location = New System.Drawing.Point(342, 443)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(61, 13)
        Me.lbl3.TabIndex = 13
        Me.lbl3.Text = "JOB NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(277, 443)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "WO#"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(173, 443)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "DAY / DATE"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.CalendarDimensions = New System.Drawing.Size(1, 2)
        Me.MonthCalendar1.Location = New System.Drawing.Point(18, 18)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 20
        Me.MonthCalendar1.TabStop = False
        '
        'btnclose
        '
        Me.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnclose.ForeColor = System.Drawing.Color.Black
        Me.btnclose.Location = New System.Drawing.Point(734, 355)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 21
        Me.btnclose.Text = "Cancel"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.Location = New System.Drawing.Point(280, 355)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 22
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'ShippingSchedule
        '
        Me.AcceptButton = Me.addItem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(825, 463)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.sItems)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbwo)
        Me.Controls.Add(Me.tbjob)
        Me.Controls.Add(Me.tbdeck)
        Me.Controls.Add(Me.tbDate)
        Me.Controls.Add(Me.deleteItem)
        Me.Controls.Add(Me.btnMoveD)
        Me.Controls.Add(Me.btnMoveUp)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.addItem)
        Me.Controls.Add(Me.tbAddText)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ShippingSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shipping Schedule"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents addItem As System.Windows.Forms.Button
    Friend WithEvents sItems As System.Windows.Forms.Button
    Friend WithEvents tbAddText As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnMoveD As System.Windows.Forms.Button
    Friend WithEvents btnMoveUp As System.Windows.Forms.Button
    Friend WithEvents deleteItem As System.Windows.Forms.Button
    Friend WithEvents tbDate As System.Windows.Forms.TextBox
    Friend WithEvents tbdeck As System.Windows.Forms.TextBox
    Friend WithEvents tbjob As System.Windows.Forms.TextBox
    Friend WithEvents tbwo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button

End Class
