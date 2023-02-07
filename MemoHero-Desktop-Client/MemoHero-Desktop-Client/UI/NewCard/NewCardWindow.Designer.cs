
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
            this.createPanel = new System.Windows.Forms.Panel();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnClearTags = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // createPanel
            // 
            this.createPanel.AutoScroll = true;
            this.createPanel.Location = new System.Drawing.Point(8, 8);
            this.createPanel.Name = "createPanel";
            this.createPanel.Size = new System.Drawing.Size(655, 355);
            this.createPanel.TabIndex = 8;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(501, 369);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(582, 369);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClearTags
            // 
            this.btnClearTags.Location = new System.Drawing.Point(8, 369);
            this.btnClearTags.Name = "btnClearTags";
            this.btnClearTags.Size = new System.Drawing.Size(91, 23);
            this.btnClearTags.TabIndex = 10;
            this.btnClearTags.Text = "Clear Tags";
            this.btnClearTags.Click += new System.EventHandler(this.btnClearTags_Click);
            // 
            // NewCardWindow
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 399);
            this.Controls.Add(this.btnClearTags);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.createPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewCardWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewCard";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel createPanel;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnClearTags;
    }
}