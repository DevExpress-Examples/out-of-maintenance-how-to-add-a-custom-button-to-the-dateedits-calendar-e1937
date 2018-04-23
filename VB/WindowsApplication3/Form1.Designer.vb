Namespace WindowsApplication3
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.customerInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.dataSet11 = New WindowsApplication3.DataSet1()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDateTime = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemCustomEdit1 = New WindowsApplication3.RepositoryItemCustomEdit()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.customEdit1 = New WindowsApplication3.CustomEdit()
			DirectCast(Me.customerInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.repositoryItemCustomEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.repositoryItemCustomEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.customEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.customEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' customerInfoBindingSource
			' 
			Me.customerInfoBindingSource.DataMember = "CustomerInfo"
			Me.customerInfoBindingSource.DataSource = Me.dataSet11
			' 
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.customerInfoBindingSource
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemCustomEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(760, 609)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.UseEmbeddedNavigator = True
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCustomerID, Me.colFirstName, Me.colLastName, Me.colDateTime})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsFilter.UseNewCustomFilterDialog = True
			Me.gridView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
			' 
			' colCustomerID
			' 
			Me.colCustomerID.Caption = "CustomerID"
			Me.colCustomerID.FieldName = "CustomerID"
			Me.colCustomerID.Name = "colCustomerID"
			Me.colCustomerID.Visible = True
			Me.colCustomerID.VisibleIndex = 0
			' 
			' colFirstName
			' 
			Me.colFirstName.Caption = "FirstName"
			Me.colFirstName.FieldName = "FirstName"
			Me.colFirstName.Name = "colFirstName"
			Me.colFirstName.Visible = True
			Me.colFirstName.VisibleIndex = 1
			' 
			' colLastName
			' 
			Me.colLastName.Caption = "LastName"
			Me.colLastName.FieldName = "LastName"
			Me.colLastName.Name = "colLastName"
			Me.colLastName.Visible = True
			Me.colLastName.VisibleIndex = 2
			' 
			' colDateTime
			' 
			Me.colDateTime.Caption = "DateTime"
			Me.colDateTime.ColumnEdit = Me.repositoryItemCustomEdit1
			Me.colDateTime.FieldName = "DateTime"
			Me.colDateTime.Name = "colDateTime"
			Me.colDateTime.Visible = True
			Me.colDateTime.VisibleIndex = 3
			' 
			' repositoryItemCustomEdit1
			' 
			Me.repositoryItemCustomEdit1.AutoHeight = False
			Me.repositoryItemCustomEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemCustomEdit1.Name = "repositoryItemCustomEdit1"
			Me.repositoryItemCustomEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (DirectCast(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "1.jpg")
			Me.imageList1.Images.SetKeyName(1, "2.jpg")
			Me.imageList1.Images.SetKeyName(2, "3.jpg")
			Me.imageList1.Images.SetKeyName(3, "4.jpg")
			Me.imageList1.Images.SetKeyName(4, "5.jpg")
			Me.imageList1.Images.SetKeyName(5, "6.jpg")
			Me.imageList1.Images.SetKeyName(6, "7.jpg")
			' 
			' customEdit1
			' 
			Me.customEdit1.EditValue = Nothing
			Me.customEdit1.Location = New System.Drawing.Point(775, 111)
			Me.customEdit1.Name = "customEdit1"
			Me.customEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.customEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.customEdit1.Size = New System.Drawing.Size(182, 22)
			Me.customEdit1.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(969, 608)
			Me.Controls.Add(Me.customEdit1)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			DirectCast(Me.customerInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.repositoryItemCustomEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.repositoryItemCustomEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.customEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.customEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private customerInfoBindingSource As System.Windows.Forms.BindingSource
		Private dataSet11 As DataSet1
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private imageList1 As System.Windows.Forms.ImageList
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
		Private colFirstName As DevExpress.XtraGrid.Columns.GridColumn
		Private colLastName As DevExpress.XtraGrid.Columns.GridColumn
		Private colDateTime As DevExpress.XtraGrid.Columns.GridColumn
		Private customEdit1 As CustomEdit
		Private repositoryItemCustomEdit1 As RepositoryItemCustomEdit
	End Class
End Namespace

