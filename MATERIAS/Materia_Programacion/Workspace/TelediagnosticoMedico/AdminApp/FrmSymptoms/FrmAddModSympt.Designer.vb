﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAddModSympt
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddModSympt))
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.LblSymptTop = New Guna.UI.WinForms.GunaLabel()
        Me.BtnClose = New Guna.UI.WinForms.GunaButton()
        Me.LblTittleAddSymp_A_SA = New Guna.UI.WinForms.GunaLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnImportCsv = New Guna.UI.WinForms.GunaButton()
        Me.ChkReg_A_SA = New Guna.UI.WinForms.GunaCheckBox()
        Me.Cmbreg = New Guna.UI.WinForms.GunaComboBox()
        Me.BtnCancel = New Guna.UI.WinForms.GunaButton()
        Me.BtnMod = New Guna.UI.WinForms.GunaButton()
        Me.Lblreg = New Guna.UI.WinForms.GunaLabel()
        Me.LblActual_A_SA = New Guna.UI.WinForms.GunaLabel()
        Me.LblAsocReg_A_SA = New Guna.UI.WinForms.GunaLabel()
        Me.ChkListPath = New System.Windows.Forms.CheckedListBox()
        Me.LblAsocPath_A_SA = New Guna.UI.WinForms.GunaLabel()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.TxtDescr = New Guna.UI.WinForms.GunaTextBox()
        Me.LblDescSympt_A_SA = New Guna.UI.WinForms.GunaLabel()
        Me.OfdAddSympt = New System.Windows.Forms.OpenFileDialog()
        Me.PanelTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.LblSymptTop)
        Me.PanelTop.Controls.Add(Me.BtnClose)
        Me.PanelTop.Controls.Add(Me.LblTittleAddSymp_A_SA)
        Me.PanelTop.Location = New System.Drawing.Point(1, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(674, 35)
        Me.PanelTop.TabIndex = 2
        '
        'LblSymptTop
        '
        Me.LblSymptTop.AutoSize = True
        Me.LblSymptTop.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSymptTop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.LblSymptTop.Location = New System.Drawing.Point(326, 0)
        Me.LblSymptTop.Name = "LblSymptTop"
        Me.LblSymptTop.Size = New System.Drawing.Size(0, 30)
        Me.LblSymptTop.TabIndex = 29
        Me.LblSymptTop.Visible = False
        '
        'BtnClose
        '
        Me.BtnClose.AnimationHoverSpeed = 0.07!
        Me.BtnClose.AnimationSpeed = 0.03!
        Me.BtnClose.BaseColor = System.Drawing.Color.Transparent
        Me.BtnClose.BorderColor = System.Drawing.Color.Black
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnClose.FocusedColor = System.Drawing.Color.Empty
        Me.BtnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnClose.Location = New System.Drawing.Point(631, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.BtnClose.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.BtnClose.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnClose.OnHoverImage = Nothing
        Me.BtnClose.OnPressedColor = System.Drawing.Color.Black
        Me.BtnClose.Size = New System.Drawing.Size(40, 24)
        Me.BtnClose.TabIndex = 28
        '
        'LblTittleAddSymp_A_SA
        '
        Me.LblTittleAddSymp_A_SA.AutoSize = True
        Me.LblTittleAddSymp_A_SA.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTittleAddSymp_A_SA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblTittleAddSymp_A_SA.Location = New System.Drawing.Point(3, 0)
        Me.LblTittleAddSymp_A_SA.Name = "LblTittleAddSymp_A_SA"
        Me.LblTittleAddSymp_A_SA.Size = New System.Drawing.Size(317, 30)
        Me.LblTittleAddSymp_A_SA.TabIndex = 0
        Me.LblTittleAddSymp_A_SA.Text = "MODIFICACIÓN DEL SÍNTOMA"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnImportCsv)
        Me.Panel1.Controls.Add(Me.ChkReg_A_SA)
        Me.Panel1.Controls.Add(Me.Cmbreg)
        Me.Panel1.Controls.Add(Me.BtnCancel)
        Me.Panel1.Controls.Add(Me.BtnMod)
        Me.Panel1.Controls.Add(Me.Lblreg)
        Me.Panel1.Controls.Add(Me.LblActual_A_SA)
        Me.Panel1.Controls.Add(Me.LblAsocReg_A_SA)
        Me.Panel1.Controls.Add(Me.ChkListPath)
        Me.Panel1.Controls.Add(Me.LblAsocPath_A_SA)
        Me.Panel1.Controls.Add(Me.GunaSeparator1)
        Me.Panel1.Controls.Add(Me.TxtDescr)
        Me.Panel1.Controls.Add(Me.LblDescSympt_A_SA)
        Me.Panel1.Location = New System.Drawing.Point(1, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(671, 202)
        Me.Panel1.TabIndex = 32
        '
        'BtnImportCsv
        '
        Me.BtnImportCsv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnImportCsv.Animated = True
        Me.BtnImportCsv.AnimationHoverSpeed = 0.07!
        Me.BtnImportCsv.AnimationSpeed = 0.03!
        Me.BtnImportCsv.BackColor = System.Drawing.Color.Transparent
        Me.BtnImportCsv.BaseColor = System.Drawing.Color.Transparent
        Me.BtnImportCsv.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnImportCsv.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnImportCsv.FocusedColor = System.Drawing.Color.Empty
        Me.BtnImportCsv.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImportCsv.ForeColor = System.Drawing.Color.Black
        Me.BtnImportCsv.Image = CType(resources.GetObject("BtnImportCsv.Image"), System.Drawing.Image)
        Me.BtnImportCsv.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BtnImportCsv.ImageSize = New System.Drawing.Size(39, 39)
        Me.BtnImportCsv.Location = New System.Drawing.Point(622, 5)
        Me.BtnImportCsv.Name = "BtnImportCsv"
        Me.BtnImportCsv.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnImportCsv.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnImportCsv.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnImportCsv.OnHoverImage = Nothing
        Me.BtnImportCsv.OnPressedColor = System.Drawing.Color.Black
        Me.BtnImportCsv.Radius = 6
        Me.BtnImportCsv.Size = New System.Drawing.Size(39, 39)
        Me.BtnImportCsv.TabIndex = 42
        Me.BtnImportCsv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BtnImportCsv.Visible = False
        '
        'ChkReg_A_SA
        '
        Me.ChkReg_A_SA.BackColor = System.Drawing.Color.White
        Me.ChkReg_A_SA.BaseColor = System.Drawing.Color.White
        Me.ChkReg_A_SA.CheckedOffColor = System.Drawing.SystemColors.Desktop
        Me.ChkReg_A_SA.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.ChkReg_A_SA.FillColor = System.Drawing.Color.White
        Me.ChkReg_A_SA.Location = New System.Drawing.Point(274, 138)
        Me.ChkReg_A_SA.Name = "ChkReg_A_SA"
        Me.ChkReg_A_SA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkReg_A_SA.Size = New System.Drawing.Size(110, 20)
        Me.ChkReg_A_SA.TabIndex = 3
        Me.ChkReg_A_SA.Text = "Modificar región"
        '
        'Cmbreg
        '
        Me.Cmbreg.BackColor = System.Drawing.Color.Transparent
        Me.Cmbreg.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Cmbreg.BorderColor = System.Drawing.Color.Silver
        Me.Cmbreg.BorderSize = 0
        Me.Cmbreg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cmbreg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbreg.FocusedColor = System.Drawing.Color.Empty
        Me.Cmbreg.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Cmbreg.ForeColor = System.Drawing.Color.White
        Me.Cmbreg.FormattingEnabled = True
        Me.Cmbreg.Location = New System.Drawing.Point(274, 164)
        Me.Cmbreg.Name = "Cmbreg"
        Me.Cmbreg.OnHoverItemBaseColor = System.Drawing.Color.Teal
        Me.Cmbreg.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Cmbreg.Radius = 5
        Me.Cmbreg.Size = New System.Drawing.Size(203, 26)
        Me.Cmbreg.TabIndex = 2
        Me.Cmbreg.Visible = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Animated = True
        Me.BtnCancel.AnimationHoverSpeed = 0.07!
        Me.BtnCancel.AnimationSpeed = 0.03!
        Me.BtnCancel.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnCancel.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCancel.BorderSize = 1
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnCancel.FocusedColor = System.Drawing.Color.Empty
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.Black
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnCancel.Location = New System.Drawing.Point(540, 151)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnCancel.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnCancel.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnCancel.OnHoverImage = Nothing
        Me.BtnCancel.OnPressedColor = System.Drawing.Color.Black
        Me.BtnCancel.Radius = 6
        Me.BtnCancel.Size = New System.Drawing.Size(39, 39)
        Me.BtnCancel.TabIndex = 41
        Me.BtnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnMod
        '
        Me.BtnMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMod.Animated = True
        Me.BtnMod.AnimationHoverSpeed = 0.07!
        Me.BtnMod.AnimationSpeed = 0.03!
        Me.BtnMod.BackColor = System.Drawing.Color.Transparent
        Me.BtnMod.BaseColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnMod.BorderColor = System.Drawing.Color.Silver
        Me.BtnMod.BorderSize = 1
        Me.BtnMod.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnMod.FocusedColor = System.Drawing.Color.Empty
        Me.BtnMod.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMod.ForeColor = System.Drawing.Color.Black
        Me.BtnMod.Image = CType(resources.GetObject("BtnMod.Image"), System.Drawing.Image)
        Me.BtnMod.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BtnMod.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnMod.Location = New System.Drawing.Point(585, 151)
        Me.BtnMod.Name = "BtnMod"
        Me.BtnMod.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.BtnMod.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnMod.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnMod.OnHoverImage = Nothing
        Me.BtnMod.OnPressedColor = System.Drawing.Color.Black
        Me.BtnMod.Radius = 6
        Me.BtnMod.Size = New System.Drawing.Size(76, 39)
        Me.BtnMod.TabIndex = 4
        Me.BtnMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lblreg
        '
        Me.Lblreg.AutoSize = True
        Me.Lblreg.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Lblreg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Lblreg.Location = New System.Drawing.Point(324, 104)
        Me.Lblreg.Name = "Lblreg"
        Me.Lblreg.Size = New System.Drawing.Size(0, 15)
        Me.Lblreg.TabIndex = 39
        Me.Lblreg.Visible = False
        '
        'LblActual_A_SA
        '
        Me.LblActual_A_SA.AutoSize = True
        Me.LblActual_A_SA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblActual_A_SA.Location = New System.Drawing.Point(271, 104)
        Me.LblActual_A_SA.Name = "LblActual_A_SA"
        Me.LblActual_A_SA.Size = New System.Drawing.Size(47, 15)
        Me.LblActual_A_SA.TabIndex = 38
        Me.LblActual_A_SA.Text = "Actual: "
        '
        'LblAsocReg_A_SA
        '
        Me.LblAsocReg_A_SA.AutoSize = True
        Me.LblAsocReg_A_SA.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAsocReg_A_SA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblAsocReg_A_SA.Location = New System.Drawing.Point(269, 71)
        Me.LblAsocReg_A_SA.Name = "LblAsocReg_A_SA"
        Me.LblAsocReg_A_SA.Size = New System.Drawing.Size(217, 30)
        Me.LblAsocReg_A_SA.TabIndex = 37
        Me.LblAsocReg_A_SA.Text = "Asociación a la región"
        '
        'ChkListPath
        '
        Me.ChkListPath.CheckOnClick = True
        Me.ChkListPath.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkListPath.FormattingEnabled = True
        Me.ChkListPath.Location = New System.Drawing.Point(11, 104)
        Me.ChkListPath.Name = "ChkListPath"
        Me.ChkListPath.Size = New System.Drawing.Size(200, 94)
        Me.ChkListPath.TabIndex = 1
        '
        'LblAsocPath_A_SA
        '
        Me.LblAsocPath_A_SA.AutoSize = True
        Me.LblAsocPath_A_SA.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAsocPath_A_SA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblAsocPath_A_SA.Location = New System.Drawing.Point(6, 71)
        Me.LblAsocPath_A_SA.Name = "LblAsocPath_A_SA"
        Me.LblAsocPath_A_SA.Size = New System.Drawing.Size(215, 30)
        Me.LblAsocPath_A_SA.TabIndex = 35
        Me.LblAsocPath_A_SA.Text = "Asociación patologías"
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.GunaSeparator1.Location = New System.Drawing.Point(11, 58)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(650, 10)
        Me.GunaSeparator1.TabIndex = 34
        '
        'TxtDescr
        '
        Me.TxtDescr.BackColor = System.Drawing.Color.Transparent
        Me.TxtDescr.BaseColor = System.Drawing.Color.Transparent
        Me.TxtDescr.BorderColor = System.Drawing.Color.Transparent
        Me.TxtDescr.BorderSize = 0
        Me.TxtDescr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDescr.FocusedBaseColor = System.Drawing.Color.Transparent
        Me.TxtDescr.FocusedBorderColor = System.Drawing.Color.Transparent
        Me.TxtDescr.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtDescr.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtDescr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TxtDescr.Location = New System.Drawing.Point(11, 38)
        Me.TxtDescr.Multiline = True
        Me.TxtDescr.Name = "TxtDescr"
        Me.TxtDescr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtDescr.SelectedText = ""
        Me.TxtDescr.Size = New System.Drawing.Size(650, 30)
        Me.TxtDescr.TabIndex = 0
        '
        'LblDescSympt_A_SA
        '
        Me.LblDescSympt_A_SA.AutoSize = True
        Me.LblDescSympt_A_SA.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescSympt_A_SA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LblDescSympt_A_SA.Location = New System.Drawing.Point(3, 5)
        Me.LblDescSympt_A_SA.Name = "LblDescSympt_A_SA"
        Me.LblDescSympt_A_SA.Size = New System.Drawing.Size(121, 30)
        Me.LblDescSympt_A_SA.TabIndex = 32
        Me.LblDescSympt_A_SA.Text = "Descripción"
        '
        'OfdAddSympt
        '
        Me.OfdAddSympt.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"" ;"
        Me.OfdAddSympt.Title = "Agregar síntoma"
        '
        'FrmAddModSympt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 236)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAddModSympt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmModSympt"
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTop As Panel
    Friend WithEvents BtnClose As Guna.UI.WinForms.GunaButton
    Friend WithEvents LblTittleAddSymp_A_SA As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LblSymptTop As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtDescr As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LblDescSympt_A_SA As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents LblAsocPath_A_SA As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LblAsocReg_A_SA As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Lblreg As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LblActual_A_SA As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BtnMod As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnCancel As Guna.UI.WinForms.GunaButton
    Friend WithEvents ChkReg_A_SA As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents Cmbreg As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents ChkListPath As CheckedListBox
    Friend WithEvents OfdAddSympt As OpenFileDialog
    Friend WithEvents BtnImportCsv As Guna.UI.WinForms.GunaButton
End Class
