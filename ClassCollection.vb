Imports System.ComponentModel
Public Class ClassCollection


    Inherits BindingList(Of ClassUnitaria)

    Protected Overrides Sub OnAddingNew(ByVal e As System.ComponentModel.AddingNewEventArgs)

        e.NewObject = New ClassUnitaria()

    End Sub
End Class
