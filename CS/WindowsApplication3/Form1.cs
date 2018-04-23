using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils.Drawing;
using DevExpress.Utils;
using DevExpress.XtraVerticalGrid;
using System.Reflection;
using DevExpress.XtraVerticalGrid.Painters;
using DevExpress.XtraGrid.Drawing;
using DevExpress.XtraGrid;
using DevExpress.XtraTreeList;
using DevExpress.XtraEditors;

namespace WindowsApplication3 {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }
        public void InitData() {
            for(int i = 0;i < 10;i++)
                dataSet11.Tables[0].Rows.Add(new object[] { i, i, i, DateTime.Now.AddMinutes(i)});
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.InitData();
            gridControl1.ForceInitialize();
        }
    }
}
