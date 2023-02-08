
namespace MemoHeroDesktopClient.UI.EditCard
{
    partial class EditCardForm
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
            this.editPanel = new System.Windows.Forms.Panel();
            this.btnClearTags = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // editPanel
            // 
            this.editPanel.AutoScroll = true;
            this.editPanel.Location = new System.Drawing.Point(8, 8);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(655, 355);
            this.editPanel.TabIndex = 9;
            // 
            // btnClearTags
            // 
            this.btnClearTags.Location = new System.Drawing.Point(8, 369);
            this.btnClearTags.Name = "btnClearTags";
            this.btnClearTags.Size = new System.Drawing.Size(91, 23);
            this.btnClearTags.TabIndex = 13;
            this.btnClearTags.TabStop = false;
            this.btnClearTags.Text = "Clear Tags";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(588, 369);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Close";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(507, 369);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditCardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 399);
            this.Controls.Add(this.btnClearTags);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.editPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EditCardWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Card";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel editPanel;
        private DevExpress.XtraEditors.SimpleButton btnClearTags;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}