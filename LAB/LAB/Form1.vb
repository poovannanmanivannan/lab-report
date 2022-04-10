Public Class Form1
    Private Sub clr()
        DateTimePicker1.Value = Now
        ptname.Clear()
        grp.ResetText()
        rh.ResetText()
        hb.Clear()
        spot.Clear()
        hbsag.ResetText()
        hcv.ResetText()
        hivp.ResetText()
        hivs.ResetText()
        vdrl.ResetText()
        btm.Clear()
        bts.Clear()
        ctm.Clear()
        cts.Clear()
        sgr.ResetText()
        alb.ResetText()
        pf.Clear()
        pt.Clear()
        ef.Clear()
        et.Clear()
        rbcf.Clear()
        rbct.Clear()

        grp.Hide()
        rh.Hide()
        hb.Hide()
        Label5.Hide()
        spot.Hide()
        Label6.Hide()
        hbsag.Hide()
        hcv.Hide()
        hivp.Hide()
        hivs.Hide()
        vdrl.Hide()
        btm.Hide()
        bts.Hide()
        Label7.Hide()
        Label8.Hide()
        ctm.Hide()
        cts.Hide()
        Label9.Hide()
        Label10.Hide()

        sgr.Hide()
        alb.Hide()
        pf.Hide()
        pt.Hide()
        ef.Hide()
        et.Hide()
        rbcf.Hide()
        rbct.Hide()
        Label11.Hide()
        Label12.Hide()
        Label13.Hide()
        Label14.Hide()
        Label15.Hide()
        Label16.Hide()

        Panel1.BringToFront()
        Panel1.Show()
        For i As Integer = 0 To CheckedListBox1.Items.Count - 1

            CheckedListBox1.SetItemChecked(i, 0)
        Next
        For i As Integer = 0 To CheckedListBox2.Items.Count - 1

            CheckedListBox2.SetItemChecked(i, 0)
        Next
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clr()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        If CheckedListBox1.SelectedIndex = 0 Then
            If CheckedListBox1.GetItemChecked(0) Then
                grp.Show()

            Else
                grp.Hide()
            End If
        End If
        If CheckedListBox1.SelectedIndex = 1 Then
            If CheckedListBox1.GetItemChecked(1) Then
                rh.Show()
            Else
                rh.Hide()
            End If
        End If
        If CheckedListBox1.SelectedIndex = 2 Then
            If CheckedListBox1.GetItemChecked(2) Then
                hb.Show()
                Label5.Show()


            Else
                hb.Hide()
                Label5.Hide()

            End If
        End If
        If CheckedListBox1.SelectedIndex = 3 Then
            If CheckedListBox1.GetItemChecked(3) Then
                spot.Show()
                Label6.Show()


            Else
                spot.Hide()
                Label6.Hide()

            End If
        End If
        If CheckedListBox1.SelectedIndex = 4 Then
            If CheckedListBox1.GetItemChecked(4) Then
                hbsag.Show()

            Else
                hbsag.Hide()

            End If
        End If
        If CheckedListBox1.SelectedIndex = 5 Then
            If CheckedListBox1.GetItemChecked(5) Then
                hcv.Show()

            Else
                hcv.Hide()

            End If
        End If
        If CheckedListBox1.SelectedIndex = 6 Then
            If CheckedListBox1.GetItemChecked(6) Then
                hivp.Show()

            Else
                hivp.Hide()

            End If
        End If
        If CheckedListBox1.SelectedIndex = 7 Then
            If CheckedListBox1.GetItemChecked(7) Then
                hivs.Show()

            Else
                hivs.Hide()

            End If
        End If
        If CheckedListBox1.SelectedIndex = 8 Then
            If CheckedListBox1.GetItemChecked(8) Then
                vdrl.Show()

            Else
                vdrl.Hide()

            End If
        End If
        If CheckedListBox1.SelectedIndex = 9 Then
            If CheckedListBox1.GetItemChecked(9) Then
                btm.Show()
                bts.Show()
                Label7.Show()
                Label8.Show()


            Else
                btm.Hide()
                bts.Hide()
                Label7.Hide()
                Label8.Hide()


            End If
        End If
        If CheckedListBox1.SelectedIndex = 10 Then
            If CheckedListBox1.GetItemChecked(10) Then
                ctm.Show()
                cts.Show()
                Label9.Show()
                Label10.Show()

            Else
                ctm.Hide()
                cts.Hide()
                Label9.Hide()
                Label10.Hide()

            End If

        End If
    End Sub

    Private Sub CheckedListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox2.SelectedIndexChanged
        If CheckedListBox2.SelectedIndex = 0 Then
            If CheckedListBox2.GetItemChecked(0) Then
                sgr.Show()

            Else
                sgr.Hide()
            End If
        End If
        If CheckedListBox2.SelectedIndex = 1 Then
            If CheckedListBox2.GetItemChecked(1) Then
                alb.Show()

            Else
                alb.Hide()

            End If
        End If
        If CheckedListBox2.SelectedIndex = 2 Then
            If CheckedListBox2.GetItemChecked(2) Then
                pf.Show()
                pt.Show()
                ef.Show()
                et.Show()
                rbcf.Show()
                rbct.Show()
                Label11.Show()
                Label12.Show()
                Label13.Show()
                Label14.Show()
                Label15.Show()
                Label16.Show()

            Else

                pf.Hide()
                pt.Hide()
                ef.Hide()
                et.Hide()
                rbcf.Hide()
                rbct.Hide()
                Label11.Hide()
                Label12.Hide()
                Label13.Hide()
                Label14.Hide()
                Label15.Hide()
                Label16.Hide()


            End If
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i As Integer = 0 To CheckedListBox1.Items.Count - 1

            CheckedListBox1.SetItemChecked(i, 1)
        Next
        For i As Integer = 0 To CheckedListBox2.Items.Count - 1
            CheckedListBox2.SetItemChecked(i, 1)
        Next

        grp.Show()
        rh.Show()
        hb.Show()
        Label5.Show()
        spot.Show()
        Label6.Show()
        hbsag.Show()
        hcv.Show()
        hivp.Show()
        hivs.Show()
        vdrl.Show()
        btm.Show()
        bts.Show()
        Label7.Show()
        Label8.Show()
        ctm.Show()
        cts.Show()
        Label9.Show()
        Label10.Show()

        sgr.Show()
        alb.Show()
        pf.Show()
        pt.Show()
        ef.Show()
        et.Show()
        rbcf.Show()
        rbct.Show()
        Label11.Show()
        Label12.Show()
        Label13.Show()
        Label14.Show()
        Label15.Show()
        Label16.Show()

        Panel1.SendToBack()
        Panel1.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CheckedListBox1.SetItemChecked(0, 1)
        CheckedListBox1.SetItemChecked(1, 1)
        CheckedListBox1.SetItemChecked(2, 1)
        CheckedListBox2.SetItemChecked(0, 1)
        CheckedListBox2.SetItemChecked(1, 1)
        CheckedListBox2.SetItemChecked(2, 1)

        grp.Show()
        rh.Show()
        hb.Show()
        Label5.Show()

        sgr.Show()
        alb.Show()
        pf.Show()
        pt.Show()
        ef.Show()
        et.Show()
        rbcf.Show()
        rbct.Show()
        Label11.Show()
        Label12.Show()
        Label13.Show()
        Label14.Show()
        Label15.Show()
        Label16.Show()

        Panel1.SendToBack()
        Panel1.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog1.Document = PrintDocument1

        'PrintPreviewDialog1.ShowDialog()

        PrintDocument1.Print()


        Me.Close()


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim f As New Font(grp.Font.Name, grp.Font.Size, FontStyle.Regular)
        Dim nm As New Font(ptname.Font.Name, ptname.Font.Size, FontStyle.Bold)
        Dim heading As New Font(ptname.Font.Name, ptname.Font.Size, FontStyle.Underline)
        Dim br As New SolidBrush(Color.Black)
        Dim x As Integer = 75
        Dim y As Integer = 150
        Dim s As String = "DATE :   " & UCase(DateTimePicker1.Text)
        e.Graphics.DrawString(s, f, br, x + 300, y)
        Dim sSize As SizeF = e.Graphics.MeasureString(s, nm)
        'move the brush
        y += CInt(sSize.Height)
        s = "PT. NAME :   " & UCase(ptname.Text)
        e.Graphics.DrawString(s, nm, br, x, y)

        If CheckedListBox1.GetItemChecked(0) = 0 Then
        ElseIf CheckedListBox1.GetItemChecked(1) = 0 Then
        ElseIf CheckedListBox1.GetItemChecked(2) = 0 Then
        ElseIf CheckedListBox1.GetItemChecked(3) = 0 Then
        ElseIf CheckedListBox1.GetItemChecked(4) = 0 Then
        ElseIf CheckedListBox1.GetItemChecked(5) = 0 Then
        ElseIf CheckedListBox1.GetItemChecked(6) = 0 Then
        ElseIf CheckedListBox1.GetItemChecked(7) = 0 Then
        ElseIf CheckedListBox1.GetItemChecked(8) = 0 Then
        ElseIf CheckedListBox1.GetItemChecked(9) = 0 Then
        ElseIf CheckedListBox1.GetItemChecked(10) = 0 Then
        Else
            sSize = e.Graphics.MeasureString(s, nm)
            'move the brush
            y += CInt(sSize.Height)
            s = "BLOOD:-"
            e.Graphics.DrawString(s, heading, br, x, y)
            y += CInt(sSize.Height)
        End If
        If CheckedListBox1.GetItemChecked(0) Then
            'get the height
            sSize = e.Graphics.MeasureString(s, nm)

            'move the brush
            y += CInt(sSize.Height)
            s = "GROUPING   :   " & UCase(grp.Text)
            e.Graphics.DrawString(s, f, br, x, y)
        End If


        If CheckedListBox1.GetItemChecked(1) Then
            'get the height
            sSize = e.Graphics.MeasureString(s, nm)

            'move the brush
            y += CInt(sSize.Height)
            s = "RH TYPE    :   " & UCase(rh.Text)
            e.Graphics.DrawString(s, f, br, x, y)
        End If

        If CheckedListBox1.GetItemChecked(2) Then
            'get the height
            sSize = e.Graphics.MeasureString(s, nm)

            'move the brush
            y += CInt(sSize.Height)
            s = "HAEMOGLOBIN    :   " & UCase(hb.Text) & "    gms%"
            e.Graphics.DrawString(s, f, br, x, y)

        End If

        If CheckedListBox1.GetItemChecked(3) Then
            'get the height
            sSize = e.Graphics.MeasureString(s, nm)

            'move the brush
            y += CInt(sSize.Height)
            s = "SUGAR(SPOT TEST)   :   " & UCase(spot.Text) & "  mgs%"
            e.Graphics.DrawString(s, f, br, x, y)

        End If

        If CheckedListBox1.GetItemChecked(4) Then
            'get the height
            sSize = e.Graphics.MeasureString(s, nm)

            'move the brush
            y += CInt(sSize.Height)
            s = "HBsAg  :   " & UCase(hbsag.Text)
            e.Graphics.DrawString(s, f, br, x, y)
        End If

        If CheckedListBox1.GetItemChecked(5) Then
            'get the height
            sSize = e.Graphics.MeasureString(s, nm)

            'move the brush
            y += CInt(sSize.Height)
            s = "HCV    :   " & UCase(hcv.Text)
            e.Graphics.DrawString(s, f, br, x, y)
        End If
        If CheckedListBox1.GetItemChecked(6) Then
            'get the height
            sSize = e.Graphics.MeasureString(s, nm)

            'move the brush
            y += CInt(sSize.Height)
            s = "HIV I&II(PATIENT)  :   " & UCase(hivp.Text)
            e.Graphics.DrawString(s, f, br, x, y)
        End If

        If CheckedListBox1.GetItemChecked(7) Then
            'get the height
            sSize = e.Graphics.MeasureString(s, nm)

            'move the brush
            y += CInt(sSize.Height)
            s = "HIV I&II(SPOUSE)   :   " & UCase(hivs.Text)
            e.Graphics.DrawString(s, f, br, x, y)
        End If

        If CheckedListBox1.GetItemChecked(8) Then
            'get the height
            sSize = e.Graphics.MeasureString(s, nm)

            'move the brush
            y += CInt(sSize.Height)
            s = "VDRL   :   " & UCase(vdrl.Text)
            e.Graphics.DrawString(s, f, br, x, y)
        End If

        If CheckedListBox1.GetItemChecked(9) Then
            'get the height
            sSize = e.Graphics.MeasureString(s, nm)

            'move the brush
            y += CInt(sSize.Height)
            s = "BLEEDING TIME  :   " & UCase(btm.Text) & "M    " & UCase(bts.Text) & "S"
            e.Graphics.DrawString(s, f, br, x, y)
        End If

        If CheckedListBox1.GetItemChecked(10) Then
            'get the height
            sSize = e.Graphics.MeasureString(s, nm)

            'move the brush
            y += CInt(sSize.Height)
            s = "CLOTTING TIME  :   " & UCase(ctm.Text) & "M    " & UCase(cts.Text) & "S"
            e.Graphics.DrawString(s, f, br, x, y)
        End If

        If CheckedListBox2.GetItemChecked(0) = 0 Then
        ElseIf CheckedListBox2.GetItemChecked(1) = 0 Then
        ElseIf CheckedListBox2.GetItemChecked(2) = 0 Then
        Else
            sSize = e.Graphics.MeasureString(s, nm)

            'move the brush
            y += CInt(sSize.Height)
            s = "URINE:-"
            e.Graphics.DrawString(s, heading, br, x, y)
            y += CInt(sSize.Height)
        End If
        If CheckedListBox2.GetItemChecked(0) Then
            'get the height
            sSize = e.Graphics.MeasureString(s, nm)

            'move the brush
            y += CInt(sSize.Height)
            s = "SUGAR  :   " & UCase(sgr.Text)
            e.Graphics.DrawString(s, f, br, x, y)
        End If

        If CheckedListBox2.GetItemChecked(1) Then
            'get the height
            sSize = e.Graphics.MeasureString(s, nm)

            'move the brush
            y += CInt(sSize.Height)
            s = "ALBUMIN    :   " & UCase(alb.Text)
            e.Graphics.DrawString(s, f, br, x, y)
        End If

        If CheckedListBox2.GetItemChecked(2) Then
            'get the height
            sSize = e.Graphics.MeasureString(s, nm)

            'move the brush
            y += CInt(sSize.Height)
            s = "DEPOSIT    :   " & UCase(pf.Text) & "  -   " & UCase(pt.Text) & "    PUSCELLS"
            e.Graphics.DrawString(s, f, br, x, y)


            'move the brush
            y += CInt(sSize.Height)
            x += 85
            s = UCase(ef.Text) & "  -   " & UCase(et.Text) & "    EPI.CELLS"
            e.Graphics.DrawString(s, f, br, x, y)

            'move the brush
            y += CInt(sSize.Height)
            s = UCase(rbcf.Text) & "  -   " & UCase(rbct.Text) & "    RBC"
            e.Graphics.DrawString(s, f, br, x, y)
        End If
    End Sub
End Class
