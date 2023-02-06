
namespace MemoHeroDesktopClient.UI.NewCard
{
    partial class NewCardWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textCardFront = new DevExpress.XtraEditors.MemoEdit();
            this.textCardBack = new DevExpress.XtraEditors.MemoEdit();
            this.tokenTags = new DevExpress.XtraEditors.TokenEdit();
            this.listCategories = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFront = new DevExpress.XtraEditors.LabelControl();
            this.lblBack = new DevExpress.XtraEditors.LabelControl();
            this.lblCategory = new DevExpress.XtraEditors.LabelControl();
            this.lblTags = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.textCardFront.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCardBack.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenTags.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategories.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textCardFront
            // 
            this.textCardFront.EditValue = "";
            this.textCardFront.Location = new System.Drawing.Point(83, 3);
            this.textCardFront.Name = "textCardFront";
            this.textCardFront.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.textCardFront.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCardFront.Properties.Appearance.Options.UseFont = true;
            this.textCardFront.Size = new System.Drawing.Size(482, 138);
            this.textCardFront.TabIndex = 1;
            // 
            // textCardBack
            // 
            this.textCardBack.Location = new System.Drawing.Point(83, 147);
            this.textCardBack.Name = "textCardBack";
            this.textCardBack.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCardBack.Properties.Appearance.Options.UseFont = true;
            this.textCardBack.Size = new System.Drawing.Size(482, 138);
            this.textCardBack.TabIndex = 2;
            // 
            // tokenTags
            // 
            this.tokenTags.Location = new System.Drawing.Point(83, 320);
            this.tokenTags.Name = "tokenTags";
            this.tokenTags.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokenTags.Properties.Appearance.Options.UseFont = true;
            this.tokenTags.Properties.EditMode = DevExpress.XtraEditors.TokenEditMode.Manual;
            this.tokenTags.Properties.Separators.AddRange(new string[] {
            ","});
            this.tokenTags.Size = new System.Drawing.Size(207, 22);
            this.tokenTags.TabIndex = 3;
            this.tokenTags.ValidateToken += new DevExpress.XtraEditors.TokenEditValidateTokenEventHandler(this.tokenTags_ValidateToken);
            // 
            // listCategories
            // 
            this.listCategories.Location = new System.Drawing.Point(83, 291);
            this.listCategories.Name = "listCategories";
            this.listCategories.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCategories.Properties.Appearance.Options.UseFont = true;
            this.listCategories.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.listCategories.Properties.Items.AddRange(new object[] {
            "Arts",
            "Computers",
            "History",
            "Languages",
            "Science"});
            this.listCategories.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.listCategories.Size = new System.Drawing.Size(207, 22);
            this.listCategories.TabIndex = 6;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(210, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblTags, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCategory, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBack, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tokenTags, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFront, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listCategories, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textCardFront, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textCardBack, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 431);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // lblFront
            // 
            this.lblFront.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.lblFront.Appearance.Options.UseFont = true;
            this.lblFront.Location = new System.Drawing.Point(3, 3);
            this.lblFront.Name = "lblFront";
            this.lblFront.Size = new System.Drawing.Size(44, 23);
            this.lblFront.TabIndex = 25;
            this.lblFront.Text = "Front";
            // 
            // lblBack
            // 
            this.lblBack.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.lblBack.Appearance.Options.UseFont = true;
            this.lblBack.Location = new System.Drawing.Point(3, 147);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(40, 23);
            this.lblBack.TabIndex = 26;
            this.lblBack.Text = "Back";
            // 
            // lblCategory
            // 
            this.lblCategory.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Appearance.Options.UseFont = true;
            this.lblCategory.Location = new System.Drawing.Point(3, 291);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(74, 23);
            this.lblCategory.TabIndex = 27;
            this.lblCategory.Text = "Category";
            // 
            // lblTags
            // 
            this.lblTags.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.lblTags.Appearance.Options.UseFont = true;
            this.lblTags.Location = new System.Drawing.Point(3, 320);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(40, 23);
            this.lblTags.TabIndex = 28;
            this.lblTags.Text = "Tags";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.15353F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.84647F));
            this.tableLayoutPanel2.Controls.Add(this.btnCreate, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(83, 349);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(482, 96);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // NewCardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "NewCardWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewCard";
            ((System.ComponentModel.ISupportInitialize)(this.textCardFront.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCardBack.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenTags.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategories.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit textCardFront;
        private DevExpress.XtraEditors.MemoEdit textCardBack;
        private DevExpress.XtraEditors.TokenEdit tokenTags;
        private DevExpress.XtraEditors.ComboBoxEdit listCategories;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl lblFront;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl lblTags;
        private DevExpress.XtraEditors.LabelControl lblCategory;
        private DevExpress.XtraEditors.LabelControl lblBack;
    }
}