Public Class Form
    Dim operacion_ As String
    Dim MiSueldo As New ClassUnitaria

    Public Property operacion() As String

        Get
            Return operacion_

        End Get

        Set(ByVal value As String)

            operacion_ = value
        End Set
    End Property
    Dim indice_ As Byte

    Public Property indice() As Byte
        Get
            Return indice_
        End Get
        Set(ByVal value As Byte)
            indice_ = value
        End Set
    End Property
    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        If id.Text = "" Then
            MsgBox("El ID NO PUEDE ESTAR VACIO")
            Exit Sub
        End If
        If Nombre.Text = "" Then
            MsgBox("El NOMBRE NO PUEDE ESTAR VACIO")

        End If
        If saldo.Text = "" Then
            MsgBox("El SALDO NO PUEDE ESTAR VACIO")

        End If
        If Dirección.Text = "" Then
            MsgBox("LA DIRECCIÓN NO PUEDE ESTAR VACIO")

        End If
        If CategIva.SelectedIndex = -1 Then
            MsgBox("SELECCIONE OPCIÓN")

        End If

        MiSueldo.Id = CInt(id.Text)
        MiSueldo.Nombre = (Nombre.Text)
        MiSueldo.Saldo = (saldo.Text)
        MiSueldo.Direccion = (Dirección.Text)
        MiSueldo.CategIva = CategIva.SelectedIndex
        Select Case operacion_
            Case "Agregar"
                lst.Add(MiSueldo)
            Case "Eliminar"
                lst.RemoveAt(indice_)
            Case "Modificar"
                lst.Item(indice_) = MiSueldo 

                FormGrid.DataGridView1.Refresh()
        End Select
        Me.Close()
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub
    Private Sub id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles id.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Nombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub saldo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles saldo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Dirección_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Dirección.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub CategIva_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CategIva.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub
End Class
