Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports LibM.LibM
Public Class FRM_ADDCAT
    Public ID As Integer
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If txt_catname.Text = "" Then

            Dim FError As New FRM_ERRORINSERT()
            FError.Show()

        Else
            If ID = 0 Then
                ' إضافة سجل جديد
                Dim BLCAT As New BL.CLS_CAT()
                BLCAT.Insert(txt_catname.Text)

                Dim Fadd As New FRM_DADD()
                Fadd.Show()

                Me.Close()
            Else
                ' تحديث السجل
                ' إنشاء كائن من الفئة BL.CLS_CAT
                Dim BLCAT As New BL.CLS_CAT()

                ' استدعاء دالة التحديث (update) وتمرير اسم التصنيف والمعرف
                BLCAT.update(txt_catname.Text And ID)

                ' فتح نافذة التعديل (FRM_DEDIT)
                Dim fEDIT As New FRM_DEDIT()
                fEDIT.Show()

                ' إغلاق النافذة الحالية
                Me.Close()
            End If

        End If
    End Sub
End Class