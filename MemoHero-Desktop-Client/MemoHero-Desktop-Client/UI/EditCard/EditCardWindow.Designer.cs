
namespace MemoHeroDesktopClient.UI.EditCard
{
    partial class EditCardWindow
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
            ((System.ComponentModel.ISupportInitialize)(this.textCardFront.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCardBack.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenTags.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategories.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textCardFront
            // 
            this.textCardFront.Location = new System.Drawing.Point(54, 36);
            this.textCardFront.Name = "textCardFront";
            this.textCardFront.Size = new System.Drawing.Size(482, 138);
            this.textCardFront.TabIndex = 1;
            // 
            // textCardBack
            // 
            this.textCardBack.Location = new System.Drawing.Point(54, 180);
            this.textCardBack.Name = "textCardBack";
            this.textCardBack.Size = new System.Drawing.Size(482, 138);
            this.textCardBack.TabIndex = 2;
            // 
            // tokenTags
            // 
            this.tokenTags.Location = new System.Drawing.Point(54, 372);
            this.tokenTags.Name = "tokenTags";
            this.tokenTags.Properties.EditMode = DevExpress.XtraEditors.TokenEditMode.Manual;
            this.tokenTags.Properties.Separators.AddRange(new string[] {
            ","});
            this.tokenTags.Size = new System.Drawing.Size(207, 20);
            this.tokenTags.TabIndex = 3;
            this.tokenTags.ValidateToken += new DevExpress.XtraEditors.TokenEditValidateTokenEventHandler(this.tokenTags_ValidateToken);
            // 
            // listCategories
            // 
            this.listCategories.Location = new System.Drawing.Point(54, 346);
            this.listCategories.Name = "listCategories";
            this.listCategories.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.listCategories.Properties.Items.AddRange(new object[] {
            "Arts",
            "Computers",
            "History",
            "Languages",
            "Science"});
            this.listCategories.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.listCategories.Size = new System.Drawing.Size(134, 20);
            this.listCategories.TabIndex = 6;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(54, 398);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // EditCardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 453);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.listCategories);
            this.Controls.Add(this.tokenTags);
            this.Controls.Add(this.textCardBack);
            this.Controls.Add(this.textCardFront);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EditCardWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewCard";
            ((System.ComponentModel.ISupportInitialize)(this.textCardFront.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCardBack.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenTags.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategories.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit textCardFront;
        private DevExpress.XtraEditors.MemoEdit textCardBack;
        private DevExpress.XtraEditors.TokenEdit tokenTags;
        private DevExpress.XtraEditors.ComboBoxEdit listCategories;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
    }
}