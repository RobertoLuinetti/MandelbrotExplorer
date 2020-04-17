Module ColorConversion
    'http://www.vb-helper.com/howto_rgb_to_hls.html
    'This example uses code translated from the first edition of the book Three-Dimensional Computer Graphics by Alan Watt.

    ' Convert an HLS value into an RGB value.
    Public Sub HlsToRgb(ByVal H As Double, ByVal L As Double,
        ByVal S As Double, ByRef R As Double, ByRef G As _
        Double, ByRef B As Double)
        Dim p1 As Double
        Dim p2 As Double

        If L <= 0.5 Then
            p2 = L * (1 + S)
        Else
            p2 = L + S - L * S
        End If
        p1 = 2 * L - p2
        If S = 0 Then
            R = L
            G = L
            B = L
        Else
            R = QqhToRgb(p1, p2, H + 120)
            G = QqhToRgb(p1, p2, H)
            B = QqhToRgb(p1, p2, H - 120)
        End If
    End Sub

    Private Function QqhToRgb(ByVal q1 As Double, ByVal q2 As _
        Double, ByVal hue As Double) As Double
        If hue > 360 Then
            hue = hue - 360
        ElseIf hue < 0 Then
            hue = hue + 360
        End If
        If hue < 60 Then
            QqhToRgb = q1 + (q2 - q1) * hue / 60
        ElseIf hue < 180 Then
            QqhToRgb = q2
        ElseIf hue < 240 Then
            QqhToRgb = q1 + (q2 - q1) * (240 - hue) / 60
        Else
            QqhToRgb = q1
        End If
    End Function


    ' Convert an RGB value into an HLS value.
    Public Sub RgbToHls(ByVal R As Double, ByVal G As Double,
        ByVal B As Double, ByRef H As Double, ByRef L As _
        Double, ByRef S As Double)
        Dim max As Double
        Dim min As Double
        Dim diff As Double
        Dim r_dist As Double
        Dim g_dist As Double
        Dim b_dist As Double

        ' Get the maximum and minimum RGB components.
        max = R
        If max < G Then max = G
        If max < B Then max = B

        min = R
        If min > G Then min = G
        If min > B Then min = B

        diff = max - min
        L = (max + min) / 2
        If Math.Abs(diff) < 0.00001 Then
            S = 0
            H = 0   ' H is really undefined.
        Else
            If L <= 0.5 Then
                S = diff / (max + min)
            Else
                S = diff / (2 - max - min)
            End If

            r_dist = (max - R) / diff
            g_dist = (max - G) / diff
            b_dist = (max - B) / diff

            If R = max Then
                H = b_dist - g_dist
            ElseIf G = max Then
                H = 2 + r_dist - b_dist
            Else
                H = 4 + g_dist - r_dist
            End If

            H = H * 60
            If H < 0 Then H = H + 360
        End If
    End Sub
End Module
