
namespace MemoHeroDesktopClient.CustomControls
{
    partial class CardFormControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.dateDueDate = new DevExpress.XtraEditors.DateEdit();
            this.tokenTags = new DevExpress.XtraEditors.TokenEdit();
            this.textCardFront = new DevExpress.XtraEditors.MemoEdit();
            this.listCategories = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textCardBack = new DevExpress.XtraEditors.MemoEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblFront = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblBack = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblCategories = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblTags = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblDueDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDueDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDueDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenTags.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCardFront.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategories.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCardBack.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDueDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.dateDueDate);
            this.layoutControl.Controls.Add(this.tokenTags);
            this.layoutControl.Controls.Add(this.textCardFront);
            this.layoutControl.Controls.Add(this.listCategories);
            this.layoutControl.Controls.Add(this.textCardBack);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2503, 296, 650, 400);
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(650, 350);
            this.layoutControl.TabIndex = 10;
            this.layoutControl.Text = "layoutControl1";
            // 
            // dateDueDate
            // 
            this.dateDueDate.EditValue = null;
            this.dateDueDate.Enabled = false;
            this.dateDueDate.Location = new System.Drawing.Point(387, 310);
            this.dateDueDate.Name = "dateDueDate";
            this.dateDueDate.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDueDate.Properties.Appearance.Options.UseFont = true;
            this.dateDueDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDueDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDueDate.Size = new System.Drawing.Size(251, 28);
            this.dateDueDate.StyleController = this.layoutControl;
            this.dateDueDate.TabIndex = 7;
            // 
            // tokenTags
            // 
            this.tokenTags.Location = new System.Drawing.Point(82, 278);
            this.tokenTags.Name = "tokenTags";
            this.tokenTags.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokenTags.Properties.Appearance.Options.UseFont = true;
            this.tokenTags.Properties.EditMode = DevExpress.XtraEditors.TokenEditMode.Manual;
            this.tokenTags.Properties.Separators.AddRange(new string[] {
            ","});
            this.tokenTags.Size = new System.Drawing.Size(556, 28);
            this.tokenTags.StyleController = this.layoutControl;
            this.tokenTags.TabIndex = 3;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Cannot be blank";
            this.dxValidationProvider.SetValidationRule(this.tokenTags, conditionValidationRule1);
            this.tokenTags.ValidateToken += new DevExpress.XtraEditors.TokenEditValidateTokenEventHandler(this.tokenTags_ValidateToken);
            // 
            // textCardFront
            // 
            this.textCardFront.EditValue = "";
            this.textCardFront.Location = new System.Drawing.Point(82, 12);
            this.textCardFront.Name = "textCardFront";
            this.textCardFront.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.textCardFront.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCardFront.Properties.Appearance.Options.UseFont = true;
            this.textCardFront.Size = new System.Drawing.Size(556, 129);
            this.textCardFront.StyleController = this.layoutControl;
            this.textCardFront.TabIndex = 1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Cannot be blank";
            this.dxValidationProvider.SetValidationRule(this.textCardFront, conditionValidationRule2);
            // 
            // listCategories
            // 
            this.listCategories.Location = new System.Drawing.Point(82, 310);
            this.listCategories.Name = "listCategories";
            this.listCategories.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCategories.Properties.Appearance.Options.UseFont = true;
            this.listCategories.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCategories.Properties.AppearanceDropDown.Options.UseFont = true;
            this.listCategories.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.listCategories.Properties.Items.AddRange(new object[] {
            "Arts",
            "Computers",
            "History",
            "Languages",
            "Science"});
            this.listCategories.Properties.Sorted = true;
            this.listCategories.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.listCategories.Size = new System.Drawing.Size(231, 28);
            this.listCategories.StyleController = this.layoutControl;
            this.listCategories.TabIndex = 6;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Cannot be blank";
            this.dxValidationProvider.SetValidationRule(this.listCategories, conditionValidationRule3);
            // 
            // textCardBack
            // 
            this.textCardBack.Location = new System.Drawing.Point(82, 145);
            this.textCardBack.Name = "textCardBack";
            this.textCardBack.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCardBack.Properties.Appearance.Options.UseFont = true;
            this.textCardBack.Size = new System.Drawing.Size(556, 129);
            this.textCardBack.StyleController = this.layoutControl;
            this.textCardBack.TabIndex = 2;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Cannot be blank";
            this.dxValidationProvider.SetValidationRule(this.textCardBack, conditionValidationRule4);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblFront,
            this.lblBack,
            this.lblCategories,
            this.lblTags,
            this.lblDueDate});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(650, 350);
            this.Root.TextVisible = false;
            // 
            // lblFront
            // 
            this.lblFront.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFront.AppearanceItemCaption.Options.UseFont = true;
            this.lblFront.Control = this.textCardFront;
            this.lblFront.Location = new System.Drawing.Point(0, 0);
            this.lblFront.Name = "lblFront";
            this.lblFront.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFront.OptionsPrint.AppearanceItem.Options.UseFont = true;
            this.lblFront.Size = new System.Drawing.Size(630, 133);
            this.lblFront.Text = "Front";
            this.lblFront.TextSize = new System.Drawing.Size(58, 17);
            // 
            // lblBack
            // 
            this.lblBack.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBack.AppearanceItemCaption.Options.UseFont = true;
            this.lblBack.Control = this.textCardBack;
            this.lblBack.Location = new System.Drawing.Point(0, 133);
            this.lblBack.Name = "lblBack";
            this.lblBack.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.OptionsPrint.AppearanceItem.Options.UseFont = true;
            this.lblBack.Size = new System.Drawing.Size(630, 133);
            this.lblBack.Text = "Back";
            this.lblBack.TextSize = new System.Drawing.Size(58, 17);
            // 
            // lblCategories
            // 
            this.lblCategories.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.AppearanceItemCaption.Options.UseFont = true;
            this.lblCategories.Control = this.listCategories;
            this.lblCategories.Location = new System.Drawing.Point(0, 298);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.OptionsPrint.AppearanceItem.Options.UseFont = true;
            this.lblCategories.Size = new System.Drawing.Size(305, 32);
            this.lblCategories.Text = "Category";
            this.lblCategories.TextSize = new System.Drawing.Size(58, 17);
            // 
            // lblTags
            // 
            this.lblTags.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTags.AppearanceItemCaption.Options.UseFont = true;
            this.lblTags.Control = this.tokenTags;
            this.lblTags.Location = new System.Drawing.Point(0, 266);
            this.lblTags.Name = "lblTags";
            this.lblTags.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTags.OptionsPrint.AppearanceItem.Options.UseFont = true;
            this.lblTags.Size = new System.Drawing.Size(630, 32);
            this.lblTags.Text = "Tags";
            this.lblTags.TextSize = new System.Drawing.Size(58, 17);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDueDate.AppearanceItemCaption.Options.UseFont = true;
            this.lblDueDate.Control = this.dateDueDate;
            this.lblDueDate.CustomizationFormText = "Due Date";
            this.lblDueDate.Location = new System.Drawing.Point(305, 298);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(325, 32);
            this.lblDueDate.Text = "Due Date";
            this.lblDueDate.TextSize = new System.Drawing.Size(58, 17);
            // 
            // CardFormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.layoutControl);
            this.Name = "CardFormControl";
            this.Size = new System.Drawing.Size(650, 350);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateDueDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDueDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenTags.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCardFront.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategories.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCardBack.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDueDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.TokenEdit tokenTags;
        private DevExpress.XtraEditors.MemoEdit textCardFront;
        private DevExpress.XtraEditors.ComboBoxEdit listCategories;
        private DevExpress.XtraEditors.MemoEdit textCardBack;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lblFront;
        private DevExpress.XtraLayout.LayoutControlItem lblBack;
        private DevExpress.XtraLayout.LayoutControlItem lblCategories;
        private DevExpress.XtraLayout.LayoutControlItem lblTags;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
        private DevExpress.XtraEditors.DateEdit dateDueDate;
        private DevExpress.XtraLayout.LayoutControlItem lblDueDate;
    }
}
