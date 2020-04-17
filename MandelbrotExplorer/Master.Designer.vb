<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Master
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.picGraph = New System.Windows.Forms.PictureBox()
        Me.ButtonRun = New System.Windows.Forms.Button()
        Me.Iterazioni = New System.Windows.Forms.NumericUpDown()
        Me.LBLIterazioniSet = New System.Windows.Forms.Label()
        Me.TrackBarHmin = New System.Windows.Forms.TrackBar()
        Me.TrackBarHmax = New System.Windows.Forms.TrackBar()
        Me.TrackBarTraslation = New System.Windows.Forms.TrackBar()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelHUEmin = New System.Windows.Forms.Label()
        Me.LabelHUEmax = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelHtransl = New System.Windows.Forms.Label()
        Me.RealMin = New System.Windows.Forms.TextBox()
        Me.RealMax = New System.Windows.Forms.TextBox()
        Me.ImaginaryMax = New System.Windows.Forms.TextBox()
        Me.ImaginaryMin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CheckBoxLOGColor = New System.Windows.Forms.CheckBox()
        Me.LinkLabelLogFile = New System.Windows.Forms.LinkLabel()
        Me.CheckBoxZoom = New System.Windows.Forms.CheckBox()
        Me.ZoomX = New System.Windows.Forms.TextBox()
        Me.ZoomY = New System.Windows.Forms.TextBox()
        CType(Me.picGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Iterazioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarHmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarHmax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarTraslation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picGraph
        '
        Me.picGraph.BackColor = System.Drawing.Color.Black
        Me.picGraph.Location = New System.Drawing.Point(12, 12)
        Me.picGraph.Name = "picGraph"
        Me.picGraph.Size = New System.Drawing.Size(960, 540)
        Me.picGraph.TabIndex = 1
        Me.picGraph.TabStop = False
        '
        'ButtonRun
        '
        Me.ButtonRun.Location = New System.Drawing.Point(987, 529)
        Me.ButtonRun.Name = "ButtonRun"
        Me.ButtonRun.Size = New System.Drawing.Size(115, 23)
        Me.ButtonRun.TabIndex = 0
        Me.ButtonRun.Text = "RUN"
        Me.ButtonRun.UseVisualStyleBackColor = True
        '
        'Iterazioni
        '
        Me.Iterazioni.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Iterazioni.Location = New System.Drawing.Point(987, 331)
        Me.Iterazioni.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.Iterazioni.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Iterazioni.Name = "Iterazioni"
        Me.Iterazioni.Size = New System.Drawing.Size(67, 20)
        Me.Iterazioni.TabIndex = 3
        Me.Iterazioni.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'LBLIterazioniSet
        '
        Me.LBLIterazioniSet.AutoSize = True
        Me.LBLIterazioniSet.Location = New System.Drawing.Point(1055, 333)
        Me.LBLIterazioniSet.Name = "LBLIterazioniSet"
        Me.LBLIterazioniSet.Size = New System.Drawing.Size(56, 13)
        Me.LBLIterazioniSet.TabIndex = 4
        Me.LBLIterazioniSet.Text = "Iteractions"
        '
        'TrackBarHmin
        '
        Me.TrackBarHmin.Location = New System.Drawing.Point(989, 26)
        Me.TrackBarHmin.Maximum = 360
        Me.TrackBarHmin.Name = "TrackBarHmin"
        Me.TrackBarHmin.Size = New System.Drawing.Size(104, 45)
        Me.TrackBarHmin.SmallChange = 5
        Me.TrackBarHmin.TabIndex = 5
        Me.TrackBarHmin.TickFrequency = 45
        '
        'TrackBarHmax
        '
        Me.TrackBarHmax.Location = New System.Drawing.Point(989, 96)
        Me.TrackBarHmax.Maximum = 360
        Me.TrackBarHmax.Name = "TrackBarHmax"
        Me.TrackBarHmax.Size = New System.Drawing.Size(104, 45)
        Me.TrackBarHmax.TabIndex = 6
        Me.TrackBarHmax.TickFrequency = 45
        Me.TrackBarHmax.Value = 360
        '
        'TrackBarTraslation
        '
        Me.TrackBarTraslation.Location = New System.Drawing.Point(989, 167)
        Me.TrackBarTraslation.Maximum = 360
        Me.TrackBarTraslation.Name = "TrackBarTraslation"
        Me.TrackBarTraslation.Size = New System.Drawing.Size(104, 45)
        Me.TrackBarTraslation.SmallChange = 5
        Me.TrackBarTraslation.TabIndex = 7
        Me.TrackBarTraslation.TickFrequency = 45
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 565)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1115, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(68, 17)
        Me.ToolStripStatusLabel1.Text = "iteractions: "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(95, 17)
        Me.ToolStripStatusLabel2.Text = "calculation time:"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(40, 17)
        Me.ToolStripStatusLabel3.Text = "zoom:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1019, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "HUE min"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1016, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "HUE max"
        '
        'LabelHUEmin
        '
        Me.LabelHUEmin.AutoSize = True
        Me.LabelHUEmin.Location = New System.Drawing.Point(1036, 58)
        Me.LabelHUEmin.Name = "LabelHUEmin"
        Me.LabelHUEmin.Size = New System.Drawing.Size(13, 13)
        Me.LabelHUEmin.TabIndex = 12
        Me.LabelHUEmin.Text = "0"
        Me.LabelHUEmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelHUEmax
        '
        Me.LabelHUEmax.AutoSize = True
        Me.LabelHUEmax.Location = New System.Drawing.Point(1029, 128)
        Me.LabelHUEmax.Name = "LabelHUEmax"
        Me.LabelHUEmax.Size = New System.Drawing.Size(25, 13)
        Me.LabelHUEmax.TabIndex = 13
        Me.LabelHUEmax.Text = "360"
        Me.LabelHUEmax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1000, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "HUE translation"
        '
        'LabelHtransl
        '
        Me.LabelHtransl.AutoSize = True
        Me.LabelHtransl.Location = New System.Drawing.Point(1029, 199)
        Me.LabelHtransl.Name = "LabelHtransl"
        Me.LabelHtransl.Size = New System.Drawing.Size(13, 13)
        Me.LabelHtransl.TabIndex = 15
        Me.LabelHtransl.Text = "0"
        Me.LabelHtransl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RealMin
        '
        Me.RealMin.Location = New System.Drawing.Point(987, 370)
        Me.RealMin.Name = "RealMin"
        Me.RealMin.Size = New System.Drawing.Size(115, 20)
        Me.RealMin.TabIndex = 16
        '
        'RealMax
        '
        Me.RealMax.Location = New System.Drawing.Point(987, 409)
        Me.RealMax.Name = "RealMax"
        Me.RealMax.Size = New System.Drawing.Size(115, 20)
        Me.RealMax.TabIndex = 17
        '
        'ImaginaryMax
        '
        Me.ImaginaryMax.Location = New System.Drawing.Point(987, 487)
        Me.ImaginaryMax.Name = "ImaginaryMax"
        Me.ImaginaryMax.Size = New System.Drawing.Size(115, 20)
        Me.ImaginaryMax.TabIndex = 18
        '
        'ImaginaryMin
        '
        Me.ImaginaryMin.Location = New System.Drawing.Point(987, 448)
        Me.ImaginaryMin.Name = "ImaginaryMin"
        Me.ImaginaryMin.Size = New System.Drawing.Size(115, 20)
        Me.ImaginaryMin.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(986, 471)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Imaginary max"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(986, 432)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Imaginary min"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(986, 393)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Real max"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(986, 354)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Real min"
        '
        'CheckBoxLOGColor
        '
        Me.CheckBoxLOGColor.AutoSize = True
        Me.CheckBoxLOGColor.Location = New System.Drawing.Point(987, 308)
        Me.CheckBoxLOGColor.Name = "CheckBoxLOGColor"
        Me.CheckBoxLOGColor.Size = New System.Drawing.Size(70, 17)
        Me.CheckBoxLOGColor.TabIndex = 24
        Me.CheckBoxLOGColor.Text = "Log color"
        Me.CheckBoxLOGColor.UseVisualStyleBackColor = True
        '
        'LinkLabelLogFile
        '
        Me.LinkLabelLogFile.AutoSize = True
        Me.LinkLabelLogFile.Location = New System.Drawing.Point(1015, 511)
        Me.LinkLabelLogFile.Name = "LinkLabelLogFile"
        Me.LinkLabelLogFile.Size = New System.Drawing.Size(44, 13)
        Me.LinkLabelLogFile.TabIndex = 25
        Me.LinkLabelLogFile.TabStop = True
        Me.LinkLabelLogFile.Text = "Log File"
        '
        'CheckBoxZoom
        '
        Me.CheckBoxZoom.AutoSize = True
        Me.CheckBoxZoom.Location = New System.Drawing.Point(987, 227)
        Me.CheckBoxZoom.Name = "CheckBoxZoom"
        Me.CheckBoxZoom.Size = New System.Drawing.Size(68, 17)
        Me.CheckBoxZoom.TabIndex = 26
        Me.CheckBoxZoom.Text = "Zoom to:"
        Me.CheckBoxZoom.UseVisualStyleBackColor = True
        '
        'ZoomX
        '
        Me.ZoomX.Location = New System.Drawing.Point(987, 250)
        Me.ZoomX.Name = "ZoomX"
        Me.ZoomX.Size = New System.Drawing.Size(115, 20)
        Me.ZoomX.TabIndex = 27
        '
        'ZoomY
        '
        Me.ZoomY.Location = New System.Drawing.Point(987, 276)
        Me.ZoomY.Name = "ZoomY"
        Me.ZoomY.Size = New System.Drawing.Size(115, 20)
        Me.ZoomY.TabIndex = 28
        '
        'Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 587)
        Me.Controls.Add(Me.ZoomY)
        Me.Controls.Add(Me.ZoomX)
        Me.Controls.Add(Me.CheckBoxZoom)
        Me.Controls.Add(Me.LinkLabelLogFile)
        Me.Controls.Add(Me.CheckBoxLOGColor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ImaginaryMin)
        Me.Controls.Add(Me.ImaginaryMax)
        Me.Controls.Add(Me.RealMax)
        Me.Controls.Add(Me.RealMin)
        Me.Controls.Add(Me.LabelHtransl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelHUEmax)
        Me.Controls.Add(Me.LabelHUEmin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TrackBarTraslation)
        Me.Controls.Add(Me.TrackBarHmax)
        Me.Controls.Add(Me.TrackBarHmin)
        Me.Controls.Add(Me.LBLIterazioniSet)
        Me.Controls.Add(Me.Iterazioni)
        Me.Controls.Add(Me.picGraph)
        Me.Controls.Add(Me.ButtonRun)
        Me.Name = "Master"
        Me.Text = "Mandelbrot explorer"
        CType(Me.picGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Iterazioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarHmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarHmax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarTraslation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picGraph As PictureBox
    Friend WithEvents ButtonRun As Button
    Friend WithEvents Iterazioni As NumericUpDown
    Friend WithEvents LBLIterazioniSet As Label
    Friend WithEvents TrackBarHmin As TrackBar
    Friend WithEvents TrackBarHmax As TrackBar
    Friend WithEvents TrackBarTraslation As TrackBar
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelHUEmin As Label
    Friend WithEvents LabelHUEmax As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelHtransl As Label
    Friend WithEvents RealMin As TextBox
    Friend WithEvents RealMax As TextBox
    Friend WithEvents ImaginaryMax As TextBox
    Friend WithEvents ImaginaryMin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CheckBoxLOGColor As CheckBox
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents LinkLabelLogFile As LinkLabel
    Friend WithEvents CheckBoxZoom As CheckBox
    Friend WithEvents ZoomX As TextBox
    Friend WithEvents ZoomY As TextBox
End Class
