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
        protected override CalendarControl CreateCalendar() {
            return new CustomVistaDateEditCalendar();
        }
    }

    public class CustomVistaDateEditCalendar: VistaCalendarControl {
       
        public CustomVistaDateEditCalendar()
        {
            this.AutoSize = false;
            btn = new SimpleButton();
            btn.Click += OnNewButtonClick;
            btn.Text = "New Button";
            Controls.Add(btn);
            btn.Size = new Size(100, 30);
            btn.Location = new Point(Bounds.X + Bounds.Width / 2 - btn.Size.Width / 2, Bounds.Bottom  - indent);
      }
                                                                                                   
        SimpleButton btn;
        int indent = 5;
        public SimpleButton Button { get {return btn; } }
        void OnNewButtonClick(object sender, EventArgs e) {
            XtraMessageBox.Show("New Button Click");
        }
        public override Size CalcBestSize() {
            if(Button == null)
                return base.CalcBestSize();
            Size bestSize = base.CalcBestSize();
            bestSize.Height += Button.Height + indent;
            return bestSize;
        }
    }

    public class CustomPopupDateEditForm: PopupDateEditForm {
        public CustomPopupDateEditForm(DateEdit de) : base(de) { }
        protected override CalendarControl CreateCalendar() {
            return new CustomDateEditCalendar();
        }
    }

    public class CustomDateEditCalendar: CalendarControl {
        
        SimpleButton btn;
        int indent = 5;
        public CustomDateEditCalendar()
        {
            this.AutoSize = false;
            btn = new SimpleButton();
            btn.Click += OnNewButtonClick;
            btn.Text = "New Button";
            Controls.Add(btn);
            btn.Size = new Size(100, 30);
            btn.Location = new Point(Bounds.X + Bounds.Width / 2 - btn.Size.Width / 2, Bounds.Bottom - indent);
        }
                       
        public SimpleButton Button { get { return btn; } }
       
        void OnNewButtonClick(object sender, EventArgs e) {
            XtraMessageBox.Show("New Button Click");
        }
        
        public override Size CalcBestSize()
        {
            if (Button == null)
                return base.CalcBestSize();
                Size bestSize = base.CalcBestSize();
                bestSize.Height += Button.Height + indent;
                Size = bestSize;
                return bestSize;
        }
       
    }

}
