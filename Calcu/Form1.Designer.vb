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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.clear = New System.Windows.Forms.Button()
        Me.clearAll = New System.Windows.Forms.Button()
        Me.equalBtn = New System.Windows.Forms.Button()
        Me.plus = New System.Windows.Forms.Button()
        Me.minus = New System.Windows.Forms.Button()
        Me.multiply = New System.Windows.Forms.Button()
        Me.divide = New System.Windows.Forms.Button()
        Me.period = New System.Windows.Forms.Button()
        Me.postiveNegative = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.display = New System.Windows.Forms.TextBox()
        Me.historyDisplay = New System.Windows.Forms.TextBox()
        Me.subDisplay = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.emptyHistory = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.IconButton2)
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(209, 26)
        Me.Panel1.TabIndex = 0
        '
        'IconButton2
        '
        Me.IconButton2.AutoEllipsis = True
        Me.IconButton2.BackColor = System.Drawing.Color.Transparent
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.CompressArrowsAlt
        Me.IconButton2.IconColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 20
        Me.IconButton2.Location = New System.Drawing.Point(137, 3)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(31, 23)
        Me.IconButton2.TabIndex = 1
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Multiply
        Me.IconButton1.IconColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 20
        Me.IconButton1.Location = New System.Drawing.Point(174, 4)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(32, 23)
        Me.IconButton1.TabIndex = 0
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.clear)
        Me.Panel2.Controls.Add(Me.clearAll)
        Me.Panel2.Controls.Add(Me.equalBtn)
        Me.Panel2.Controls.Add(Me.plus)
        Me.Panel2.Controls.Add(Me.minus)
        Me.Panel2.Controls.Add(Me.multiply)
        Me.Panel2.Controls.Add(Me.divide)
        Me.Panel2.Controls.Add(Me.period)
        Me.Panel2.Controls.Add(Me.postiveNegative)
        Me.Panel2.Controls.Add(Me.Button0)
        Me.Panel2.Controls.Add(Me.Button9)
        Me.Panel2.Controls.Add(Me.Button8)
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(1, 137)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(209, 263)
        Me.Panel2.TabIndex = 3
        '
        'clear
        '
        Me.clear.BackColor = System.Drawing.Color.Transparent
        Me.clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear.FlatAppearance.BorderSize = 0
        Me.clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear.Font = New System.Drawing.Font("Design", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.clear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.clear.Location = New System.Drawing.Point(103, 23)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(38, 40)
        Me.clear.TabIndex = 25
        Me.clear.Text = "«"
        Me.clear.UseVisualStyleBackColor = False
        '
        'clearAll
        '
        Me.clearAll.BackColor = System.Drawing.Color.Transparent
        Me.clearAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearAll.FlatAppearance.BorderSize = 0
        Me.clearAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.clearAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.clearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearAll.Font = New System.Drawing.Font("Electro Shackle", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.clearAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.clearAll.Location = New System.Drawing.Point(15, 23)
        Me.clearAll.Name = "clearAll"
        Me.clearAll.Size = New System.Drawing.Size(82, 40)
        Me.clearAll.TabIndex = 24
        Me.clearAll.Text = "empty"
        Me.clearAll.UseVisualStyleBackColor = False
        '
        'equalBtn
        '
        Me.equalBtn.BackColor = System.Drawing.Color.Transparent
        Me.equalBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.equalBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.equalBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.equalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.equalBtn.Font = New System.Drawing.Font("Colonna MT", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.equalBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.equalBtn.Location = New System.Drawing.Point(147, 207)
        Me.equalBtn.Name = "equalBtn"
        Me.equalBtn.Size = New System.Drawing.Size(38, 40)
        Me.equalBtn.TabIndex = 23
        Me.equalBtn.Text = "="
        Me.equalBtn.UseVisualStyleBackColor = False
        '
        'plus
        '
        Me.plus.BackColor = System.Drawing.Color.Transparent
        Me.plus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.plus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.plus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.plus.Font = New System.Drawing.Font("Colonna MT", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.plus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.plus.Location = New System.Drawing.Point(147, 161)
        Me.plus.Name = "plus"
        Me.plus.Size = New System.Drawing.Size(38, 40)
        Me.plus.TabIndex = 23
        Me.plus.Text = "+"
        Me.plus.UseVisualStyleBackColor = False
        '
        'minus
        '
        Me.minus.BackColor = System.Drawing.Color.Transparent
        Me.minus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.minus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minus.Font = New System.Drawing.Font("Colonna MT", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.minus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.minus.Location = New System.Drawing.Point(147, 115)
        Me.minus.Name = "minus"
        Me.minus.Size = New System.Drawing.Size(38, 40)
        Me.minus.TabIndex = 23
        Me.minus.Text = "-"
        Me.minus.UseVisualStyleBackColor = False
        '
        'multiply
        '
        Me.multiply.BackColor = System.Drawing.Color.Transparent
        Me.multiply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.multiply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.multiply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.multiply.Font = New System.Drawing.Font("Colonna MT", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.multiply.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.multiply.Location = New System.Drawing.Point(147, 69)
        Me.multiply.Name = "multiply"
        Me.multiply.Size = New System.Drawing.Size(38, 40)
        Me.multiply.TabIndex = 23
        Me.multiply.Text = "x"
        Me.multiply.UseVisualStyleBackColor = False
        '
        'divide
        '
        Me.divide.BackColor = System.Drawing.Color.Transparent
        Me.divide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.divide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.divide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.divide.Font = New System.Drawing.Font("Colonna MT", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.divide.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.divide.Location = New System.Drawing.Point(147, 20)
        Me.divide.Name = "divide"
        Me.divide.Size = New System.Drawing.Size(38, 40)
        Me.divide.TabIndex = 23
        Me.divide.Text = "/"
        Me.divide.UseVisualStyleBackColor = False
        '
        'period
        '
        Me.period.BackColor = System.Drawing.Color.Transparent
        Me.period.Cursor = System.Windows.Forms.Cursors.Hand
        Me.period.FlatAppearance.BorderSize = 0
        Me.period.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.period.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.period.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.period.Font = New System.Drawing.Font("Colonna MT", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.period.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.period.Location = New System.Drawing.Point(103, 207)
        Me.period.Name = "period"
        Me.period.Size = New System.Drawing.Size(38, 40)
        Me.period.TabIndex = 19
        Me.period.Text = "."
        Me.period.UseVisualStyleBackColor = False
        '
        'postiveNegative
        '
        Me.postiveNegative.BackColor = System.Drawing.Color.Transparent
        Me.postiveNegative.Cursor = System.Windows.Forms.Cursors.Hand
        Me.postiveNegative.FlatAppearance.BorderSize = 0
        Me.postiveNegative.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.postiveNegative.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.postiveNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.postiveNegative.Font = New System.Drawing.Font("Colonna MT", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.postiveNegative.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.postiveNegative.Location = New System.Drawing.Point(15, 207)
        Me.postiveNegative.Name = "postiveNegative"
        Me.postiveNegative.Size = New System.Drawing.Size(38, 40)
        Me.postiveNegative.TabIndex = 19
        Me.postiveNegative.Text = "±"
        Me.postiveNegative.UseVisualStyleBackColor = False
        '
        'Button0
        '
        Me.Button0.BackColor = System.Drawing.Color.Transparent
        Me.Button0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button0.FlatAppearance.BorderSize = 0
        Me.Button0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button0.Font = New System.Drawing.Font("Design", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button0.Location = New System.Drawing.Point(59, 207)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(38, 40)
        Me.Button0.TabIndex = 19
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Design", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button9.Location = New System.Drawing.Point(103, 161)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(38, 40)
        Me.Button9.TabIndex = 16
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Design", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(59, 161)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(38, 40)
        Me.Button8.TabIndex = 15
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Design", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(15, 161)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(38, 40)
        Me.Button7.TabIndex = 14
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Design", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(103, 115)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(38, 40)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Design", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(59, 115)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(38, 40)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Design", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(15, 115)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(38, 40)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Design", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(103, 69)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(38, 40)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Design", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(59, 69)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 40)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Design", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(15, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 40)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'display
        '
        Me.display.BackColor = System.Drawing.Color.Black
        Me.display.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.display.Font = New System.Drawing.Font("Design", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.display.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.display.Location = New System.Drawing.Point(45, 114)
        Me.display.MaxLength = 7
        Me.display.Multiline = True
        Me.display.Name = "display"
        Me.display.ReadOnly = True
        Me.display.ShortcutsEnabled = False
        Me.display.Size = New System.Drawing.Size(153, 28)
        Me.display.TabIndex = 5
        Me.display.Text = "0"
        Me.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.display.WordWrap = False
        '
        'historyDisplay
        '
        Me.historyDisplay.BackColor = System.Drawing.Color.Black
        Me.historyDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.historyDisplay.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.historyDisplay.ForeColor = System.Drawing.Color.White
        Me.historyDisplay.Location = New System.Drawing.Point(26, 33)
        Me.historyDisplay.Multiline = True
        Me.historyDisplay.Name = "historyDisplay"
        Me.historyDisplay.ReadOnly = True
        Me.historyDisplay.ShortcutsEnabled = False
        Me.historyDisplay.Size = New System.Drawing.Size(172, 55)
        Me.historyDisplay.TabIndex = 6
        Me.historyDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'subDisplay
        '
        Me.subDisplay.BackColor = System.Drawing.Color.Black
        Me.subDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.subDisplay.Font = New System.Drawing.Font("Design", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.subDisplay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subDisplay.Location = New System.Drawing.Point(16, 94)
        Me.subDisplay.Multiline = True
        Me.subDisplay.Name = "subDisplay"
        Me.subDisplay.ReadOnly = True
        Me.subDisplay.ShortcutsEnabled = False
        Me.subDisplay.Size = New System.Drawing.Size(186, 14)
        Me.subDisplay.TabIndex = 5
        Me.subDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Black
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Design", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.TextBox4.Location = New System.Drawing.Point(16, 114)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.ShortcutsEnabled = False
        Me.TextBox4.Size = New System.Drawing.Size(23, 17)
        Me.TextBox4.TabIndex = 7
        Me.TextBox4.Text = "="
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'emptyHistory
        '
        Me.emptyHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.emptyHistory.FlatAppearance.BorderSize = 0
        Me.emptyHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.emptyHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.emptyHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.emptyHistory.Font = New System.Drawing.Font("Barlow Condensed", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.emptyHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.emptyHistory.IconChar = FontAwesome.Sharp.IconChar.None
        Me.emptyHistory.IconColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.emptyHistory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.emptyHistory.IconSize = 25
        Me.emptyHistory.Location = New System.Drawing.Point(4, 12)
        Me.emptyHistory.Name = "emptyHistory"
        Me.emptyHistory.Size = New System.Drawing.Size(21, 96)
        Me.emptyHistory.TabIndex = 24
        Me.emptyHistory.Text = "e" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "m" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "p" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "t" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y"
        Me.emptyHistory.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(210, 401)
        Me.Controls.Add(Me.emptyHistory)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.historyDisplay)
        Me.Controls.Add(Me.subDisplay)
        Me.Controls.Add(Me.display)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button0 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents display As TextBox
    Friend WithEvents historyDisplay As TextBox
    Friend WithEvents subDisplay As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents divide As Button
    Friend WithEvents equalBtn As Button
    Friend WithEvents plus As Button
    Friend WithEvents minus As Button
    Friend WithEvents multiply As Button
    Friend WithEvents period As Button
    Friend WithEvents postiveNegative As Button
    Friend WithEvents emptyHistory As FontAwesome.Sharp.IconButton
    Friend WithEvents clear As Button
    Friend WithEvents clearAll As Button
End Class
