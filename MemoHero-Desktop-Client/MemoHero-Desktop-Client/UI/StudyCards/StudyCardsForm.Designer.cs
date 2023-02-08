
namespace MemoHeroDesktopClient.UI.StudyCards
{
    partial class StudyCardsForm
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
            this.lblCardText = new DevExpress.XtraEditors.LabelControl();
            this.lblCardBack = new DevExpress.XtraEditors.LabelControl();
            this.pictureCard = new System.Windows.Forms.PictureBox();
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.groupStats = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupStats)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCardText
            // 
            this.lblCardText.AllowHtmlString = true;
            this.lblCardText.Appearance.Font = new System.Drawing.Font("Weber Hand ITC Std", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardText.Appearance.Options.UseFont = true;
            this.lblCardText.Appearance.Options.UseTextOptions = true;
            this.lblCardText.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCardText.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblCardText.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblCardText.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCardText.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.lblCardText.Location = new System.Drawing.Point(3, 58);
            this.lblCardText.Name = "lblCardText";
            this.lblCardText.Size = new System.Drawing.Size(794, 104);
            this.lblCardText.TabIndex = 1;
            this.lblCardText.Text = "Placeholder Front";
            // 
            // lblCardBack
            // 
            this.lblCardBack.AllowHtmlString = true;
            this.lblCardBack.Appearance.Font = new System.Drawing.Font("Weber Hand ITC Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardBack.Appearance.Options.UseFont = true;
            this.lblCardBack.Appearance.Options.UseTextOptions = true;
            this.lblCardBack.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCardBack.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblCardBack.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblCardBack.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCardBack.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.lblCardBack.Location = new System.Drawing.Point(3, 168);
            this.lblCardBack.Name = "lblCardBack";
            this.lblCardBack.Size = new System.Drawing.Size(794, 322);
            this.lblCardBack.TabIndex = 2;
            this.lblCardBack.Text = "Placeholder Back";
            this.lblCardBack.Visible = false;
            // 
            // pictureCard
            // 
            this.pictureCard.Image = global::MemoHeroDesktopClient.Properties.Resources.card_background_2;
            this.pictureCard.Location = new System.Drawing.Point(3, 12);
            this.pictureCard.Name = "pictureCard";
            this.pictureCard.Size = new System.Drawing.Size(810, 489);
            this.pictureCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureCard.TabIndex = 0;
            this.pictureCard.TabStop = false;
            // 
            // groupControl
            // 
            this.groupControl.Location = new System.Drawing.Point(3, 507);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(400, 194);
            this.groupControl.TabIndex = 3;
            this.groupControl.Text = "Card Control";
            // 
            // groupStats
            // 
            this.groupStats.Location = new System.Drawing.Point(407, 507);
            this.groupStats.Name = "groupStats";
            this.groupStats.Size = new System.Drawing.Size(400, 194);
            this.groupStats.TabIndex = 4;
            this.groupStats.Text = "Your Stats";
            // 
            // StudyCardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 706);
            this.Controls.Add(this.groupStats);
            this.Controls.Add(this.groupControl);
            this.Controls.Add(this.lblCardBack);
            this.Controls.Add(this.lblCardText);
            this.Controls.Add(this.pictureCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudyCardsForm";
            this.Text = "StudyCardsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCard;
        private DevExpress.XtraEditors.LabelControl lblCardText;
        private DevExpress.XtraEditors.LabelControl lblCardBack;
        private DevExpress.XtraEditors.GroupControl groupControl;
        private DevExpress.XtraEditors.GroupControl groupStats;
    }
}