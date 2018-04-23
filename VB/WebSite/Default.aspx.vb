Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI.WebControls

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Public Function getClientID(ByVal colName As String, ByVal controlName As String) As String
		Dim t As TextBox = CType(grid.FindHeaderTemplateControl(grid.Columns(colName), controlName), TextBox)
		Return t.ClientID
	End Function
End Class