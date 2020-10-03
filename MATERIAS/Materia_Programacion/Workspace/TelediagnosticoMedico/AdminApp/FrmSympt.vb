﻿Imports System.Runtime.InteropServices
Imports Logic
Imports Data

Public Class FrmSympt
    Dim log As New Logica()

    Dim row As DataGridViewRow
    Dim SymptSelected As String
    Dim reg As String = Nothing
    Dim Pathologies As New List(Of String)

    Public Sub ReloadDgv(i As Integer)
        If i = 0 Then
            'Opción para el load
            Try
                DgvSympt.DataSource = log.ObtainSymptomsDataSet().Tables("Refresh")
                DgvSympt.Refresh()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            'Opcion para los demas
            Try
                DgvSympt.DataSource = log.ObtainSymptomsDataSet().Tables("Refresh")
                DgvSympt.Refresh()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(LR As Integer, TR As Integer, RR As Integer, BR As Integer, WE As Integer, HE As Integer) As IntPtr

    End Function
    Private Sub FrmSympt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width - 2, Height - 2, 15, 15))
        ReloadDgv(0)
    End Sub

    Private Sub MzButtonWindows1_Click(sender As Object, e As EventArgs) Handles MzButtonWindows1.Click
        End
    End Sub

    Private Sub TxtSympt_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtSympt.MouseClick
        TxtSympt.Text = Nothing
    End Sub

    Private Sub TxtSympt_TextChanged(sender As Object, e As EventArgs) Handles TxtSympt.TextChanged 'Buscar sintoma
        If Not TxtSympt.Text.Equals("") Or Not TxtSympt.Text = Nothing Or Not TxtSympt.Text = "Realizar busqueda por síntoma" Then
            Try
                DgvSympt.DataSource = log.SearchSymptoms(TxtSympt.Text).Tables("Search")
                DgvSympt.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            ReloadDgv(2)
        End If
    End Sub

    Private Sub BtnHome_Click_1(sender As Object, e As EventArgs) Handles BtnHome.Click
        Me.Dispose()
        FrmHome.Show()
    End Sub

    Private Sub TxtSympt_Enter(sender As Object, e As EventArgs) Handles TxtSympt.Enter
        TxtSympt.Clear()
    End Sub

    Private Sub BtnAddSympt_Click(sender As Object, e As EventArgs) Handles BtnAddSympt.Click
        Dim frmAdd As New FrmAddModSympt()
        'Insercion de nuevo síntoma
        frmAdd.AddSympt()
        frmAdd.ShowDialog()
        ReloadDgv(3)
    End Sub

    Private Sub BtnDelSympt_Click(sender As Object, e As EventArgs) Handles BtnDelSympt.Click
        Dim alerta As New FrmAlertRemove()
        row = DgvSympt.CurrentRow
        SymptSelected = CStr(row.Cells("Síntoma").Value) 'Obtengo el síntoma seleccionado
        For Each Sympt As Symptom In log.ObtainSymptoms()
            If Sympt.Description.Equals(SymptSelected) Then
                FrmAlertRemove.idSympt = Sympt.Id
            End If
        Next
        alerta.Obtain(SymptSelected, 0)
        alerta.ShowDialog()
        ReloadDgv(3)
    End Sub

    Private Sub DgvSympt_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSympt.CellDoubleClick 'Una manera de acceder a las modificaciones, haciendo doble clic en la tabla.
        ModSympt()
    End Sub

    Public Sub ModSympt()
        Dim frmMod As New FrmAddModSympt()
        'Modificación de síntoma

        row = DgvSympt.CurrentRow
        SymptSelected = CStr(row.Cells("Síntoma").Value)
        Try
            reg = CStr(row.Cells("Región").Value)
            frmMod.ObtainSympt(SymptSelected, reg)
            frmMod.ShowDialog()
            ReloadDgv(4)
        Catch ex As Exception
            Console.WriteLine("Sintoma a modificar sin region")
            reg = "No tiene"
            frmMod.ObtainSympt(SymptSelected, reg)
            frmMod.ShowDialog()
            ReloadDgv(4)
        End Try
    End Sub

    Private Sub BtnMod_Click(sender As Object, e As EventArgs) Handles BtnMod.Click 'Otra manera de modificar un síntoma
        ModSympt()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        If MsgBox("Está seguro que desea cerrar sesión ?", MsgBoxStyle.YesNoCancel, "Cerrar Programa") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub BtnPath_Click(sender As Object, e As EventArgs) Handles BtnPath.Click
        Dim frm As New FrmPath()
        Me.Dispose()
        frm.Show()
    End Sub
End Class