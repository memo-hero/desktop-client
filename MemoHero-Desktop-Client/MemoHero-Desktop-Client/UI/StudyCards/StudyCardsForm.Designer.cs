
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
            this.btnResponse6 = new DevExpress.XtraEditors.SimpleButton();
            this.btnResponse4 = new DevExpress.XtraEditors.SimpleButton();
            this.btnResponse3 = new DevExpress.XtraEditors.SimpleButton();
            this.btnResponse2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnResponse1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnResponse0 = new DevExpress.XtraEditors.SimpleButton();
            this.btnReveal = new DevExpress.XtraEditors.SimpleButton();
            this.groupStats = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
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
            this.groupControl.Controls.Add(this.btnResponse6);
            this.groupControl.Controls.Add(this.btnResponse4);
            this.groupControl.Controls.Add(this.btnResponse3);
            this.groupControl.Controls.Add(this.btnResponse2);
            this.groupControl.Controls.Add(this.btnResponse1);
            this.groupControl.Controls.Add(this.btnResponse0);
            this.groupControl.Controls.Add(this.btnReveal);
            this.groupControl.Location = new System.Drawing.Point(3, 507);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(400, 194);
            this.groupControl.TabIndex = 3;
            this.groupControl.Text = "Card Control";
            // 
            // btnResponse6
            // 
            this.btnResponse6.Location = new System.Drawing.Point(240, 116);
            this.btnResponse6.Name = "btnResponse6";
            this.btnResponse6.Size = new System.Drawing.Size(75, 23);
            this.btnResponse6.TabIndex = 6;
            this.btnResponse6.Text = "Response 5";
            // 
            // btnResponse4
            // 
            this.btnResponse4.Location = new System.Drawing.Point(159, 116);
            this.btnResponse4.Name = "btnResponse4";
            this.btnResponse4.Size = new System.Drawing.Size(75, 23);
            this.btnResponse4.TabIndex = 5;
            this.btnResponse4.Text = "Response 4";
            // 
            // btnResponse3
            // 
            this.btnResponse3.Location = new System.Drawing.Point(78, 116);
            this.btnResponse3.Name = "btnResponse3";
            this.btnResponse3.Size = new System.Drawing.Size(75, 23);
            this.btnResponse3.TabIndex = 4;
            this.btnResponse3.Text = "Response 3";
            this.btnResponse3.Click += new System.EventHandler(this.btnResponse3_Click);
            // 
            // btnResponse2
            // 
            this.btnResponse2.Location = new System.Drawing.Point(240, 145);
            this.btnResponse2.Name = "btnResponse2";
            this.btnResponse2.Size = new System.Drawing.Size(75, 23);
            this.btnResponse2.TabIndex = 3;
            this.btnResponse2.Text = "Response 2";
            // 
            // btnResponse1
            // 
            this.btnResponse1.Location = new System.Drawing.Point(159, 145);
            this.btnResponse1.Name = "btnResponse1";
            this.btnResponse1.Size = new System.Drawing.Size(75, 23);
            this.btnResponse1.TabIndex = 2;
            this.btnResponse1.Text = "Response 1";
            // 
            // btnResponse0
            // 
            this.btnResponse0.Location = new System.Drawing.Point(78, 145);
            this.btnResponse0.Name = "btnResponse0";
            this.btnResponse0.Size = new System.Drawing.Size(75, 23);
            this.btnResponse0.TabIndex = 1;
            this.btnResponse0.Text = "Response 0";
            // 
            // btnReveal
            // 
            this.btnReveal.Location = new System.Drawing.Point(173, 55);
            this.btnReveal.Name = "btnReveal";
            this.btnReveal.Size = new System.Drawing.Size(75, 23);
            this.btnReveal.TabIndex = 0;
            this.btnReveal.Text = "Reveal";
            this.btnReveal.Click += new System.EventHandler(this.btnReveal_Click);
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
            this.groupControl.ResumeLayout(false);
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
        private DevExpress.XtraEditors.SimpleButton btnReveal;
        private DevExpress.XtraEditors.SimpleButton btnResponse6;
        private DevExpress.XtraEditors.SimpleButton btnResponse4;
        private DevExpress.XtraEditors.SimpleButton btnResponse3;
        private DevExpress.XtraEditors.SimpleButton btnResponse2;
        private DevExpress.XtraEditors.SimpleButton btnResponse1;
        private DevExpress.XtraEditors.SimpleButton btnResponse0;
    }
}