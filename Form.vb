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


        MiSueldo.Id = (id.Text)
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
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Nombre.KeyPress
        If Char.IsNumber(e.KeyChar) And Char.IsControl(e.KeyChar) Then

            e.Handled = False

            Exit Sub
        End If
    End Sub

    Private Sub saldo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles saldo.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then

            e.Handled = False

            Exit Sub
        End If
    End Sub

    Private Sub Dirección_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Dirección.KeyPress
        If Char.IsNumber(e.KeyChar) And Char.IsControl(e.KeyChar) Then

            e.Handled = False

            Exit Sub
        End If
    End Sub

    
End Class
