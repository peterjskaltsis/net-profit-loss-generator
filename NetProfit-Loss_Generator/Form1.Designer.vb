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
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.separator1 = New System.Windows.Forms.Button()
        Me.separator2 = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.lblControls = New System.Windows.Forms.Label()
        Me.separator3 = New System.Windows.Forms.Button()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.lblExpenseTotalPrompt = New System.Windows.Forms.Label()
        Me.lblExpenseTotalVal = New System.Windows.Forms.Label()
        Me.lblRevenueTotalVal = New System.Windows.Forms.Label()
        Me.lblRevenueTotalPrompt = New System.Windows.Forms.Label()
        Me.lblExpenseItemsVal = New System.Windows.Forms.Label()
        Me.lblExpenseItemsPrompt = New System.Windows.Forms.Label()
        Me.lblRevenueItemsVal = New System.Windows.Forms.Label()
        Me.lblRevenueItemsPrompt = New System.Windows.Forms.Label()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.btnExportPDF = New System.Windows.Forms.Button()
        Me.panelControlTop = New System.Windows.Forms.Panel()
        Me.lblIcon = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblFormName = New System.Windows.Forms.Label()
        Me.panelContentContainer = New System.Windows.Forms.Panel()
        Me.separator4 = New System.Windows.Forms.Button()
        Me.separator5 = New System.Windows.Forms.Button()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelControlTop.SuspendLayout()
        Me.panelContentContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.InitialImage = CType(resources.GetObject("picLogo.InitialImage"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(296, 5)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(2)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(260, 94)
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(20, 28)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(254, 24)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Net Profit/Loss Generator"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'separator1
        '
        Me.separator1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.separator1.Location = New System.Drawing.Point(516, 2)
        Me.separator1.Margin = New System.Windows.Forms.Padding(2)
        Me.separator1.Name = "separator1"
        Me.separator1.Size = New System.Drawing.Size(2, 450)
        Me.separator1.TabIndex = 2
        Me.separator1.Text = "Button1"
        Me.separator1.UseVisualStyleBackColor = True
        '
        'separator2
        '
        Me.separator2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.separator2.Location = New System.Drawing.Point(520, 66)
        Me.separator2.Margin = New System.Windows.Forms.Padding(2)
        Me.separator2.Name = "separator2"
        Me.separator2.Size = New System.Drawing.Size(272, 2)
        Me.separator2.TabIndex = 3
        Me.separator2.Text = "Button1"
        Me.separator2.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Font = New System.Drawing.Font("Arial", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.Location = New System.Drawing.Point(24, 170)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(120, 32)
        Me.btnImport.TabIndex = 4
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Arial", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(24, 243)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(120, 32)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Font = New System.Drawing.Font("Arial", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Location = New System.Drawing.Point(24, 316)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(120, 32)
        Me.btnExport.TabIndex = 6
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'lblControls
        '
        Me.lblControls.AutoSize = True
        Me.lblControls.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblControls.Location = New System.Drawing.Point(41, 87)
        Me.lblControls.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblControls.Name = "lblControls"
        Me.lblControls.Size = New System.Drawing.Size(75, 19)
        Me.lblControls.TabIndex = 7
        Me.lblControls.Text = "Controls"
        Me.lblControls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'separator3
        '
        Me.separator3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.separator3.Location = New System.Drawing.Point(162, 75)
        Me.separator3.Margin = New System.Windows.Forms.Padding(2)
        Me.separator3.Name = "separator3"
        Me.separator3.Size = New System.Drawing.Size(2, 385)
        Me.separator3.TabIndex = 8
        Me.separator3.Text = "Button1"
        Me.separator3.UseVisualStyleBackColor = True
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSummary.Location = New System.Drawing.Point(208, 87)
        Me.lblSummary.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(295, 19)
        Me.lblSummary.TabIndex = 9
        Me.lblSummary.Text = "Summary of Expenses and Revenues"
        Me.lblSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExpenseTotalPrompt
        '
        Me.lblExpenseTotalPrompt.AutoSize = True
        Me.lblExpenseTotalPrompt.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblExpenseTotalPrompt.Location = New System.Drawing.Point(209, 154)
        Me.lblExpenseTotalPrompt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblExpenseTotalPrompt.Name = "lblExpenseTotalPrompt"
        Me.lblExpenseTotalPrompt.Size = New System.Drawing.Size(133, 16)
        Me.lblExpenseTotalPrompt.TabIndex = 10
        Me.lblExpenseTotalPrompt.Text = "Total Expense Items"
        Me.lblExpenseTotalPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExpenseTotalVal
        '
        Me.lblExpenseTotalVal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblExpenseTotalVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblExpenseTotalVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblExpenseTotalVal.Font = New System.Drawing.Font("Arial", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpenseTotalVal.Location = New System.Drawing.Point(216, 198)
        Me.lblExpenseTotalVal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblExpenseTotalVal.Name = "lblExpenseTotalVal"
        Me.lblExpenseTotalVal.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.lblExpenseTotalVal.Size = New System.Drawing.Size(188, 25)
        Me.lblExpenseTotalVal.TabIndex = 11
        Me.lblExpenseTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRevenueTotalVal
        '
        Me.lblRevenueTotalVal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblRevenueTotalVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRevenueTotalVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblRevenueTotalVal.Font = New System.Drawing.Font("Arial", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevenueTotalVal.Location = New System.Drawing.Point(214, 242)
        Me.lblRevenueTotalVal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRevenueTotalVal.Name = "lblRevenueTotalVal"
        Me.lblRevenueTotalVal.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.lblRevenueTotalVal.Size = New System.Drawing.Size(188, 25)
        Me.lblRevenueTotalVal.TabIndex = 13
        Me.lblRevenueTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRevenueTotalPrompt
        '
        Me.lblRevenueTotalPrompt.AutoSize = True
        Me.lblRevenueTotalPrompt.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblRevenueTotalPrompt.Location = New System.Drawing.Point(212, 225)
        Me.lblRevenueTotalPrompt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRevenueTotalPrompt.Name = "lblRevenueTotalPrompt"
        Me.lblRevenueTotalPrompt.Size = New System.Drawing.Size(136, 16)
        Me.lblRevenueTotalPrompt.TabIndex = 12
        Me.lblRevenueTotalPrompt.Text = "Total Revenue Items"
        Me.lblRevenueTotalPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExpenseItemsVal
        '
        Me.lblExpenseItemsVal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblExpenseItemsVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblExpenseItemsVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblExpenseItemsVal.Font = New System.Drawing.Font("Arial", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpenseItemsVal.Location = New System.Drawing.Point(215, 314)
        Me.lblExpenseItemsVal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblExpenseItemsVal.Name = "lblExpenseItemsVal"
        Me.lblExpenseItemsVal.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.lblExpenseItemsVal.Size = New System.Drawing.Size(188, 25)
        Me.lblExpenseItemsVal.TabIndex = 15
        Me.lblExpenseItemsVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExpenseItemsPrompt
        '
        Me.lblExpenseItemsPrompt.AutoSize = True
        Me.lblExpenseItemsPrompt.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblExpenseItemsPrompt.Location = New System.Drawing.Point(212, 294)
        Me.lblExpenseItemsPrompt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblExpenseItemsPrompt.Name = "lblExpenseItemsPrompt"
        Me.lblExpenseItemsPrompt.Size = New System.Drawing.Size(168, 16)
        Me.lblExpenseItemsPrompt.TabIndex = 14
        Me.lblExpenseItemsPrompt.Text = "Number of Expense Items"
        Me.lblExpenseItemsPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRevenueItemsVal
        '
        Me.lblRevenueItemsVal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblRevenueItemsVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRevenueItemsVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblRevenueItemsVal.Font = New System.Drawing.Font("Arial", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevenueItemsVal.Location = New System.Drawing.Point(216, 378)
        Me.lblRevenueItemsVal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRevenueItemsVal.Name = "lblRevenueItemsVal"
        Me.lblRevenueItemsVal.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.lblRevenueItemsVal.Size = New System.Drawing.Size(188, 25)
        Me.lblRevenueItemsVal.TabIndex = 17
        Me.lblRevenueItemsVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRevenueItemsPrompt
        '
        Me.lblRevenueItemsPrompt.AutoSize = True
        Me.lblRevenueItemsPrompt.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblRevenueItemsPrompt.Location = New System.Drawing.Point(212, 360)
        Me.lblRevenueItemsPrompt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRevenueItemsPrompt.Name = "lblRevenueItemsPrompt"
        Me.lblRevenueItemsPrompt.Size = New System.Drawing.Size(171, 16)
        Me.lblRevenueItemsPrompt.TabIndex = 16
        Me.lblRevenueItemsPrompt.Text = "Number of Revenue Items"
        Me.lblRevenueItemsPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPreview.Location = New System.Drawing.Point(634, 15)
        Me.lblPreview.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(70, 19)
        Me.lblPreview.TabIndex = 18
        Me.lblPreview.Text = "Preview"
        Me.lblPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExportPDF
        '
        Me.btnExportPDF.Font = New System.Drawing.Font("Arial", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportPDF.Location = New System.Drawing.Point(548, 398)
        Me.btnExportPDF.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExportPDF.Name = "btnExportPDF"
        Me.btnExportPDF.Size = New System.Drawing.Size(205, 32)
        Me.btnExportPDF.TabIndex = 19
        Me.btnExportPDF.Text = "Export as PDF"
        Me.btnExportPDF.UseVisualStyleBackColor = True
        '
        'panelControlTop
        '
        Me.panelControlTop.BackColor = System.Drawing.Color.Black
        Me.panelControlTop.Controls.Add(Me.lblIcon)
        Me.panelControlTop.Controls.Add(Me.btnClose)
        Me.panelControlTop.Controls.Add(Me.lblFormName)
        Me.panelControlTop.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.panelControlTop.Location = New System.Drawing.Point(0, -2)
        Me.panelControlTop.Margin = New System.Windows.Forms.Padding(2)
        Me.panelControlTop.Name = "panelControlTop"
        Me.panelControlTop.Size = New System.Drawing.Size(800, 31)
        Me.panelControlTop.TabIndex = 20
        '
        'lblIcon
        '
        Me.lblIcon.AutoSize = True
        Me.lblIcon.Font = New System.Drawing.Font("Arial Black", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIcon.Location = New System.Drawing.Point(2, 0)
        Me.lblIcon.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIcon.Name = "lblIcon"
        Me.lblIcon.Size = New System.Drawing.Size(31, 31)
        Me.lblIcon.TabIndex = 2
        Me.lblIcon.Text = "B"
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(754, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(44, 31)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblFormName
        '
        Me.lblFormName.AutoSize = True
        Me.lblFormName.Font = New System.Drawing.Font("Arial", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormName.Location = New System.Drawing.Point(30, 9)
        Me.lblFormName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFormName.Name = "lblFormName"
        Me.lblFormName.Size = New System.Drawing.Size(216, 16)
        Me.lblFormName.TabIndex = 0
        Me.lblFormName.Text = "Buxton Net Profit/Loss Generator"
        '
        'panelContentContainer
        '
        Me.panelContentContainer.BackColor = System.Drawing.Color.White
        Me.panelContentContainer.Controls.Add(Me.ListBox2)
        Me.panelContentContainer.Controls.Add(Me.ListBox1)
        Me.panelContentContainer.Controls.Add(Me.separator4)
        Me.panelContentContainer.Controls.Add(Me.lblSummary)
        Me.panelContentContainer.Controls.Add(Me.separator5)
        Me.panelContentContainer.Controls.Add(Me.lblPreview)
        Me.panelContentContainer.Controls.Add(Me.separator3)
        Me.panelContentContainer.Controls.Add(Me.lblRevenueItemsVal)
        Me.panelContentContainer.Controls.Add(Me.separator1)
        Me.panelContentContainer.Controls.Add(Me.btnExportPDF)
        Me.panelContentContainer.Controls.Add(Me.lblExpenseItemsVal)
        Me.panelContentContainer.Controls.Add(Me.lblRevenueItemsPrompt)
        Me.panelContentContainer.Controls.Add(Me.lblRevenueTotalVal)
        Me.panelContentContainer.Controls.Add(Me.lblExpenseItemsPrompt)
        Me.panelContentContainer.Controls.Add(Me.lblRevenueTotalPrompt)
        Me.panelContentContainer.Controls.Add(Me.picLogo)
        Me.panelContentContainer.Controls.Add(Me.lblTitle)
        Me.panelContentContainer.Controls.Add(Me.lblControls)
        Me.panelContentContainer.Controls.Add(Me.lblExpenseTotalPrompt)
        Me.panelContentContainer.Location = New System.Drawing.Point(4, 24)
        Me.panelContentContainer.Margin = New System.Windows.Forms.Padding(2)
        Me.panelContentContainer.Name = "panelContentContainer"
        Me.panelContentContainer.Size = New System.Drawing.Size(788, 451)
        Me.panelContentContainer.TabIndex = 21
        '
        'separator4
        '
        Me.separator4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.separator4.Location = New System.Drawing.Point(0, 117)
        Me.separator4.Margin = New System.Windows.Forms.Padding(2)
        Me.separator4.Name = "separator4"
        Me.separator4.Size = New System.Drawing.Size(518, 2)
        Me.separator4.TabIndex = 23
        Me.separator4.Text = "Button2"
        Me.separator4.UseVisualStyleBackColor = True
        '
        'separator5
        '
        Me.separator5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.separator5.Location = New System.Drawing.Point(0, 75)
        Me.separator5.Margin = New System.Windows.Forms.Padding(2)
        Me.separator5.Name = "separator5"
        Me.separator5.Size = New System.Drawing.Size(518, 2)
        Me.separator5.TabIndex = 22
        Me.separator5.Text = "Button1"
        Me.separator5.UseVisualStyleBackColor = True
        '
        'dlgOpen
        '
        Me.dlgOpen.FileName = "OpenFileDialog1"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(559, 117)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(102, 225)
        Me.ListBox1.TabIndex = 24
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(651, 117)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(102, 225)
        Me.ListBox2.TabIndex = 25
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(794, 480)
        Me.Controls.Add(Me.panelControlTop)
        Me.Controls.Add(Me.lblExpenseTotalVal)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.separator2)
        Me.Controls.Add(Me.panelContentContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buxton Net Profit/Loss Generator"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelControlTop.ResumeLayout(False)
        Me.panelControlTop.PerformLayout()
        Me.panelContentContainer.ResumeLayout(False)
        Me.panelContentContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents separator1 As Button
    Friend WithEvents separator2 As Button
    Friend WithEvents btnImport As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents lblControls As Label
    Friend WithEvents separator3 As Button
    Friend WithEvents lblSummary As Label
    Friend WithEvents lblExpenseTotalPrompt As Label
    Friend WithEvents lblExpenseTotalVal As Label
    Friend WithEvents lblRevenueTotalVal As Label
    Friend WithEvents lblRevenueTotalPrompt As Label
    Friend WithEvents lblExpenseItemsVal As Label
    Friend WithEvents lblExpenseItemsPrompt As Label
    Friend WithEvents lblRevenueItemsVal As Label
    Friend WithEvents lblRevenueItemsPrompt As Label
    Friend WithEvents lblPreview As Label
    Friend WithEvents btnExportPDF As Button
    Friend WithEvents panelControlTop As Panel
    Friend WithEvents lblFormName As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents panelContentContainer As Panel
    Friend WithEvents separator4 As Button
    Friend WithEvents separator5 As Button
    Friend WithEvents lblIcon As Label
    Friend WithEvents dlgOpen As OpenFileDialog
    Friend WithEvents dlgSave As SaveFileDialog
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
End Class
