using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using System.Drawing;
using System.Reflection;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors;
using System.ComponentModel;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Popup;
using DevExpress.Utils;
using DevExpress.Utils.Drawing.Helpers;

namespace WindowsApplication3 {
    //The attribute that points to the registration method

   
    [UserRepositoryItem("RegisterCustomEdit")]
    public class RepositoryItemCustomEdit: RepositoryItemDateEdit {

        //The static constructor which calls the registration method
        static RepositoryItemCustomEdit() { RegisterCustomEdit(); }

       
        //The unique name for the custom editor
        public const string CustomEditName = "CustomEdit";

        //Return the unique name
        public override string EditorTypeName { get { return CustomEditName; } }

        //Register the editor
        public static void RegisterCustomEdit() {
            //Icon representing the editor within a container editor's Designer
            Image img = null;
            try {
                img = (Bitmap)Bitmap.FromStream(Assembly.GetExecutingAssembly().
                  GetManifestResourceStream("DevExpress.CustomEditors.CustomEdit.bmp"));
            }
            catch {
            }
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName,
              typeof(CustomEdit), typeof(RepositoryItemCustomEdit),
              typeof(DateEditViewInfo), new ButtonEditPainter(), true, img));
        }

        //Override the Assign method
        public override void Assign(RepositoryItem item) {
            BeginUpdate();
            try {
                base.Assign(item);
                RepositoryItemCustomEdit source = item as RepositoryItemCustomEdit;
                if(source == null) return;
            }
            finally {
                EndUpdate();
            }
        }
    }


    public class CustomEdit: DateEdit {

        //The static constructor which calls the registration method
        static CustomEdit() { RepositoryItemCustomEdit.RegisterCustomEdit(); }

        //Initialize the new instance
        public CustomEdit() {
            //...
        }

        //Return the unique name
        public override string EditorTypeName {
            get {
                return
RepositoryItemCustomEdit.CustomEditName;
            }
        }

        //Override the Properties property
        //Simply type-cast the object to the custom repository item type
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomEdit Properties {
            get { return base.Properties as RepositoryItemCustomEdit; }
        }

        protected internal virtual bool IsVistaDisplayMode() {
            if(Properties.VistaDisplayMode == DefaultBoolean.False) return false;
            if(Properties.VistaDisplayMode == DefaultBoolean.True) return true;
            return NativeVista.IsVista;
        }
		

        protected override DevExpress.XtraEditors.Popup.PopupBaseForm CreatePopupForm() {
            if(IsVistaDisplayMode()) return new CustomVistaPopupDateEditForm(this);
            return new CustomPopupDateEditForm(this);
        }
    }

    public class CustomVistaPopupDateEditForm: VistaPopupDateEditForm {
        public CustomVistaPopupDateEditForm(DateEdit de) : base(de) { }
        protected override DateEditCalendar CreateCalendar() {
            return new CustomVistaDateEditCalendar(OwnerEdit.Properties, OwnerEdit.EditValue);
        }
    }

    public class CustomVistaDateEditCalendar: VistaDateEditCalendar {
        public CustomVistaDateEditCalendar(RepositoryItemDateEdit de, object dt) : base(de, dt) { }
        SimpleButton btn;
        int indent = 5;
        public SimpleButton Button { get {return btn; } }
        protected override void CreateButtons() {
            base.CreateButtons();
            btn = new SimpleButton();
            btn.Click += OnNewButtonClick;
            btn.Text = "New Button";
            Controls.Add(btn);
        }

        void OnNewButtonClick(object sender, EventArgs e) {
            XtraMessageBox.Show("New Button Click");
        }

        protected override void UpdateButtons() {
            base.UpdateButtons();
            if(Button != null) {
                Button.Visible = true;
                Button.Size = new Size(100, 30);
                Button.Location = new Point(Bounds.X + Bounds.Width / 2 - Button.Size.Width / 2, Bounds.Bottom - Button.Size.Height - indent);
            }
        }
        public override Size CalcBestSize(Graphics g) {
            Size bestSize = base.CalcBestSize(g);
            bestSize.Height += Button.Height + indent; 
            return bestSize;
        }
    }

    public class CustomPopupDateEditForm: PopupDateEditForm {
        public CustomPopupDateEditForm(DateEdit de) : base(de) { }
        protected override DateEditCalendar CreateCalendar() {
            return new CustomDateEditCalendar(OwnerEdit.Properties, OwnerEdit.EditValue);
        }
    }

    public class CustomDateEditCalendar: DateEditCalendar {
        public CustomDateEditCalendar(RepositoryItemDateEdit de, object dt) : base(de, dt) { }
        SimpleButton btn;
        int indent = 5;
        public SimpleButton Button { get { return btn; } }
        protected override void CreateButtons() {
            base.CreateButtons();
            btn = new SimpleButton();
            btn.Click += OnNewButtonClick;
            btn.Text = "New Button";
            Controls.Add(btn);
        }

        void OnNewButtonClick(object sender, EventArgs e) {
            XtraMessageBox.Show("New Button Click");
        }

        protected override void UpdateButtons() {
            base.UpdateButtons();
            if(Button != null) {
                Button.Visible = true;
                Button.Size = new Size(100, 30);
                Button.Location = new Point(Bounds.X + Bounds.Width / 2 - Button.Size.Width / 2, Bounds.Bottom - Button.Size.Height - indent);
            }
        }
        public override Size CalcBestSize(Graphics g) {
            Size bestSize = base.CalcBestSize(g);
            bestSize.Height += Button.Height + indent;
            return bestSize;
        }
    }

}
