Imports LibM.LibM

Public Class FRM_START
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim userfrm As New BL.CLS_USERS()
        Dim dt As New DataTable()
        dt = userfrm.STARTLOADDTA()

        If dt.Rows.Count > 0 Then
            Dim frmmain As New FRM_MIAN()
            Dim lbname As Object = dt.Rows(0)("CNAME")
            Dim lbprem As Object = dt.Rows(0)("CPREM")
            'frmmain.lb_name.Text = lbname.ToString()
            'frmmain.lb_prem.Text = lbprem.ToString()
            frmmain.Show()
            Me.Hide()
            Timer1.Enabled = False
        Else
            Dim frmlogin As New FRM_LOGIN()
            frmlogin.Show()
            Me.Hide()
            Timer1.Enabled = False
        End If
    End Sub
End Class