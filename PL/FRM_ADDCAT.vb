Imports LibM.LibM.BL

Public Class FRM_ADDCAT
    Public ID As Integer

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        ' التحقق من أن اسم التصنيف غير فارغ
        If txt_catname.Text = "" Then
            Dim FError As New FRM_ERRORINSERT()
            FError.Show()
        Else
            Dim BLCAT As New CLS_CAT()

            If ID = 0 Then
                ' إضافة سجل جديد
                BLCAT.Insert(txt_catname.Text)

                ' عرض رسالة نجاح
                Dim Fadd As New FRM_DADD()
                Fadd.Show()
                Me.Close()
            Else
                ' تحديث السجل
                BLCAT.Update(txt_catname.Text, ID) ' تمرير المعرف مع الاسم

                ' عرض رسالة نجاح
                Dim fEDIT As New FRM_DEDIT()
                fEDIT.Show()
                Me.Close()
            End If
        End If
    End Sub
End Class