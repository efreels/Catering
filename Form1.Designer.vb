<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatering
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
        Me.picPlatter = New System.Windows.Forms.PictureBox()
        Me.lblCatering = New System.Windows.Forms.Label()
        Me.lblStarMarket = New System.Windows.Forms.Label()
        Me.grpPayment = New System.Windows.Forms.GroupBox()
        Me.radPickup = New System.Windows.Forms.RadioButton()
        Me.radPrePay = New System.Windows.Forms.RadioButton()
        Me.radGourmet = New System.Windows.Forms.RadioButton()
        Me.radPinwheel = New System.Windows.Forms.RadioButton()
        Me.radVeggie = New System.Windows.Forms.RadioButton()
        Me.radSausageNCheese = New System.Windows.Forms.RadioButton()
        Me.radFruit = New System.Windows.Forms.RadioButton()
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.lblLoyalty = New System.Windows.Forms.Label()
        Me.txtPoints = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblPleasePay = New System.Windows.Forms.Label()
        Me.lblPayTotal = New System.Windows.Forms.Label()
        CType(Me.picPlatter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPayment.SuspendLayout()
        Me.grpType.SuspendLayout()
        Me.SuspendLayout()
        '
        'picPlatter
        '
        Me.picPlatter.BackgroundImage = Global.Catering.My.Resources.Resources.platter
        Me.picPlatter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlatter.Location = New System.Drawing.Point(379, 12)
        Me.picPlatter.Name = "picPlatter"
        Me.picPlatter.Size = New System.Drawing.Size(409, 248)
        Me.picPlatter.TabIndex = 0
        Me.picPlatter.TabStop = False
        '
        'lblCatering
        '
        Me.lblCatering.AutoSize = True
        Me.lblCatering.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCatering.Location = New System.Drawing.Point(103, 12)
        Me.lblCatering.Name = "lblCatering"
        Me.lblCatering.Size = New System.Drawing.Size(137, 38)
        Me.lblCatering.TabIndex = 1
        Me.lblCatering.Text = "Catering"
        '
        'lblStarMarket
        '
        Me.lblStarMarket.AutoSize = True
        Me.lblStarMarket.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStarMarket.Location = New System.Drawing.Point(105, 50)
        Me.lblStarMarket.Name = "lblStarMarket"
        Me.lblStarMarket.Size = New System.Drawing.Size(123, 25)
        Me.lblStarMarket.TabIndex = 2
        Me.lblStarMarket.Text = "Star Market"
        '
        'grpPayment
        '
        Me.grpPayment.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpPayment.Controls.Add(Me.radPickup)
        Me.grpPayment.Controls.Add(Me.radPrePay)
        Me.grpPayment.Location = New System.Drawing.Point(93, 302)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Size = New System.Drawing.Size(200, 90)
        Me.grpPayment.TabIndex = 4
        Me.grpPayment.TabStop = False
        '
        'radPickup
        '
        Me.radPickup.AutoSize = True
        Me.radPickup.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPickup.Location = New System.Drawing.Point(16, 47)
        Me.radPickup.Name = "radPickup"
        Me.radPickup.Size = New System.Drawing.Size(144, 22)
        Me.radPickup.TabIndex = 7
        Me.radPickup.Text = "Pay upon Pickup"
        Me.radPickup.UseVisualStyleBackColor = True
        '
        'radPrePay
        '
        Me.radPrePay.AutoSize = True
        Me.radPrePay.Checked = True
        Me.radPrePay.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPrePay.Location = New System.Drawing.Point(16, 19)
        Me.radPrePay.Name = "radPrePay"
        Me.radPrePay.Size = New System.Drawing.Size(85, 22)
        Me.radPrePay.TabIndex = 6
        Me.radPrePay.TabStop = True
        Me.radPrePay.Text = "Pre-Pay"
        Me.radPrePay.UseVisualStyleBackColor = True
        '
        'radGourmet
        '
        Me.radGourmet.AutoSize = True
        Me.radGourmet.Checked = True
        Me.radGourmet.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radGourmet.Location = New System.Drawing.Point(23, 19)
        Me.radGourmet.Name = "radGourmet"
        Me.radGourmet.Size = New System.Drawing.Size(197, 22)
        Me.radGourmet.TabIndex = 1
        Me.radGourmet.TabStop = True
        Me.radGourmet.Text = "Gourmet Cheese $49.99"
        Me.radGourmet.UseVisualStyleBackColor = True
        '
        'radPinwheel
        '
        Me.radPinwheel.AutoSize = True
        Me.radPinwheel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPinwheel.Location = New System.Drawing.Point(23, 47)
        Me.radPinwheel.Name = "radPinwheel"
        Me.radPinwheel.Size = New System.Drawing.Size(193, 22)
        Me.radPinwheel.TabIndex = 2
        Me.radPinwheel.Text = "Pinwheel Wraps $59.99"
        Me.radPinwheel.UseVisualStyleBackColor = True
        '
        'radVeggie
        '
        Me.radVeggie.AutoSize = True
        Me.radVeggie.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radVeggie.Location = New System.Drawing.Point(23, 75)
        Me.radVeggie.Name = "radVeggie"
        Me.radVeggie.Size = New System.Drawing.Size(126, 22)
        Me.radVeggie.TabIndex = 3
        Me.radVeggie.Text = "Veggie $29.99"
        Me.radVeggie.UseVisualStyleBackColor = True
        '
        'radSausageNCheese
        '
        Me.radSausageNCheese.AutoSize = True
        Me.radSausageNCheese.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSausageNCheese.Location = New System.Drawing.Point(23, 103)
        Me.radSausageNCheese.Name = "radSausageNCheese"
        Me.radSausageNCheese.Size = New System.Drawing.Size(220, 22)
        Me.radSausageNCheese.TabIndex = 4
        Me.radSausageNCheese.Text = "Sausage and Cheese $49.99"
        Me.radSausageNCheese.UseVisualStyleBackColor = True
        '
        'radFruit
        '
        Me.radFruit.AutoSize = True
        Me.radFruit.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFruit.Location = New System.Drawing.Point(23, 131)
        Me.radFruit.Name = "radFruit"
        Me.radFruit.Size = New System.Drawing.Size(115, 22)
        Me.radFruit.TabIndex = 5
        Me.radFruit.Text = "Fruit $29.99"
        Me.radFruit.UseVisualStyleBackColor = True
        '
        'grpType
        '
        Me.grpType.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpType.Controls.Add(Me.radFruit)
        Me.grpType.Controls.Add(Me.radGourmet)
        Me.grpType.Controls.Add(Me.radSausageNCheese)
        Me.grpType.Controls.Add(Me.radPinwheel)
        Me.grpType.Controls.Add(Me.radVeggie)
        Me.grpType.Location = New System.Drawing.Point(59, 101)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(269, 175)
        Me.grpType.TabIndex = 5
        Me.grpType.TabStop = False
        '
        'lblLoyalty
        '
        Me.lblLoyalty.AutoSize = True
        Me.lblLoyalty.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoyalty.Location = New System.Drawing.Point(434, 289)
        Me.lblLoyalty.Name = "lblLoyalty"
        Me.lblLoyalty.Size = New System.Drawing.Size(127, 18)
        Me.lblLoyalty.TabIndex = 6
        Me.lblLoyalty.Text = "Loyalty Points"
        '
        'txtPoints
        '
        Me.txtPoints.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoints.Location = New System.Drawing.Point(598, 286)
        Me.txtPoints.Name = "txtPoints"
        Me.txtPoints.Size = New System.Drawing.Size(50, 26)
        Me.txtPoints.TabIndex = 0
        Me.txtPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.PeachPuff
        Me.btnCalc.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCalc.Location = New System.Drawing.Point(404, 352)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(125, 33)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.PeachPuff
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(607, 352)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(125, 33)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblPleasePay
        '
        Me.lblPleasePay.AutoSize = True
        Me.lblPleasePay.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPleasePay.Location = New System.Drawing.Point(20, 412)
        Me.lblPleasePay.Name = "lblPleasePay"
        Me.lblPleasePay.Size = New System.Drawing.Size(130, 23)
        Me.lblPleasePay.TabIndex = 10
        Me.lblPleasePay.Text = "Please Pay:  "
        '
        'lblPayTotal
        '
        Me.lblPayTotal.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayTotal.Location = New System.Drawing.Point(156, 412)
        Me.lblPayTotal.Name = "lblPayTotal"
        Me.lblPayTotal.Size = New System.Drawing.Size(600, 46)
        Me.lblPayTotal.TabIndex = 11
        Me.lblPayTotal.Text = "Payment Goes Here"
        '
        'frmCatering
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(800, 476)
        Me.Controls.Add(Me.lblPayTotal)
        Me.Controls.Add(Me.lblPleasePay)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtPoints)
        Me.Controls.Add(Me.lblLoyalty)
        Me.Controls.Add(Me.grpType)
        Me.Controls.Add(Me.grpPayment)
        Me.Controls.Add(Me.lblStarMarket)
        Me.Controls.Add(Me.lblCatering)
        Me.Controls.Add(Me.picPlatter)
        Me.Name = "frmCatering"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catering"
        CType(Me.picPlatter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPayment.ResumeLayout(False)
        Me.grpPayment.PerformLayout()
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPlatter As PictureBox
    Friend WithEvents lblCatering As Label
    Friend WithEvents lblStarMarket As Label
    Friend WithEvents grpPayment As GroupBox
    Friend WithEvents radPickup As RadioButton
    Friend WithEvents radPrePay As RadioButton
    Friend WithEvents radGourmet As RadioButton
    Friend WithEvents radPinwheel As RadioButton
    Friend WithEvents radVeggie As RadioButton
    Friend WithEvents radSausageNCheese As RadioButton
    Friend WithEvents radFruit As RadioButton
    Friend WithEvents grpType As GroupBox
    Friend WithEvents lblLoyalty As Label
    Friend WithEvents txtPoints As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblPleasePay As Label
    Friend WithEvents lblPayTotal As Label
End Class
