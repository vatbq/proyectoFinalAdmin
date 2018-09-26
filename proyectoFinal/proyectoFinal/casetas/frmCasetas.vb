﻿Public Class frmCasetas

    Private Sub lvwCasetas_DoubleClick(sender As Object, e As EventArgs) Handles lvwCasetas.DoubleClick
        openForm(frmCaseta)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        openForm(frmNuevaCaseta)
    End Sub

    Private Sub frmCasetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oCaseta As New Caseta()
        Dim elements As New List(Of String) From {"id", "nombre_completo", "nombre_raspberry", "estado", "automatico"}

        oCaseta.listarElementos(oCaseta.allElements(), elements, lvwCasetas)

        oCaseta.allElements().Close()
    End Sub
End Class