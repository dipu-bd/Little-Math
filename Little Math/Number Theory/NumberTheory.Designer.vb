<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NumberTheory
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.FactorialResult = New System.Windows.Forms.TextBox
        Me.ProgPanel = New System.Windows.Forms.Panel
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.FactorialButton = New System.Windows.Forms.Button
        Me.Value = New System.Windows.Forms.TextBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.PrimeListRes = New System.Windows.Forms.TextBox
        Me.ShowListButton = New System.Windows.Forms.Button
        Me.PrimeListLimit = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.CheckPrimeRes = New System.Windows.Forms.Label
        Me.CheckPrimeButton = New System.Windows.Forms.Button
        Me.PNumValue = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DivisorRes = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.FactorRes = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.FactDivButton = New System.Windows.Forms.Button
        Me.FactDivVAL = New System.Windows.Forms.TextBox
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.CopyAllNumbersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ProgPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(349, 412)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(341, 384)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Factorial"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.FactorialResult)
        Me.GroupBox1.Controls.Add(Me.ProgPanel)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(335, 344)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Factorial Result"
        '
        'FactorialResult
        '
        Me.FactorialResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.FactorialResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FactorialResult.Font = New System.Drawing.Font("Cambria", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FactorialResult.ForeColor = System.Drawing.Color.Black
        Me.FactorialResult.Location = New System.Drawing.Point(3, 19)
        Me.FactorialResult.Multiline = True
        Me.FactorialResult.Name = "FactorialResult"
        Me.FactorialResult.ReadOnly = True
        Me.FactorialResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.FactorialResult.Size = New System.Drawing.Size(329, 306)
        Me.FactorialResult.TabIndex = 2
        '
        'ProgPanel
        '
        Me.ProgPanel.Controls.Add(Me.ProgressBar1)
        Me.ProgPanel.Controls.Add(Me.Label1)
        Me.ProgPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgPanel.Location = New System.Drawing.Point(3, 325)
        Me.ProgPanel.Name = "ProgPanel"
        Me.ProgPanel.Size = New System.Drawing.Size(329, 16)
        Me.ProgPanel.TabIndex = 4
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.White
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.Location = New System.Drawing.Point(23, 0)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(306, 16)
        Me.ProgressBar1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "0%"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MistyRose
        Me.Panel1.Controls.Add(Me.FactorialButton)
        Me.Panel1.Controls.Add(Me.Value)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(335, 34)
        Me.Panel1.TabIndex = 1
        '
        'FactorialButton
        '
        Me.FactorialButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FactorialButton.Location = New System.Drawing.Point(278, 5)
        Me.FactorialButton.Name = "FactorialButton"
        Me.FactorialButton.Size = New System.Drawing.Size(53, 24)
        Me.FactorialButton.TabIndex = 1
        Me.FactorialButton.Text = "OK"
        Me.FactorialButton.UseVisualStyleBackColor = True
        '
        'Value
        '
        Me.Value.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Value.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Value.Font = New System.Drawing.Font("Cambria", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Value.ForeColor = System.Drawing.Color.Gray
        Me.Value.Location = New System.Drawing.Point(5, 5)
        Me.Value.Name = "Value"
        Me.Value.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Value.Size = New System.Drawing.Size(267, 24)
        Me.Value.TabIndex = 0
        Me.Value.Text = "Insert an integer and Click OK"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(341, 384)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Prime Number"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox5.Controls.Add(Me.PrimeListRes)
        Me.GroupBox5.Controls.Add(Me.ShowListButton)
        Me.GroupBox5.Controls.Add(Me.PrimeListLimit)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(3, 103)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(335, 278)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "List of primes"
        '
        'PrimeListRes
        '
        Me.PrimeListRes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrimeListRes.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PrimeListRes.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrimeListRes.Location = New System.Drawing.Point(7, 71)
        Me.PrimeListRes.Multiline = True
        Me.PrimeListRes.Name = "PrimeListRes"
        Me.PrimeListRes.ReadOnly = True
        Me.PrimeListRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.PrimeListRes.Size = New System.Drawing.Size(322, 201)
        Me.PrimeListRes.TabIndex = 4
        '
        'ShowListButton
        '
        Me.ShowListButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowListButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowListButton.Location = New System.Drawing.Point(281, 23)
        Me.ShowListButton.Name = "ShowListButton"
        Me.ShowListButton.Size = New System.Drawing.Size(51, 41)
        Me.ShowListButton.TabIndex = 3
        Me.ShowListButton.Text = "Show List"
        Me.ShowListButton.UseVisualStyleBackColor = True
        '
        'PrimeListLimit
        '
        Me.PrimeListLimit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrimeListLimit.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PrimeListLimit.Font = New System.Drawing.Font("Cambria", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrimeListLimit.ForeColor = System.Drawing.Color.Gray
        Me.PrimeListLimit.Location = New System.Drawing.Point(6, 23)
        Me.PrimeListLimit.Multiline = True
        Me.PrimeListLimit.Name = "PrimeListLimit"
        Me.PrimeListLimit.Size = New System.Drawing.Size(269, 41)
        Me.PrimeListLimit.TabIndex = 2
        Me.PrimeListLimit.Text = "Insert limits. Like 1 to 100, 300-500,1023 to 1055"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FloralWhite
        Me.GroupBox4.Controls.Add(Me.CheckPrimeRes)
        Me.GroupBox4.Controls.Add(Me.CheckPrimeButton)
        Me.GroupBox4.Controls.Add(Me.PNumValue)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(335, 100)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Check a number if prime"
        '
        'CheckPrimeRes
        '
        Me.CheckPrimeRes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckPrimeRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CheckPrimeRes.Font = New System.Drawing.Font("Lucida Calligraphy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckPrimeRes.ForeColor = System.Drawing.Color.Maroon
        Me.CheckPrimeRes.Location = New System.Drawing.Point(6, 53)
        Me.CheckPrimeRes.Name = "CheckPrimeRes"
        Me.CheckPrimeRes.Size = New System.Drawing.Size(326, 40)
        Me.CheckPrimeRes.TabIndex = 2
        Me.CheckPrimeRes.Text = "No number given"
        Me.CheckPrimeRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckPrimeButton
        '
        Me.CheckPrimeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckPrimeButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckPrimeButton.Location = New System.Drawing.Point(281, 22)
        Me.CheckPrimeButton.Name = "CheckPrimeButton"
        Me.CheckPrimeButton.Size = New System.Drawing.Size(51, 23)
        Me.CheckPrimeButton.TabIndex = 1
        Me.CheckPrimeButton.Text = "Check"
        Me.CheckPrimeButton.UseVisualStyleBackColor = True
        '
        'PNumValue
        '
        Me.PNumValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PNumValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PNumValue.Font = New System.Drawing.Font("Cambria", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PNumValue.ForeColor = System.Drawing.Color.Gray
        Me.PNumValue.Location = New System.Drawing.Point(6, 22)
        Me.PNumValue.Name = "PNumValue"
        Me.PNumValue.Size = New System.Drawing.Size(269, 24)
        Me.PNumValue.TabIndex = 0
        Me.PNumValue.Text = "Insert a number to check"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(341, 384)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Factor and Divisors"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FloralWhite
        Me.GroupBox2.Controls.Add(Me.DivisorRes)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(335, 245)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Divisors"
        '
        'DivisorRes
        '
        Me.DivisorRes.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DivisorRes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DivisorRes.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DivisorRes.Location = New System.Drawing.Point(3, 19)
        Me.DivisorRes.Multiline = True
        Me.DivisorRes.Name = "DivisorRes"
        Me.DivisorRes.ReadOnly = True
        Me.DivisorRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DivisorRes.Size = New System.Drawing.Size(329, 223)
        Me.DivisorRes.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Beige
        Me.GroupBox3.Controls.Add(Me.FactorRes)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(3, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(335, 100)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Factors"
        '
        'FactorRes
        '
        Me.FactorRes.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.FactorRes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FactorRes.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FactorRes.Location = New System.Drawing.Point(3, 19)
        Me.FactorRes.Multiline = True
        Me.FactorRes.Name = "FactorRes"
        Me.FactorRes.ReadOnly = True
        Me.FactorRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.FactorRes.Size = New System.Drawing.Size(329, 78)
        Me.FactorRes.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Wheat
        Me.Panel2.Controls.Add(Me.FactDivButton)
        Me.Panel2.Controls.Add(Me.FactDivVAL)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(335, 33)
        Me.Panel2.TabIndex = 3
        '
        'FactDivButton
        '
        Me.FactDivButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FactDivButton.Location = New System.Drawing.Point(289, 5)
        Me.FactDivButton.Name = "FactDivButton"
        Me.FactDivButton.Size = New System.Drawing.Size(42, 23)
        Me.FactDivButton.TabIndex = 1
        Me.FactDivButton.Text = "OK"
        Me.FactDivButton.UseVisualStyleBackColor = True
        '
        'FactDivVAL
        '
        Me.FactDivVAL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FactDivVAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FactDivVAL.Font = New System.Drawing.Font("Cambria", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FactDivVAL.ForeColor = System.Drawing.Color.Gray
        Me.FactDivVAL.Location = New System.Drawing.Point(5, 5)
        Me.FactDivVAL.Name = "FactDivVAL"
        Me.FactDivVAL.Size = New System.Drawing.Size(278, 24)
        Me.FactDivVAL.TabIndex = 0
        Me.FactDivVAL.Text = "Insert an integer and Click OK"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveToolStripMenuItem, Me.ClearAllToolStripMenuItem, Me.ToolStripSeparator1, Me.CopyAllNumbersToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(172, 76)
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ClearAllToolStripMenuItem.Text = "Clear All"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(168, 6)
        '
        'CopyAllNumbersToolStripMenuItem
        '
        Me.CopyAllNumbersToolStripMenuItem.Name = "CopyAllNumbersToolStripMenuItem"
        Me.CopyAllNumbersToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CopyAllNumbersToolStripMenuItem.Text = "Copy All Numbers"
        '
        'BackgroundWorker2
        '
        Me.BackgroundWorker2.WorkerReportsProgress = True
        Me.BackgroundWorker2.WorkerSupportsCancellation = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(289, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox4.Font = New System.Drawing.Font("Cambria", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.Gray
        Me.TextBox4.Location = New System.Drawing.Point(5, 5)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(278, 24)
        Me.TextBox4.TabIndex = 0
        Me.TextBox4.Text = "Insert an integer and Click OK"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'NumberTheory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "NumberTheory"
        Me.Size = New System.Drawing.Size(349, 412)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ProgPanel.ResumeLayout(False)
        Me.ProgPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FactorialButton As System.Windows.Forms.Button
    Friend WithEvents Value As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents FactorialResult As System.Windows.Forms.TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgPanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CopyAllNumbersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DivisorRes As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents FactorRes As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents FactDivButton As System.Windows.Forms.Button
    Friend WithEvents FactDivVAL As System.Windows.Forms.TextBox
    Friend WithEvents CheckPrimeButton As System.Windows.Forms.Button
    Friend WithEvents PNumValue As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckPrimeRes As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ShowListButton As System.Windows.Forms.Button
    Friend WithEvents PrimeListLimit As System.Windows.Forms.TextBox
    Friend WithEvents PrimeListRes As System.Windows.Forms.TextBox

End Class
