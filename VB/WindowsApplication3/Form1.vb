Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraVerticalGrid
Imports System.Reflection
Imports DevExpress.XtraVerticalGrid.Painters
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.XtraGrid
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraEditors

Namespace WindowsApplication3
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub
		Public Sub InitData()
			For i As Integer = 0 To 9
				dataSet11.Tables(0).Rows.Add(New Object() { i, i, i, Date.Now.AddMinutes(i)})
			Next i
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.InitData()
			gridControl1.ForceInitialize()
		End Sub
	End Class
End Namespace
