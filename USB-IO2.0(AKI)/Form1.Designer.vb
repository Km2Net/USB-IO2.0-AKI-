<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnSendRecv = New System.Windows.Forms.Button()
        Me.BtnConnect = New System.Windows.Forms.Button()
        Me.pnlRunning = New System.Windows.Forms.Panel()
        Me.BtnIoJ17 = New System.Windows.Forms.Button()
        Me.LblIoJ1 = New System.Windows.Forms.Label()
        Me.LblIoJ2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnIoJ23 = New System.Windows.Forms.Button()
        Me.BtnIoJ22 = New System.Windows.Forms.Button()
        Me.BtnIoJ21 = New System.Windows.Forms.Button()
        Me.BtnIoJ20 = New System.Windows.Forms.Button()
        Me.BtnIoJ16 = New System.Windows.Forms.Button()
        Me.BtnIoJ15 = New System.Windows.Forms.Button()
        Me.BtnIoJ14 = New System.Windows.Forms.Button()
        Me.BtnIoJ13 = New System.Windows.Forms.Button()
        Me.BtnIoJ12 = New System.Windows.Forms.Button()
        Me.BtnIoJ11 = New System.Windows.Forms.Button()
        Me.BtnIoJ10 = New System.Windows.Forms.Button()
        Me.PnlStting = New System.Windows.Forms.Panel()
        Me.LblPullUp = New System.Windows.Forms.Label()
        Me.ChkPullUpStop = New System.Windows.Forms.CheckBox()
        Me.BtnSetting = New System.Windows.Forms.Button()
        Me.LblStInJ1 = New System.Windows.Forms.Label()
        Me.LblStInJ2 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.BtnStInJ23 = New System.Windows.Forms.Button()
        Me.BtnStInJ22 = New System.Windows.Forms.Button()
        Me.BtnStInJ21 = New System.Windows.Forms.Button()
        Me.BtnStInJ20 = New System.Windows.Forms.Button()
        Me.BtnStInJ17 = New System.Windows.Forms.Button()
        Me.BtnStInJ16 = New System.Windows.Forms.Button()
        Me.BtnStInJ15 = New System.Windows.Forms.Button()
        Me.BtnStInJ14 = New System.Windows.Forms.Button()
        Me.BtnStInJ13 = New System.Windows.Forms.Button()
        Me.BtnStInJ12 = New System.Windows.Forms.Button()
        Me.BtnStInJ11 = New System.Windows.Forms.Button()
        Me.BtnStInJ10 = New System.Windows.Forms.Button()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.TmrSendRecv = New System.Windows.Forms.Timer(Me.components)
        Me.BtnKm2Net = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlRunning.SuspendLayout()
        Me.PnlStting.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSendRecv
        '
        Me.btnSendRecv.Location = New System.Drawing.Point(12, 176)
        Me.btnSendRecv.Name = "btnSendRecv"
        Me.btnSendRecv.Size = New System.Drawing.Size(59, 27)
        Me.btnSendRecv.TabIndex = 35
        Me.btnSendRecv.Text = "送受信"
        Me.btnSendRecv.UseVisualStyleBackColor = True
        '
        'BtnConnect
        '
        Me.BtnConnect.Location = New System.Drawing.Point(12, 3)
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.Size = New System.Drawing.Size(59, 27)
        Me.BtnConnect.TabIndex = 34
        Me.BtnConnect.Text = "接続"
        Me.BtnConnect.UseVisualStyleBackColor = True
        '
        'pnlRunning
        '
        Me.pnlRunning.BackColor = System.Drawing.SystemColors.HotTrack
        Me.pnlRunning.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlRunning.Controls.Add(Me.BtnIoJ17)
        Me.pnlRunning.Controls.Add(Me.LblIoJ1)
        Me.pnlRunning.Controls.Add(Me.LblIoJ2)
        Me.pnlRunning.Controls.Add(Me.Label14)
        Me.pnlRunning.Controls.Add(Me.Label13)
        Me.pnlRunning.Controls.Add(Me.Label10)
        Me.pnlRunning.Controls.Add(Me.Label9)
        Me.pnlRunning.Controls.Add(Me.BtnIoJ23)
        Me.pnlRunning.Controls.Add(Me.BtnIoJ22)
        Me.pnlRunning.Controls.Add(Me.BtnIoJ21)
        Me.pnlRunning.Controls.Add(Me.BtnIoJ20)
        Me.pnlRunning.Controls.Add(Me.BtnIoJ16)
        Me.pnlRunning.Controls.Add(Me.BtnIoJ15)
        Me.pnlRunning.Controls.Add(Me.BtnIoJ14)
        Me.pnlRunning.Controls.Add(Me.BtnIoJ13)
        Me.pnlRunning.Controls.Add(Me.BtnIoJ12)
        Me.pnlRunning.Controls.Add(Me.BtnIoJ11)
        Me.pnlRunning.Controls.Add(Me.BtnIoJ10)
        Me.pnlRunning.ForeColor = System.Drawing.Color.Yellow
        Me.pnlRunning.Location = New System.Drawing.Point(12, 209)
        Me.pnlRunning.Name = "pnlRunning"
        Me.pnlRunning.Size = New System.Drawing.Size(290, 123)
        Me.pnlRunning.TabIndex = 36
        '
        'BtnIoJ17
        '
        Me.BtnIoJ17.BackColor = System.Drawing.Color.Red
        Me.BtnIoJ17.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnIoJ17.Location = New System.Drawing.Point(254, 63)
        Me.BtnIoJ17.Name = "BtnIoJ17"
        Me.BtnIoJ17.Size = New System.Drawing.Size(30, 30)
        Me.BtnIoJ17.TabIndex = 19
        Me.BtnIoJ17.Text = "7"
        Me.BtnIoJ17.UseVisualStyleBackColor = False
        '
        'LblIoJ1
        '
        Me.LblIoJ1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblIoJ1.Font = New System.Drawing.Font("ＭＳ 明朝", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblIoJ1.Location = New System.Drawing.Point(46, 96)
        Me.LblIoJ1.Name = "LblIoJ1"
        Me.LblIoJ1.Size = New System.Drawing.Size(130, 21)
        Me.LblIoJ1.TabIndex = 18
        Me.LblIoJ1.Text = "I:&&hFF O:&&hFF"
        '
        'LblIoJ2
        '
        Me.LblIoJ2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblIoJ2.Font = New System.Drawing.Font("ＭＳ 明朝", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblIoJ2.Location = New System.Drawing.Point(153, 2)
        Me.LblIoJ2.Name = "LblIoJ2"
        Me.LblIoJ2.Size = New System.Drawing.Size(130, 21)
        Me.LblIoJ2.TabIndex = 17
        Me.LblIoJ2.Text = "I:&&h0F O:&&h0F"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label14.Location = New System.Drawing.Point(24, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(23, 16)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "J1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.Location = New System.Drawing.Point(127, 3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 16)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "J2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 16)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "入出力状態"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "USB-IO 2.0"
        '
        'BtnIoJ23
        '
        Me.BtnIoJ23.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnIoJ23.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnIoJ23.Location = New System.Drawing.Point(146, 25)
        Me.BtnIoJ23.Name = "BtnIoJ23"
        Me.BtnIoJ23.Size = New System.Drawing.Size(30, 30)
        Me.BtnIoJ23.TabIndex = 12
        Me.BtnIoJ23.Text = "3"
        Me.BtnIoJ23.UseVisualStyleBackColor = False
        '
        'BtnIoJ22
        '
        Me.BtnIoJ22.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnIoJ22.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnIoJ22.Location = New System.Drawing.Point(182, 25)
        Me.BtnIoJ22.Name = "BtnIoJ22"
        Me.BtnIoJ22.Size = New System.Drawing.Size(30, 30)
        Me.BtnIoJ22.TabIndex = 11
        Me.BtnIoJ22.Text = "2"
        Me.BtnIoJ22.UseVisualStyleBackColor = False
        '
        'BtnIoJ21
        '
        Me.BtnIoJ21.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnIoJ21.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnIoJ21.Location = New System.Drawing.Point(218, 25)
        Me.BtnIoJ21.Name = "BtnIoJ21"
        Me.BtnIoJ21.Size = New System.Drawing.Size(30, 30)
        Me.BtnIoJ21.TabIndex = 10
        Me.BtnIoJ21.Text = "1"
        Me.BtnIoJ21.UseVisualStyleBackColor = False
        '
        'BtnIoJ20
        '
        Me.BtnIoJ20.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnIoJ20.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnIoJ20.Location = New System.Drawing.Point(254, 25)
        Me.BtnIoJ20.Name = "BtnIoJ20"
        Me.BtnIoJ20.Size = New System.Drawing.Size(30, 30)
        Me.BtnIoJ20.TabIndex = 9
        Me.BtnIoJ20.Text = "0"
        Me.BtnIoJ20.UseVisualStyleBackColor = False
        '
        'BtnIoJ16
        '
        Me.BtnIoJ16.BackColor = System.Drawing.Color.Red
        Me.BtnIoJ16.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnIoJ16.Location = New System.Drawing.Point(218, 63)
        Me.BtnIoJ16.Name = "BtnIoJ16"
        Me.BtnIoJ16.Size = New System.Drawing.Size(30, 30)
        Me.BtnIoJ16.TabIndex = 7
        Me.BtnIoJ16.Text = "6"
        Me.BtnIoJ16.UseVisualStyleBackColor = False
        '
        'BtnIoJ15
        '
        Me.BtnIoJ15.BackColor = System.Drawing.Color.Red
        Me.BtnIoJ15.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnIoJ15.Location = New System.Drawing.Point(182, 63)
        Me.BtnIoJ15.Name = "BtnIoJ15"
        Me.BtnIoJ15.Size = New System.Drawing.Size(30, 30)
        Me.BtnIoJ15.TabIndex = 6
        Me.BtnIoJ15.Text = "5"
        Me.BtnIoJ15.UseVisualStyleBackColor = False
        '
        'BtnIoJ14
        '
        Me.BtnIoJ14.BackColor = System.Drawing.Color.Red
        Me.BtnIoJ14.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnIoJ14.Location = New System.Drawing.Point(146, 63)
        Me.BtnIoJ14.Name = "BtnIoJ14"
        Me.BtnIoJ14.Size = New System.Drawing.Size(30, 30)
        Me.BtnIoJ14.TabIndex = 5
        Me.BtnIoJ14.Text = "4"
        Me.BtnIoJ14.UseVisualStyleBackColor = False
        '
        'BtnIoJ13
        '
        Me.BtnIoJ13.BackColor = System.Drawing.Color.Red
        Me.BtnIoJ13.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnIoJ13.Location = New System.Drawing.Point(110, 63)
        Me.BtnIoJ13.Name = "BtnIoJ13"
        Me.BtnIoJ13.Size = New System.Drawing.Size(30, 30)
        Me.BtnIoJ13.TabIndex = 4
        Me.BtnIoJ13.Text = "3"
        Me.BtnIoJ13.UseVisualStyleBackColor = False
        '
        'BtnIoJ12
        '
        Me.BtnIoJ12.BackColor = System.Drawing.Color.Red
        Me.BtnIoJ12.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnIoJ12.Location = New System.Drawing.Point(74, 63)
        Me.BtnIoJ12.Name = "BtnIoJ12"
        Me.BtnIoJ12.Size = New System.Drawing.Size(30, 30)
        Me.BtnIoJ12.TabIndex = 3
        Me.BtnIoJ12.Text = "2"
        Me.BtnIoJ12.UseVisualStyleBackColor = False
        '
        'BtnIoJ11
        '
        Me.BtnIoJ11.BackColor = System.Drawing.Color.Red
        Me.BtnIoJ11.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnIoJ11.Location = New System.Drawing.Point(38, 63)
        Me.BtnIoJ11.Name = "BtnIoJ11"
        Me.BtnIoJ11.Size = New System.Drawing.Size(30, 30)
        Me.BtnIoJ11.TabIndex = 2
        Me.BtnIoJ11.Text = "1"
        Me.BtnIoJ11.UseVisualStyleBackColor = False
        '
        'BtnIoJ10
        '
        Me.BtnIoJ10.BackColor = System.Drawing.Color.Red
        Me.BtnIoJ10.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnIoJ10.Location = New System.Drawing.Point(2, 63)
        Me.BtnIoJ10.Name = "BtnIoJ10"
        Me.BtnIoJ10.Size = New System.Drawing.Size(30, 30)
        Me.BtnIoJ10.TabIndex = 1
        Me.BtnIoJ10.Text = "0"
        Me.BtnIoJ10.UseVisualStyleBackColor = False
        '
        'PnlStting
        '
        Me.PnlStting.BackColor = System.Drawing.SystemColors.Control
        Me.PnlStting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlStting.Controls.Add(Me.LblPullUp)
        Me.PnlStting.Controls.Add(Me.ChkPullUpStop)
        Me.PnlStting.Controls.Add(Me.BtnSetting)
        Me.PnlStting.Controls.Add(Me.LblStInJ1)
        Me.PnlStting.Controls.Add(Me.LblStInJ2)
        Me.PnlStting.Controls.Add(Me.Label19)
        Me.PnlStting.Controls.Add(Me.Label20)
        Me.PnlStting.Controls.Add(Me.Label21)
        Me.PnlStting.Controls.Add(Me.Label22)
        Me.PnlStting.Controls.Add(Me.BtnStInJ23)
        Me.PnlStting.Controls.Add(Me.BtnStInJ22)
        Me.PnlStting.Controls.Add(Me.BtnStInJ21)
        Me.PnlStting.Controls.Add(Me.BtnStInJ20)
        Me.PnlStting.Controls.Add(Me.BtnStInJ17)
        Me.PnlStting.Controls.Add(Me.BtnStInJ16)
        Me.PnlStting.Controls.Add(Me.BtnStInJ15)
        Me.PnlStting.Controls.Add(Me.BtnStInJ14)
        Me.PnlStting.Controls.Add(Me.BtnStInJ13)
        Me.PnlStting.Controls.Add(Me.BtnStInJ12)
        Me.PnlStting.Controls.Add(Me.BtnStInJ11)
        Me.PnlStting.Controls.Add(Me.BtnStInJ10)
        Me.PnlStting.ForeColor = System.Drawing.Color.Black
        Me.PnlStting.Location = New System.Drawing.Point(12, 36)
        Me.PnlStting.Name = "PnlStting"
        Me.PnlStting.Size = New System.Drawing.Size(290, 109)
        Me.PnlStting.TabIndex = 37
        '
        'LblPullUp
        '
        Me.LblPullUp.AutoSize = True
        Me.LblPullUp.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblPullUp.Location = New System.Drawing.Point(240, 21)
        Me.LblPullUp.Name = "LblPullUp"
        Me.LblPullUp.Size = New System.Drawing.Size(43, 26)
        Me.LblPullUp.TabIndex = 45
        Me.LblPullUp.Text = "PullUp" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "無効"
        '
        'ChkPullUpStop
        '
        Me.ChkPullUpStop.AutoSize = True
        Me.ChkPullUpStop.Location = New System.Drawing.Point(226, 29)
        Me.ChkPullUpStop.Name = "ChkPullUpStop"
        Me.ChkPullUpStop.Size = New System.Drawing.Size(15, 14)
        Me.ChkPullUpStop.TabIndex = 44
        Me.ChkPullUpStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkPullUpStop.UseVisualStyleBackColor = True
        '
        'BtnSetting
        '
        Me.BtnSetting.Location = New System.Drawing.Point(243, 56)
        Me.BtnSetting.Name = "BtnSetting"
        Me.BtnSetting.Size = New System.Drawing.Size(39, 44)
        Me.BtnSetting.TabIndex = 38
        Me.BtnSetting.Text = "設定変更"
        Me.BtnSetting.UseVisualStyleBackColor = True
        '
        'LblStInJ1
        '
        Me.LblStInJ1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblStInJ1.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblStInJ1.Location = New System.Drawing.Point(38, 82)
        Me.LblStInJ1.Name = "LblStInJ1"
        Me.LblStInJ1.Size = New System.Drawing.Size(54, 21)
        Me.LblStInJ1.TabIndex = 18
        Me.LblStInJ1.Text = "&&h0f"
        '
        'LblStInJ2
        '
        Me.LblStInJ2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblStInJ2.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblStInJ2.Location = New System.Drawing.Point(144, 1)
        Me.LblStInJ2.Name = "LblStInJ2"
        Me.LblStInJ2.Size = New System.Drawing.Size(54, 21)
        Me.LblStInJ2.TabIndex = 17
        Me.LblStInJ2.Text = "&&h0f"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label19.Location = New System.Drawing.Point(14, 84)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(23, 16)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "J1"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label20.Location = New System.Drawing.Point(118, 2)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(23, 16)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "J2"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 31)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(75, 16)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "入力設定"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 5)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(97, 16)
        Me.Label22.TabIndex = 13
        Me.Label22.Text = "USB-IO 2.0"
        '
        'BtnStInJ23
        '
        Me.BtnStInJ23.BackColor = System.Drawing.Color.Lime
        Me.BtnStInJ23.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnStInJ23.Location = New System.Drawing.Point(114, 24)
        Me.BtnStInJ23.Name = "BtnStInJ23"
        Me.BtnStInJ23.Size = New System.Drawing.Size(22, 23)
        Me.BtnStInJ23.TabIndex = 12
        Me.BtnStInJ23.Text = "3"
        Me.BtnStInJ23.UseVisualStyleBackColor = False
        '
        'BtnStInJ22
        '
        Me.BtnStInJ22.BackColor = System.Drawing.Color.Lime
        Me.BtnStInJ22.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnStInJ22.Location = New System.Drawing.Point(142, 24)
        Me.BtnStInJ22.Name = "BtnStInJ22"
        Me.BtnStInJ22.Size = New System.Drawing.Size(22, 23)
        Me.BtnStInJ22.TabIndex = 11
        Me.BtnStInJ22.Text = "2"
        Me.BtnStInJ22.UseVisualStyleBackColor = False
        '
        'BtnStInJ21
        '
        Me.BtnStInJ21.BackColor = System.Drawing.Color.Lime
        Me.BtnStInJ21.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnStInJ21.Location = New System.Drawing.Point(170, 24)
        Me.BtnStInJ21.Name = "BtnStInJ21"
        Me.BtnStInJ21.Size = New System.Drawing.Size(22, 23)
        Me.BtnStInJ21.TabIndex = 10
        Me.BtnStInJ21.Text = "1"
        Me.BtnStInJ21.UseVisualStyleBackColor = False
        '
        'BtnStInJ20
        '
        Me.BtnStInJ20.BackColor = System.Drawing.Color.Lime
        Me.BtnStInJ20.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnStInJ20.Location = New System.Drawing.Point(198, 24)
        Me.BtnStInJ20.Name = "BtnStInJ20"
        Me.BtnStInJ20.Size = New System.Drawing.Size(22, 23)
        Me.BtnStInJ20.TabIndex = 9
        Me.BtnStInJ20.Text = "0"
        Me.BtnStInJ20.UseVisualStyleBackColor = False
        '
        'BtnStInJ17
        '
        Me.BtnStInJ17.BackColor = System.Drawing.Color.Lime
        Me.BtnStInJ17.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnStInJ17.Location = New System.Drawing.Point(198, 56)
        Me.BtnStInJ17.Name = "BtnStInJ17"
        Me.BtnStInJ17.Size = New System.Drawing.Size(22, 23)
        Me.BtnStInJ17.TabIndex = 8
        Me.BtnStInJ17.Text = "7"
        Me.BtnStInJ17.UseVisualStyleBackColor = False
        '
        'BtnStInJ16
        '
        Me.BtnStInJ16.BackColor = System.Drawing.Color.Lime
        Me.BtnStInJ16.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnStInJ16.Location = New System.Drawing.Point(170, 56)
        Me.BtnStInJ16.Name = "BtnStInJ16"
        Me.BtnStInJ16.Size = New System.Drawing.Size(22, 23)
        Me.BtnStInJ16.TabIndex = 7
        Me.BtnStInJ16.Text = "6"
        Me.BtnStInJ16.UseVisualStyleBackColor = False
        '
        'BtnStInJ15
        '
        Me.BtnStInJ15.BackColor = System.Drawing.Color.Lime
        Me.BtnStInJ15.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnStInJ15.Location = New System.Drawing.Point(142, 56)
        Me.BtnStInJ15.Name = "BtnStInJ15"
        Me.BtnStInJ15.Size = New System.Drawing.Size(22, 23)
        Me.BtnStInJ15.TabIndex = 6
        Me.BtnStInJ15.Text = "5"
        Me.BtnStInJ15.UseVisualStyleBackColor = False
        '
        'BtnStInJ14
        '
        Me.BtnStInJ14.BackColor = System.Drawing.Color.Lime
        Me.BtnStInJ14.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnStInJ14.Location = New System.Drawing.Point(114, 56)
        Me.BtnStInJ14.Name = "BtnStInJ14"
        Me.BtnStInJ14.Size = New System.Drawing.Size(22, 23)
        Me.BtnStInJ14.TabIndex = 5
        Me.BtnStInJ14.Text = "4"
        Me.BtnStInJ14.UseVisualStyleBackColor = False
        '
        'BtnStInJ13
        '
        Me.BtnStInJ13.BackColor = System.Drawing.Color.Lime
        Me.BtnStInJ13.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnStInJ13.Location = New System.Drawing.Point(86, 56)
        Me.BtnStInJ13.Name = "BtnStInJ13"
        Me.BtnStInJ13.Size = New System.Drawing.Size(22, 23)
        Me.BtnStInJ13.TabIndex = 4
        Me.BtnStInJ13.Text = "3"
        Me.BtnStInJ13.UseVisualStyleBackColor = False
        '
        'BtnStInJ12
        '
        Me.BtnStInJ12.BackColor = System.Drawing.Color.Lime
        Me.BtnStInJ12.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnStInJ12.Location = New System.Drawing.Point(58, 56)
        Me.BtnStInJ12.Name = "BtnStInJ12"
        Me.BtnStInJ12.Size = New System.Drawing.Size(22, 23)
        Me.BtnStInJ12.TabIndex = 3
        Me.BtnStInJ12.Text = "2"
        Me.BtnStInJ12.UseVisualStyleBackColor = False
        '
        'BtnStInJ11
        '
        Me.BtnStInJ11.BackColor = System.Drawing.Color.Lime
        Me.BtnStInJ11.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnStInJ11.Location = New System.Drawing.Point(30, 56)
        Me.BtnStInJ11.Name = "BtnStInJ11"
        Me.BtnStInJ11.Size = New System.Drawing.Size(22, 23)
        Me.BtnStInJ11.TabIndex = 2
        Me.BtnStInJ11.Text = "1"
        Me.BtnStInJ11.UseVisualStyleBackColor = False
        '
        'BtnStInJ10
        '
        Me.BtnStInJ10.BackColor = System.Drawing.Color.Lime
        Me.BtnStInJ10.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnStInJ10.Location = New System.Drawing.Point(2, 56)
        Me.BtnStInJ10.Name = "BtnStInJ10"
        Me.BtnStInJ10.Size = New System.Drawing.Size(22, 23)
        Me.BtnStInJ10.TabIndex = 1
        Me.BtnStInJ10.Text = "0"
        Me.BtnStInJ10.UseVisualStyleBackColor = False
        '
        'BtnStop
        '
        Me.BtnStop.Location = New System.Drawing.Point(88, 176)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(59, 27)
        Me.BtnStop.TabIndex = 39
        Me.BtnStop.Text = "停止"
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'BtnKm2Net
        '
        Me.BtnKm2Net.FlatAppearance.BorderSize = 0
        Me.BtnKm2Net.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKm2Net.Font = New System.Drawing.Font("Century", 11.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKm2Net.ForeColor = System.Drawing.Color.Blue
        Me.BtnKm2Net.Location = New System.Drawing.Point(173, 1)
        Me.BtnKm2Net.Name = "BtnKm2Net"
        Me.BtnKm2Net.Size = New System.Drawing.Size(129, 26)
        Me.BtnKm2Net.TabIndex = 41
        Me.BtnKm2Net.Text = "Km2Net Inc."
        Me.BtnKm2Net.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 12)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "64Bit版"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 340)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnKm2Net)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.PnlStting)
        Me.Controls.Add(Me.pnlRunning)
        Me.Controls.Add(Me.btnSendRecv)
        Me.Controls.Add(Me.BtnConnect)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "USB-IO2.0(AKI) サンプル"
        Me.pnlRunning.ResumeLayout(False)
        Me.pnlRunning.PerformLayout()
        Me.PnlStting.ResumeLayout(False)
        Me.PnlStting.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSendRecv As System.Windows.Forms.Button
    Friend WithEvents BtnConnect As System.Windows.Forms.Button
    Friend WithEvents pnlRunning As System.Windows.Forms.Panel
    Friend WithEvents BtnIoJ23 As System.Windows.Forms.Button
    Friend WithEvents BtnIoJ22 As System.Windows.Forms.Button
    Friend WithEvents BtnIoJ21 As System.Windows.Forms.Button
    Friend WithEvents BtnIoJ20 As System.Windows.Forms.Button
    Friend WithEvents BtnIoJ16 As System.Windows.Forms.Button
    Friend WithEvents BtnIoJ15 As System.Windows.Forms.Button
    Friend WithEvents BtnIoJ14 As System.Windows.Forms.Button
    Friend WithEvents BtnIoJ13 As System.Windows.Forms.Button
    Friend WithEvents BtnIoJ12 As System.Windows.Forms.Button
    Friend WithEvents BtnIoJ11 As System.Windows.Forms.Button
    Friend WithEvents BtnIoJ10 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LblIoJ2 As System.Windows.Forms.Label
    Friend WithEvents LblIoJ1 As System.Windows.Forms.Label
    Friend WithEvents PnlStting As System.Windows.Forms.Panel
    Friend WithEvents LblStInJ1 As System.Windows.Forms.Label
    Friend WithEvents LblStInJ2 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents BtnStInJ23 As System.Windows.Forms.Button
    Friend WithEvents BtnStInJ22 As System.Windows.Forms.Button
    Friend WithEvents BtnStInJ21 As System.Windows.Forms.Button
    Friend WithEvents BtnStInJ20 As System.Windows.Forms.Button
    Friend WithEvents BtnStInJ17 As System.Windows.Forms.Button
    Friend WithEvents BtnStInJ16 As System.Windows.Forms.Button
    Friend WithEvents BtnStInJ15 As System.Windows.Forms.Button
    Friend WithEvents BtnStInJ14 As System.Windows.Forms.Button
    Friend WithEvents BtnStInJ13 As System.Windows.Forms.Button
    Friend WithEvents BtnStInJ12 As System.Windows.Forms.Button
    Friend WithEvents BtnStInJ11 As System.Windows.Forms.Button
    Friend WithEvents BtnStInJ10 As System.Windows.Forms.Button
    Friend WithEvents BtnSetting As System.Windows.Forms.Button
    Friend WithEvents BtnStop As System.Windows.Forms.Button
    Friend WithEvents BtnKm2Net As System.Windows.Forms.Button
    Friend WithEvents TmrSendRecv As System.Windows.Forms.Timer
    Friend WithEvents BtnIoJ17 As System.Windows.Forms.Button
    Friend WithEvents LblPullUp As System.Windows.Forms.Label
    Friend WithEvents ChkPullUpStop As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As Label
End Class
