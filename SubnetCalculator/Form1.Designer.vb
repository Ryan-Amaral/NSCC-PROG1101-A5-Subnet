<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSubnetCalculator
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
        Me.MenuStripSubnetForm = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBoxNetworkInformation = New System.Windows.Forms.GroupBox()
        Me.TextBoxCalculatedSubnetSize = New System.Windows.Forms.TextBox()
        Me.TextBoxInputNetworkAddress = New System.Windows.Forms.TextBox()
        Me.TextBoxInputHostsPerSubnet = New System.Windows.Forms.TextBox()
        Me.LabelCalculatedSubnetSize = New System.Windows.Forms.Label()
        Me.LabelHostsPerSubnet = New System.Windows.Forms.Label()
        Me.LabelNetworkAddress = New System.Windows.Forms.Label()
        Me.GroupBoxListOfIpRanges = New System.Windows.Forms.GroupBox()
        Me.ListBoxIpRanges = New System.Windows.Forms.ListBox()
        Me.GroupBoxAddressInformation = New System.Windows.Forms.GroupBox()
        Me.TextBoxHexOctets = New System.Windows.Forms.TextBox()
        Me.TextBoxBinaryOctets = New System.Windows.Forms.TextBox()
        Me.TextBoxDecimalOctets = New System.Windows.Forms.TextBox()
        Me.TextBoxDecimalAddress = New System.Windows.Forms.TextBox()
        Me.LabelHexOctets = New System.Windows.Forms.Label()
        Me.LabelBinaryOctets = New System.Windows.Forms.Label()
        Me.LabelDecimalAddress = New System.Windows.Forms.Label()
        Me.LabelDecimalOctets = New System.Windows.Forms.Label()
        Me.GroupBoxNetmaskInformation = New System.Windows.Forms.GroupBox()
        Me.TextBoxSubnets = New System.Windows.Forms.TextBox()
        Me.TextBoxBinaryMask = New System.Windows.Forms.TextBox()
        Me.TextBoxSubnetMask = New System.Windows.Forms.TextBox()
        Me.TextBoxNetworkClass = New System.Windows.Forms.TextBox()
        Me.TextBoxIpAddresses = New System.Windows.Forms.TextBox()
        Me.LabelSubnets = New System.Windows.Forms.Label()
        Me.LabelBinaryMask = New System.Windows.Forms.Label()
        Me.LabelSubnetMask = New System.Windows.Forms.Label()
        Me.LabelIpAddresses = New System.Windows.Forms.Label()
        Me.LabelNetworkClass = New System.Windows.Forms.Label()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.OpenFileDialogSubnetForm = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialogSubnetForm = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStripSubnetForm.SuspendLayout()
        Me.GroupBoxNetworkInformation.SuspendLayout()
        Me.GroupBoxListOfIpRanges.SuspendLayout()
        Me.GroupBoxAddressInformation.SuspendLayout()
        Me.GroupBoxNetmaskInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripSubnetForm
        '
        Me.MenuStripSubnetForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStripSubnetForm.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripSubnetForm.Name = "MenuStripSubnetForm"
        Me.MenuStripSubnetForm.Size = New System.Drawing.Size(632, 24)
        Me.MenuStripSubnetForm.TabIndex = 0
        Me.MenuStripSubnetForm.Text = "MenuStripSubnetForm"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.OpenToolStripMenuItem.Text = "Open..."
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(160, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CalculateToolStripMenuItem.Text = "Calculate"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'GroupBoxNetworkInformation
        '
        Me.GroupBoxNetworkInformation.Controls.Add(Me.TextBoxCalculatedSubnetSize)
        Me.GroupBoxNetworkInformation.Controls.Add(Me.TextBoxInputNetworkAddress)
        Me.GroupBoxNetworkInformation.Controls.Add(Me.TextBoxInputHostsPerSubnet)
        Me.GroupBoxNetworkInformation.Controls.Add(Me.LabelCalculatedSubnetSize)
        Me.GroupBoxNetworkInformation.Controls.Add(Me.LabelHostsPerSubnet)
        Me.GroupBoxNetworkInformation.Controls.Add(Me.LabelNetworkAddress)
        Me.GroupBoxNetworkInformation.Location = New System.Drawing.Point(12, 37)
        Me.GroupBoxNetworkInformation.Name = "GroupBoxNetworkInformation"
        Me.GroupBoxNetworkInformation.Size = New System.Drawing.Size(262, 114)
        Me.GroupBoxNetworkInformation.TabIndex = 0
        Me.GroupBoxNetworkInformation.TabStop = False
        Me.GroupBoxNetworkInformation.Text = "Network Information"
        '
        'TextBoxCalculatedSubnetSize
        '
        Me.TextBoxCalculatedSubnetSize.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCalculatedSubnetSize.Location = New System.Drawing.Point(137, 80)
        Me.TextBoxCalculatedSubnetSize.Name = "TextBoxCalculatedSubnetSize"
        Me.TextBoxCalculatedSubnetSize.ReadOnly = True
        Me.TextBoxCalculatedSubnetSize.Size = New System.Drawing.Size(60, 20)
        Me.TextBoxCalculatedSubnetSize.TabIndex = 0
        Me.TextBoxCalculatedSubnetSize.TabStop = False
        '
        'TextBoxInputNetworkAddress
        '
        Me.TextBoxInputNetworkAddress.Location = New System.Drawing.Point(137, 24)
        Me.TextBoxInputNetworkAddress.Name = "TextBoxInputNetworkAddress"
        Me.TextBoxInputNetworkAddress.Size = New System.Drawing.Size(109, 20)
        Me.TextBoxInputNetworkAddress.TabIndex = 1
        '
        'TextBoxInputHostsPerSubnet
        '
        Me.TextBoxInputHostsPerSubnet.Location = New System.Drawing.Point(137, 52)
        Me.TextBoxInputHostsPerSubnet.Name = "TextBoxInputHostsPerSubnet"
        Me.TextBoxInputHostsPerSubnet.Size = New System.Drawing.Size(109, 20)
        Me.TextBoxInputHostsPerSubnet.TabIndex = 2
        '
        'LabelCalculatedSubnetSize
        '
        Me.LabelCalculatedSubnetSize.AutoSize = True
        Me.LabelCalculatedSubnetSize.Location = New System.Drawing.Point(15, 83)
        Me.LabelCalculatedSubnetSize.Name = "LabelCalculatedSubnetSize"
        Me.LabelCalculatedSubnetSize.Size = New System.Drawing.Size(120, 13)
        Me.LabelCalculatedSubnetSize.TabIndex = 0
        Me.LabelCalculatedSubnetSize.Text = "Calculated Subnet Size:"
        '
        'LabelHostsPerSubnet
        '
        Me.LabelHostsPerSubnet.AutoSize = True
        Me.LabelHostsPerSubnet.Location = New System.Drawing.Point(15, 55)
        Me.LabelHostsPerSubnet.Name = "LabelHostsPerSubnet"
        Me.LabelHostsPerSubnet.Size = New System.Drawing.Size(114, 13)
        Me.LabelHostsPerSubnet.TabIndex = 0
        Me.LabelHostsPerSubnet.Text = "# of Hosts per Subnet:"
        '
        'LabelNetworkAddress
        '
        Me.LabelNetworkAddress.AutoSize = True
        Me.LabelNetworkAddress.Location = New System.Drawing.Point(15, 27)
        Me.LabelNetworkAddress.Name = "LabelNetworkAddress"
        Me.LabelNetworkAddress.Size = New System.Drawing.Size(91, 13)
        Me.LabelNetworkAddress.TabIndex = 0
        Me.LabelNetworkAddress.Text = "Network Address:"
        '
        'GroupBoxListOfIpRanges
        '
        Me.GroupBoxListOfIpRanges.Controls.Add(Me.ListBoxIpRanges)
        Me.GroupBoxListOfIpRanges.Location = New System.Drawing.Point(15, 169)
        Me.GroupBoxListOfIpRanges.Name = "GroupBoxListOfIpRanges"
        Me.GroupBoxListOfIpRanges.Size = New System.Drawing.Size(258, 221)
        Me.GroupBoxListOfIpRanges.TabIndex = 0
        Me.GroupBoxListOfIpRanges.TabStop = False
        Me.GroupBoxListOfIpRanges.Text = "List of IP Ranges"
        '
        'ListBoxIpRanges
        '
        Me.ListBoxIpRanges.FormattingEnabled = True
        Me.ListBoxIpRanges.Location = New System.Drawing.Point(6, 17)
        Me.ListBoxIpRanges.Name = "ListBoxIpRanges"
        Me.ListBoxIpRanges.Size = New System.Drawing.Size(246, 199)
        Me.ListBoxIpRanges.TabIndex = 0
        Me.ListBoxIpRanges.TabStop = False
        '
        'GroupBoxAddressInformation
        '
        Me.GroupBoxAddressInformation.Controls.Add(Me.TextBoxHexOctets)
        Me.GroupBoxAddressInformation.Controls.Add(Me.TextBoxBinaryOctets)
        Me.GroupBoxAddressInformation.Controls.Add(Me.TextBoxDecimalOctets)
        Me.GroupBoxAddressInformation.Controls.Add(Me.TextBoxDecimalAddress)
        Me.GroupBoxAddressInformation.Controls.Add(Me.LabelHexOctets)
        Me.GroupBoxAddressInformation.Controls.Add(Me.LabelBinaryOctets)
        Me.GroupBoxAddressInformation.Controls.Add(Me.LabelDecimalAddress)
        Me.GroupBoxAddressInformation.Controls.Add(Me.LabelDecimalOctets)
        Me.GroupBoxAddressInformation.Location = New System.Drawing.Point(292, 37)
        Me.GroupBoxAddressInformation.Name = "GroupBoxAddressInformation"
        Me.GroupBoxAddressInformation.Size = New System.Drawing.Size(328, 140)
        Me.GroupBoxAddressInformation.TabIndex = 0
        Me.GroupBoxAddressInformation.TabStop = False
        Me.GroupBoxAddressInformation.Text = "Address Information"
        '
        'TextBoxHexOctets
        '
        Me.TextBoxHexOctets.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxHexOctets.Location = New System.Drawing.Point(110, 107)
        Me.TextBoxHexOctets.Name = "TextBoxHexOctets"
        Me.TextBoxHexOctets.ReadOnly = True
        Me.TextBoxHexOctets.Size = New System.Drawing.Size(212, 20)
        Me.TextBoxHexOctets.TabIndex = 0
        Me.TextBoxHexOctets.TabStop = False
        '
        'TextBoxBinaryOctets
        '
        Me.TextBoxBinaryOctets.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxBinaryOctets.Location = New System.Drawing.Point(110, 80)
        Me.TextBoxBinaryOctets.Name = "TextBoxBinaryOctets"
        Me.TextBoxBinaryOctets.ReadOnly = True
        Me.TextBoxBinaryOctets.Size = New System.Drawing.Size(212, 20)
        Me.TextBoxBinaryOctets.TabIndex = 0
        Me.TextBoxBinaryOctets.TabStop = False
        '
        'TextBoxDecimalOctets
        '
        Me.TextBoxDecimalOctets.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxDecimalOctets.Location = New System.Drawing.Point(110, 24)
        Me.TextBoxDecimalOctets.Name = "TextBoxDecimalOctets"
        Me.TextBoxDecimalOctets.ReadOnly = True
        Me.TextBoxDecimalOctets.Size = New System.Drawing.Size(212, 20)
        Me.TextBoxDecimalOctets.TabIndex = 0
        Me.TextBoxDecimalOctets.TabStop = False
        '
        'TextBoxDecimalAddress
        '
        Me.TextBoxDecimalAddress.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxDecimalAddress.Location = New System.Drawing.Point(110, 52)
        Me.TextBoxDecimalAddress.Name = "TextBoxDecimalAddress"
        Me.TextBoxDecimalAddress.ReadOnly = True
        Me.TextBoxDecimalAddress.Size = New System.Drawing.Size(212, 20)
        Me.TextBoxDecimalAddress.TabIndex = 0
        Me.TextBoxDecimalAddress.TabStop = False
        '
        'LabelHexOctets
        '
        Me.LabelHexOctets.AutoSize = True
        Me.LabelHexOctets.Location = New System.Drawing.Point(15, 110)
        Me.LabelHexOctets.Name = "LabelHexOctets"
        Me.LabelHexOctets.Size = New System.Drawing.Size(63, 13)
        Me.LabelHexOctets.TabIndex = 0
        Me.LabelHexOctets.Text = "Hex Octets:"
        '
        'LabelBinaryOctets
        '
        Me.LabelBinaryOctets.AutoSize = True
        Me.LabelBinaryOctets.Location = New System.Drawing.Point(15, 83)
        Me.LabelBinaryOctets.Name = "LabelBinaryOctets"
        Me.LabelBinaryOctets.Size = New System.Drawing.Size(73, 13)
        Me.LabelBinaryOctets.TabIndex = 0
        Me.LabelBinaryOctets.Text = "Binary Octets:"
        '
        'LabelDecimalAddress
        '
        Me.LabelDecimalAddress.AutoSize = True
        Me.LabelDecimalAddress.Location = New System.Drawing.Point(15, 55)
        Me.LabelDecimalAddress.Name = "LabelDecimalAddress"
        Me.LabelDecimalAddress.Size = New System.Drawing.Size(89, 13)
        Me.LabelDecimalAddress.TabIndex = 0
        Me.LabelDecimalAddress.Text = "Decimal Address:"
        '
        'LabelDecimalOctets
        '
        Me.LabelDecimalOctets.AutoSize = True
        Me.LabelDecimalOctets.Location = New System.Drawing.Point(15, 27)
        Me.LabelDecimalOctets.Name = "LabelDecimalOctets"
        Me.LabelDecimalOctets.Size = New System.Drawing.Size(82, 13)
        Me.LabelDecimalOctets.TabIndex = 0
        Me.LabelDecimalOctets.Text = "Decimal Octets:"
        '
        'GroupBoxNetmaskInformation
        '
        Me.GroupBoxNetmaskInformation.Controls.Add(Me.TextBoxSubnets)
        Me.GroupBoxNetmaskInformation.Controls.Add(Me.TextBoxBinaryMask)
        Me.GroupBoxNetmaskInformation.Controls.Add(Me.TextBoxSubnetMask)
        Me.GroupBoxNetmaskInformation.Controls.Add(Me.TextBoxNetworkClass)
        Me.GroupBoxNetmaskInformation.Controls.Add(Me.TextBoxIpAddresses)
        Me.GroupBoxNetmaskInformation.Controls.Add(Me.LabelSubnets)
        Me.GroupBoxNetmaskInformation.Controls.Add(Me.LabelBinaryMask)
        Me.GroupBoxNetmaskInformation.Controls.Add(Me.LabelSubnetMask)
        Me.GroupBoxNetmaskInformation.Controls.Add(Me.LabelIpAddresses)
        Me.GroupBoxNetmaskInformation.Controls.Add(Me.LabelNetworkClass)
        Me.GroupBoxNetmaskInformation.Location = New System.Drawing.Point(292, 190)
        Me.GroupBoxNetmaskInformation.Name = "GroupBoxNetmaskInformation"
        Me.GroupBoxNetmaskInformation.Size = New System.Drawing.Size(328, 175)
        Me.GroupBoxNetmaskInformation.TabIndex = 0
        Me.GroupBoxNetmaskInformation.TabStop = False
        Me.GroupBoxNetmaskInformation.Text = "Netmask Information"
        '
        'TextBoxSubnets
        '
        Me.TextBoxSubnets.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxSubnets.Location = New System.Drawing.Point(115, 141)
        Me.TextBoxSubnets.Name = "TextBoxSubnets"
        Me.TextBoxSubnets.ReadOnly = True
        Me.TextBoxSubnets.Size = New System.Drawing.Size(54, 20)
        Me.TextBoxSubnets.TabIndex = 0
        Me.TextBoxSubnets.TabStop = False
        '
        'TextBoxBinaryMask
        '
        Me.TextBoxBinaryMask.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxBinaryMask.Location = New System.Drawing.Point(115, 110)
        Me.TextBoxBinaryMask.Name = "TextBoxBinaryMask"
        Me.TextBoxBinaryMask.ReadOnly = True
        Me.TextBoxBinaryMask.Size = New System.Drawing.Size(207, 20)
        Me.TextBoxBinaryMask.TabIndex = 0
        Me.TextBoxBinaryMask.TabStop = False
        '
        'TextBoxSubnetMask
        '
        Me.TextBoxSubnetMask.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxSubnetMask.Location = New System.Drawing.Point(115, 80)
        Me.TextBoxSubnetMask.Name = "TextBoxSubnetMask"
        Me.TextBoxSubnetMask.ReadOnly = True
        Me.TextBoxSubnetMask.Size = New System.Drawing.Size(207, 20)
        Me.TextBoxSubnetMask.TabIndex = 0
        Me.TextBoxSubnetMask.TabStop = False
        '
        'TextBoxNetworkClass
        '
        Me.TextBoxNetworkClass.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxNetworkClass.Location = New System.Drawing.Point(115, 22)
        Me.TextBoxNetworkClass.Name = "TextBoxNetworkClass"
        Me.TextBoxNetworkClass.ReadOnly = True
        Me.TextBoxNetworkClass.Size = New System.Drawing.Size(30, 20)
        Me.TextBoxNetworkClass.TabIndex = 0
        Me.TextBoxNetworkClass.TabStop = False
        '
        'TextBoxIpAddresses
        '
        Me.TextBoxIpAddresses.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxIpAddresses.Location = New System.Drawing.Point(115, 51)
        Me.TextBoxIpAddresses.Name = "TextBoxIpAddresses"
        Me.TextBoxIpAddresses.ReadOnly = True
        Me.TextBoxIpAddresses.Size = New System.Drawing.Size(77, 20)
        Me.TextBoxIpAddresses.TabIndex = 0
        Me.TextBoxIpAddresses.TabStop = False
        '
        'LabelSubnets
        '
        Me.LabelSubnets.AutoSize = True
        Me.LabelSubnets.Location = New System.Drawing.Point(15, 144)
        Me.LabelSubnets.Name = "LabelSubnets"
        Me.LabelSubnets.Size = New System.Drawing.Size(68, 13)
        Me.LabelSubnets.TabIndex = 0
        Me.LabelSubnets.Text = "# of Subnets"
        '
        'LabelBinaryMask
        '
        Me.LabelBinaryMask.AutoSize = True
        Me.LabelBinaryMask.Location = New System.Drawing.Point(15, 113)
        Me.LabelBinaryMask.Name = "LabelBinaryMask"
        Me.LabelBinaryMask.Size = New System.Drawing.Size(68, 13)
        Me.LabelBinaryMask.TabIndex = 0
        Me.LabelBinaryMask.Text = "Binary Mask:"
        '
        'LabelSubnetMask
        '
        Me.LabelSubnetMask.AutoSize = True
        Me.LabelSubnetMask.Location = New System.Drawing.Point(15, 83)
        Me.LabelSubnetMask.Name = "LabelSubnetMask"
        Me.LabelSubnetMask.Size = New System.Drawing.Size(73, 13)
        Me.LabelSubnetMask.TabIndex = 0
        Me.LabelSubnetMask.Text = "Subnet Mask:"
        '
        'LabelIpAddresses
        '
        Me.LabelIpAddresses.AutoSize = True
        Me.LabelIpAddresses.Location = New System.Drawing.Point(15, 54)
        Me.LabelIpAddresses.Name = "LabelIpAddresses"
        Me.LabelIpAddresses.Size = New System.Drawing.Size(94, 13)
        Me.LabelIpAddresses.TabIndex = 0
        Me.LabelIpAddresses.Text = "# of IP Addresses:"
        '
        'LabelNetworkClass
        '
        Me.LabelNetworkClass.AutoSize = True
        Me.LabelNetworkClass.Location = New System.Drawing.Point(15, 25)
        Me.LabelNetworkClass.Name = "LabelNetworkClass"
        Me.LabelNetworkClass.Size = New System.Drawing.Size(78, 13)
        Me.LabelNetworkClass.TabIndex = 0
        Me.LabelNetworkClass.Text = "Network Class:"
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.Location = New System.Drawing.Point(512, 371)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(91, 23)
        Me.ButtonCalculate.TabIndex = 3
        Me.ButtonCalculate.Text = "Calculate"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'OpenFileDialogSubnetForm
        '
        Me.OpenFileDialogSubnetForm.FileName = "OpenFileDialog1"
        '
        'SaveFileDialogSubnetForm
        '
        Me.SaveFileDialogSubnetForm.DefaultExt = "txt"
        Me.SaveFileDialogSubnetForm.FileName = "*"
        Me.SaveFileDialogSubnetForm.Filter = "Text files (*.txt)|*.txt"
        Me.SaveFileDialogSubnetForm.Title = "Save As"
        '
        'FormSubnetCalculator
        '
        Me.AcceptButton = Me.ButtonCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 402)
        Me.Controls.Add(Me.ButtonCalculate)
        Me.Controls.Add(Me.GroupBoxNetmaskInformation)
        Me.Controls.Add(Me.GroupBoxAddressInformation)
        Me.Controls.Add(Me.GroupBoxListOfIpRanges)
        Me.Controls.Add(Me.GroupBoxNetworkInformation)
        Me.Controls.Add(Me.MenuStripSubnetForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStripSubnetForm
        Me.Name = "FormSubnetCalculator"
        Me.Text = "Subnet Calculator"
        Me.MenuStripSubnetForm.ResumeLayout(False)
        Me.MenuStripSubnetForm.PerformLayout()
        Me.GroupBoxNetworkInformation.ResumeLayout(False)
        Me.GroupBoxNetworkInformation.PerformLayout()
        Me.GroupBoxListOfIpRanges.ResumeLayout(False)
        Me.GroupBoxAddressInformation.ResumeLayout(False)
        Me.GroupBoxAddressInformation.PerformLayout()
        Me.GroupBoxNetmaskInformation.ResumeLayout(False)
        Me.GroupBoxNetmaskInformation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStripSubnetForm As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBoxNetworkInformation As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxCalculatedSubnetSize As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxInputNetworkAddress As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxInputHostsPerSubnet As System.Windows.Forms.TextBox
    Friend WithEvents LabelCalculatedSubnetSize As System.Windows.Forms.Label
    Friend WithEvents LabelHostsPerSubnet As System.Windows.Forms.Label
    Friend WithEvents LabelNetworkAddress As System.Windows.Forms.Label
    Friend WithEvents GroupBoxListOfIpRanges As System.Windows.Forms.GroupBox
    Friend WithEvents ListBoxIpRanges As System.Windows.Forms.ListBox
    Friend WithEvents GroupBoxAddressInformation As System.Windows.Forms.GroupBox
    Friend WithEvents LabelHexOctets As System.Windows.Forms.Label
    Friend WithEvents LabelBinaryOctets As System.Windows.Forms.Label
    Friend WithEvents LabelDecimalAddress As System.Windows.Forms.Label
    Friend WithEvents LabelDecimalOctets As System.Windows.Forms.Label
    Friend WithEvents TextBoxHexOctets As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxBinaryOctets As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDecimalOctets As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDecimalAddress As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxNetmaskInformation As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxSubnets As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxBinaryMask As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSubnetMask As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNetworkClass As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxIpAddresses As System.Windows.Forms.TextBox
    Friend WithEvents LabelSubnets As System.Windows.Forms.Label
    Friend WithEvents LabelBinaryMask As System.Windows.Forms.Label
    Friend WithEvents LabelSubnetMask As System.Windows.Forms.Label
    Friend WithEvents LabelIpAddresses As System.Windows.Forms.Label
    Friend WithEvents LabelNetworkClass As System.Windows.Forms.Label
    Friend WithEvents ButtonCalculate As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialogSubnetForm As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialogSubnetForm As System.Windows.Forms.SaveFileDialog

End Class
