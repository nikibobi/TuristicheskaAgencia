﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTouristAgency
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTouristAgency))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpTrips = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.cmbDestination = New System.Windows.Forms.ComboBox()
        Me.cmbContinent = New System.Windows.Forms.ComboBox()
        Me.tpReservations = New System.Windows.Forms.TabPage()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numReservations = New System.Windows.Forms.NumericUpDown()
        Me.numDurations = New System.Windows.Forms.NumericUpDown()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.lblDestinationInfoRez = New System.Windows.Forms.Label()
        Me.lblPaymentOption = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.rbBankAccount = New System.Windows.Forms.RadioButton()
        Me.rbCard = New System.Windows.Forms.RadioButton()
        Me.rbCash = New System.Windows.Forms.RadioButton()
        Me.cmbDestinationRez = New System.Windows.Forms.ComboBox()
        Me.cmbContinentRez = New System.Windows.Forms.ComboBox()
        Me.txtAdress = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblAdress = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbPayPal = New System.Windows.Forms.RadioButton()
        Me.rb_ePay = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.tpTrips.SuspendLayout()
        Me.tpReservations.SuspendLayout()
        CType(Me.numReservations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDurations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpTrips)
        Me.TabControl1.Controls.Add(Me.tpReservations)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(468, 438)
        Me.TabControl1.TabIndex = 0
        '
        'tpTrips
        '
        Me.tpTrips.Controls.Add(Me.Label2)
        Me.tpTrips.Controls.Add(Me.lblResult)
        Me.tpTrips.Controls.Add(Me.cmbDestination)
        Me.tpTrips.Controls.Add(Me.cmbContinent)
        Me.tpTrips.Location = New System.Drawing.Point(4, 22)
        Me.tpTrips.Name = "tpTrips"
        Me.tpTrips.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTrips.Size = New System.Drawing.Size(460, 412)
        Me.tpTrips.TabIndex = 0
        Me.tpTrips.Text = "Екскурции"
        Me.tpTrips.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Моля изберете континент и дестинация:"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(37, 104)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 13)
        Me.lblResult.TabIndex = 2
        '
        'cmbDestination
        '
        Me.cmbDestination.FormattingEnabled = True
        Me.cmbDestination.Location = New System.Drawing.Point(272, 43)
        Me.cmbDestination.Name = "cmbDestination"
        Me.cmbDestination.Size = New System.Drawing.Size(121, 21)
        Me.cmbDestination.TabIndex = 1
        '
        'cmbContinent
        '
        Me.cmbContinent.FormattingEnabled = True
        Me.cmbContinent.Items.AddRange(New Object() {"Европа", "Азия", "Африка", "Америка"})
        Me.cmbContinent.Location = New System.Drawing.Point(40, 43)
        Me.cmbContinent.Name = "cmbContinent"
        Me.cmbContinent.Size = New System.Drawing.Size(121, 21)
        Me.cmbContinent.TabIndex = 0
        '
        'tpReservations
        '
        Me.tpReservations.Controls.Add(Me.rb_ePay)
        Me.tpReservations.Controls.Add(Me.rbPayPal)
        Me.tpReservations.Controls.Add(Me.Label5)
        Me.tpReservations.Controls.Add(Me.lblPrice)
        Me.tpReservations.Controls.Add(Me.Label4)
        Me.tpReservations.Controls.Add(Me.Label1)
        Me.tpReservations.Controls.Add(Me.numReservations)
        Me.tpReservations.Controls.Add(Me.numDurations)
        Me.tpReservations.Controls.Add(Me.dtpStartDate)
        Me.tpReservations.Controls.Add(Me.Label3)
        Me.tpReservations.Controls.Add(Me.lblEndDate)
        Me.tpReservations.Controls.Add(Me.txtPhone)
        Me.tpReservations.Controls.Add(Me.lblDestinationInfoRez)
        Me.tpReservations.Controls.Add(Me.lblPaymentOption)
        Me.tpReservations.Controls.Add(Me.btnAdd)
        Me.tpReservations.Controls.Add(Me.rbBankAccount)
        Me.tpReservations.Controls.Add(Me.rbCard)
        Me.tpReservations.Controls.Add(Me.rbCash)
        Me.tpReservations.Controls.Add(Me.cmbDestinationRez)
        Me.tpReservations.Controls.Add(Me.cmbContinentRez)
        Me.tpReservations.Controls.Add(Me.txtAdress)
        Me.tpReservations.Controls.Add(Me.txtSurname)
        Me.tpReservations.Controls.Add(Me.txtName)
        Me.tpReservations.Controls.Add(Me.lblAdress)
        Me.tpReservations.Controls.Add(Me.lblPhone)
        Me.tpReservations.Controls.Add(Me.lblSurname)
        Me.tpReservations.Controls.Add(Me.lblName)
        Me.tpReservations.Location = New System.Drawing.Point(4, 22)
        Me.tpReservations.Name = "tpReservations"
        Me.tpReservations.Padding = New System.Windows.Forms.Padding(3)
        Me.tpReservations.Size = New System.Drawing.Size(460, 412)
        Me.tpReservations.TabIndex = 1
        Me.tpReservations.Text = "Резервации"
        Me.tpReservations.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPrice.Location = New System.Drawing.Point(249, 345)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(0, 13)
        Me.lblPrice.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(219, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Изберете начална дата и брой дни:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 290)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Брой резервации:"
        '
        'numReservations
        '
        Me.numReservations.Location = New System.Drawing.Point(143, 288)
        Me.numReservations.Name = "numReservations"
        Me.numReservations.Size = New System.Drawing.Size(60, 20)
        Me.numReservations.TabIndex = 27
        '
        'numDurations
        '
        Me.numDurations.Location = New System.Drawing.Point(187, 246)
        Me.numDurations.Name = "numDurations"
        Me.numDurations.Size = New System.Drawing.Size(86, 20)
        Me.numDurations.TabIndex = 26
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(26, 246)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(155, 20)
        Me.dtpStartDate.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Изберете континент и дестинация:"
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Location = New System.Drawing.Point(338, 248)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(0, 13)
        Me.lblEndDate.TabIndex = 21
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(80, 65)
        Me.txtPhone.Mask = "0000000000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtPhone.Size = New System.Drawing.Size(236, 20)
        Me.txtPhone.TabIndex = 19
        '
        'lblDestinationInfoRez
        '
        Me.lblDestinationInfoRez.AutoSize = True
        Me.lblDestinationInfoRez.Location = New System.Drawing.Point(23, 158)
        Me.lblDestinationInfoRez.Name = "lblDestinationInfoRez"
        Me.lblDestinationInfoRez.Size = New System.Drawing.Size(0, 13)
        Me.lblDestinationInfoRez.TabIndex = 17
        '
        'lblPaymentOption
        '
        Me.lblPaymentOption.AutoSize = True
        Me.lblPaymentOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblPaymentOption.Location = New System.Drawing.Point(23, 329)
        Me.lblPaymentOption.Name = "lblPaymentOption"
        Me.lblPaymentOption.Size = New System.Drawing.Size(180, 13)
        Me.lblPaymentOption.TabIndex = 16
        Me.lblPaymentOption.Text = "Изберете начин на плащане:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(379, 383)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Добави"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'rbBankAccount
        '
        Me.rbBankAccount.AutoSize = True
        Me.rbBankAccount.Location = New System.Drawing.Point(26, 389)
        Me.rbBankAccount.Name = "rbBankAccount"
        Me.rbBankAccount.Size = New System.Drawing.Size(85, 17)
        Me.rbBankAccount.TabIndex = 13
        Me.rbBankAccount.Text = "Банков Път"
        Me.rbBankAccount.UseVisualStyleBackColor = True
        '
        'rbCard
        '
        Me.rbCard.AutoSize = True
        Me.rbCard.Location = New System.Drawing.Point(26, 368)
        Me.rbCard.Name = "rbCard"
        Me.rbCard.Size = New System.Drawing.Size(64, 17)
        Me.rbCard.TabIndex = 12
        Me.rbCard.Text = "С карта"
        Me.rbCard.UseVisualStyleBackColor = True
        '
        'rbCash
        '
        Me.rbCash.AutoSize = True
        Me.rbCash.Checked = True
        Me.rbCash.Location = New System.Drawing.Point(26, 345)
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Size = New System.Drawing.Size(50, 17)
        Me.rbCash.TabIndex = 11
        Me.rbCash.TabStop = True
        Me.rbCash.Text = "Брой"
        Me.rbCash.UseVisualStyleBackColor = True
        '
        'cmbDestinationRez
        '
        Me.cmbDestinationRez.FormattingEnabled = True
        Me.cmbDestinationRez.Location = New System.Drawing.Point(287, 134)
        Me.cmbDestinationRez.Name = "cmbDestinationRez"
        Me.cmbDestinationRez.Size = New System.Drawing.Size(152, 21)
        Me.cmbDestinationRez.TabIndex = 9
        '
        'cmbContinentRez
        '
        Me.cmbContinentRez.FormattingEnabled = True
        Me.cmbContinentRez.Items.AddRange(New Object() {"Европа", "Азия", "Африка", "Америка"})
        Me.cmbContinentRez.Location = New System.Drawing.Point(26, 134)
        Me.cmbContinentRez.Name = "cmbContinentRez"
        Me.cmbContinentRez.Size = New System.Drawing.Size(155, 21)
        Me.cmbContinentRez.TabIndex = 8
        '
        'txtAdress
        '
        Me.txtAdress.Location = New System.Drawing.Point(80, 86)
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(236, 20)
        Me.txtAdress.TabIndex = 7
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(80, 44)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(236, 20)
        Me.txtSurname.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(80, 23)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(236, 20)
        Me.txtName.TabIndex = 4
        '
        'lblAdress
        '
        Me.lblAdress.AutoSize = True
        Me.lblAdress.Location = New System.Drawing.Point(23, 89)
        Me.lblAdress.Name = "lblAdress"
        Me.lblAdress.Size = New System.Drawing.Size(38, 13)
        Me.lblAdress.TabIndex = 3
        Me.lblAdress.Text = "Адрес"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(23, 68)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(52, 13)
        Me.lblPhone.TabIndex = 2
        Me.lblPhone.Text = "Телефон"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(23, 47)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(56, 13)
        Me.lblSurname.TabIndex = 1
        Me.lblSurname.Text = "Фамилия"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(23, 26)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(29, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Име"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(320, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "(крайна дата)"
        '
        'rbPayPal
        '
        Me.rbPayPal.AutoSize = True
        Me.rbPayPal.Location = New System.Drawing.Point(126, 345)
        Me.rbPayPal.Name = "rbPayPal"
        Me.rbPayPal.Size = New System.Drawing.Size(81, 17)
        Me.rbPayPal.TabIndex = 31
        Me.rbPayPal.TabStop = True
        Me.rbPayPal.Text = "PayPal.com"
        Me.rbPayPal.UseVisualStyleBackColor = True
        '
        'rb_ePay
        '
        Me.rb_ePay.AutoSize = True
        Me.rb_ePay.Location = New System.Drawing.Point(126, 368)
        Me.rb_ePay.Name = "rb_ePay"
        Me.rb_ePay.Size = New System.Drawing.Size(64, 17)
        Me.rb_ePay.TabIndex = 32
        Me.rb_ePay.TabStop = True
        Me.rb_ePay.Text = "ePay.bg"
        Me.rb_ePay.UseVisualStyleBackColor = True
        '
        'frmTouristAgency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 462)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "frmTouristAgency"
        Me.Text = "Туристическа агенция"
        Me.TabControl1.ResumeLayout(False)
        Me.tpTrips.ResumeLayout(False)
        Me.tpTrips.PerformLayout()
        Me.tpReservations.ResumeLayout(False)
        Me.tpReservations.PerformLayout()
        CType(Me.numReservations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDurations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpTrips As System.Windows.Forms.TabPage
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents cmbDestination As System.Windows.Forms.ComboBox
    Friend WithEvents cmbContinent As System.Windows.Forms.ComboBox
    Friend WithEvents tpReservations As System.Windows.Forms.TabPage
    Friend WithEvents cmbDestinationRez As System.Windows.Forms.ComboBox
    Friend WithEvents cmbContinentRez As System.Windows.Forms.ComboBox
    Friend WithEvents txtAdress As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblAdress As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents rbBankAccount As System.Windows.Forms.RadioButton
    Friend WithEvents rbCard As System.Windows.Forms.RadioButton
    Friend WithEvents rbCash As System.Windows.Forms.RadioButton
    Friend WithEvents lblDestinationInfoRez As System.Windows.Forms.Label
    Friend WithEvents lblPaymentOption As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents numReservations As System.Windows.Forms.NumericUpDown
    Friend WithEvents numDurations As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rb_ePay As System.Windows.Forms.RadioButton
    Friend WithEvents rbPayPal As System.Windows.Forms.RadioButton

End Class
