Public Class Master

    Dim xpix As Single = 960
    Dim ypix As Single = 540
    Dim centrox As Double = -0.6
    Dim centroy As Double = 0
    Dim delta As Double = 1.5
    Dim limite As Double = delta / 2 ^ 20

    Dim Hmin As Integer = 0
    Dim Hmax As Integer = 360
    Dim zoom As Integer = 1
    Dim OutFile As String = ""

    Public Sub RenderGraph()

        Me.Cursor = Cursors.WaitCursor
        Dim StartTime As Date = Now
        Dim rsta As Double = centrox - delta * 16 / 9
        Dim rsto As Double = centrox + delta * 16 / 9
        Dim ista As Double = centroy - delta
        Dim isto As Double = centroy + delta
        RealMin.Text = rsta
        RealMax.Text = rsto
        ImaginaryMin.Text = ista
        ImaginaryMax.Text = isto
        ZoomX.Text = centrox
        ZoomY.Text = centroy
        RealMin.Refresh()
        RealMax.Refresh()
        ImaginaryMin.Refresh()
        ImaginaryMax.Refresh()
        ZoomX.Refresh()
        ZoomY.Refresh()
        CheckBoxZoom.Visible = True
        Dim timeStamp As String = DateTime.Now.ToString("yyyyMMddhhmmss")
        Dim FileName As String = timeStamp & "fractal.csv"

        Logger.Flog(FileName, LogCMD.NewFile)
        Logger.Flog(FileName, LogCMD.Write, "X" & vbTab & "Y" & vbTab & "I" & vbTab & "C")

        SetDisplayPhysicalArea(picGraph, xpix, ypix, 0, 0, xpix, ypix) 'Select physical display area dedicated to plotter
        SetScale(rsta, rsto, ista, isto) 'Set scale in logical coordinate

        Dim bm As New Bitmap(Xwide, Ywide)
        Dim gr As Graphics = Graphics.FromImage(bm)
        gr.Clear(Drawing.Color.Black)

        'Frame(gr, PenGreen)
        'Axes(gr, PenGreen, 0, 0, 0.5, 0.5)
        'Grid(gr, PenGreen, 0, 0, 1, 1)
        picGraph.Image = bm

        Dim conta As Long = 0
        Dim xtick As Double = (rsto - rsta) / xpix
        Dim ytick As Double = (isto - ista) / ypix
        Dim ym As Double = ista - ytick
        Dim xm As Double = rsta - xtick
        Dim zr, zi, ci, cr, re, im, rez, imz, rec, imc, actual As Double
        Dim cl, iterate As Integer
        Dim R, G, B As Double
        For y = 1 To ypix

            ym = ym + ytick
            For x = 1 To xpix

                xm = xm + xtick
                zr = 0
                zi = 0
                cr = xm
                ci = ym
                For iterate = 1 To Iterazioni.Value

                    re = zr
                    im = zi
                    zr = (zr * zr) - (zi * zi)
                    zi = re * im + im * re

                    rez = zr
                    imz = zi
                    rec = cr
                    imc = ci
                    zr = rez + rec
                    zi = imz + imc

                    conta = conta + 1

                    If Math.Sqrt((zr) ^ 2 + (zi) ^ 2) > 2 Then Exit For
                Next iterate

                If CheckBoxLOGColor.Checked Then
                    cl = Math.Truncate(Math.Log(iterate) / Math.Log(Iterazioni.Value) * (Hmax - Hmin)) + Hmin + TrackBarTraslation.Value
                Else
                    cl = Math.Truncate(iterate / Iterazioni.Value * (Hmax - Hmin)) + Hmin + TrackBarTraslation.Value
                End If

                If cl > 360 Then cl = cl - 360
                HlsToRgb(cl, 0.5, 1, R, G, B)
                Plot(gr, Color.FromArgb(R * 255, G * 255, B * 255), xm, ym)
                Logger.Flog(FileName, LogCMD.Write, xm & vbTab & ym & vbTab & iterate & vbTab & cl)

            Next x
            xm = rsta - xtick
            actual = y / ypix
            ToolStripProgressBar1.Value = 100 * actual
        Next y

        Logger.Flog(FileName, LogCMD.Close)

        LinkLabelLogFile.Visible = True
        LinkLabelLogFile.Links.Add(0, 8, My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & FileName)

        ToolStripProgressBar1.Value = 0
        ToolStripStatusLabel1.Text = "iterations: " & String.Format("{0:0,0}", conta)
        ToolStripStatusLabel2.Text = "calculation time: " & DateDiff(DateInterval.Second, StartTime, Now) & """"
        ToolStripStatusLabel3.Text = "zoom: " & zoom

        picGraph.Image = bm

        Clipboard.SetDataObject(DirectCast(picGraph.Image.Clone, Bitmap), True)
        OutFile = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & Timestamp & ".bmp"
        bm.Save(OutFile, System.Drawing.Imaging.ImageFormat.Bmp)

        Me.Cursor = Cursors.Default
    End Sub


    Private Sub ButtonRun_Click(sender As Object, e As EventArgs) Handles ButtonRun.Click
        ToolStripStatusLabel1.Text = "iterations: "
        ToolStripStatusLabel2.Text = "calculation time: "
        ToolStripStatusLabel3.Text = "zoom: "
        If CheckBoxZoom.Checked Then
            centrox = CType(ZoomX.Text, Double)
            centroy = CType(ZoomY.Text, Double)
            zoomfilm()
        Else
            RenderGraph()
        End If

    End Sub


    Private Sub picGraph_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picGraph.MouseDown
        Dim Lx, Ly As Single
        GetLogicalCoords(e.X, e.Y, Lx, Ly)
        'MsgBox(e.X.ToString & vbCrLf & e.Y.ToString & vbCrLf & Lx & vbCrLf & Ly)
        centrox = Lx
        centroy = Ly
        ZoomX.Text = centrox
        ZoomY.Text = centroy
        delta = delta / 2
        zoom = zoom + 1
        RenderGraph()
    End Sub

    Public Sub zoomfilm()
        delta = 1.5
        Do Until delta < limite
            delta = 0.95 * delta
            RenderGraph()
        Loop
    End Sub

    Private Sub TrackBarHmin_Scroll(sender As Object, e As EventArgs) Handles TrackBarHmin.Scroll
        Hmin = TrackBarHmin.Value
        If Hmin > TrackBarHmax.Value Then
            If Hmin < 360 Then
                TrackBarHmax.Value = Hmin + 1
            Else
                TrackBarHmin.Value = 359
                TrackBarHmax.Value = TrackBarHmin.Value + 1
            End If
        End If
        LabelHUEmin.Text = TrackBarHmin.Value
    End Sub

    Private Sub TrackBarHmax_Scroll(sender As Object, e As EventArgs) Handles TrackBarHmax.Scroll
        Hmax = TrackBarHmax.Value
        If Hmax < TrackBarHmin.Value Then
            If Hmax = 0 Then
                TrackBarHmin.Value = 0
                TrackBarHmax.Value = 1
            Else
                TrackBarHmin.Value = TrackBarHmax.Value - 1
            End If
        End If
        LabelHUEmax.Text = TrackBarHmax.Value
    End Sub

    Private Sub Master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        LinkLabelLogFile.Visible = False
        CheckBoxZoom.Visible = False
    End Sub

    Private Sub TrackBarTraslation_Scroll(sender As Object, e As EventArgs) Handles TrackBarTraslation.Scroll
        LabelHtransl.Text = TrackBarTraslation.Value
    End Sub


    Private Sub LinkLabelLogFile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelLogFile.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

End Class


