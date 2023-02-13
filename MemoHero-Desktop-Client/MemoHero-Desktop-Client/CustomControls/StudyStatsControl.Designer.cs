
namespace MemoHeroDesktopClient.CustomControls
{
    partial class StudyStatsControl
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurrentHP = new DevExpress.XtraEditors.LabelControl();
            this.lblLabelCurrentCategory = new DevExpress.XtraEditors.LabelControl();
            this.lblCategoryProgress = new DevExpress.XtraEditors.LabelControl();
            this.progressBarHP = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblCurrentCategory = new DevExpress.XtraEditors.LabelControl();
            this.progressBarCategory = new DevExpress.XtraEditors.ProgressBarControl();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarHP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarCategory.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.lblCategoryProgress, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.lblLabelCurrentCategory, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.progressBarCategory, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.lblCurrentHP, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lblCurrentCategory, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.progressBarHP, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(311, 109);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // lblCurrentHP
            // 
            this.lblCurrentHP.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentHP.Appearance.Options.UseFont = true;
            this.lblCurrentHP.Location = new System.Drawing.Point(3, 23);
            this.lblCurrentHP.Name = "lblCurrentHP";
            this.lblCurrentHP.Size = new System.Drawing.Size(87, 21);
            this.lblCurrentHP.TabIndex = 5;
            this.lblCurrentHP.Text = "Current HP:";
            // 
            // lblLabelCurrentCategory
            // 
            this.lblLabelCurrentCategory.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelCurrentCategory.Appearance.Options.UseFont = true;
            this.lblLabelCurrentCategory.Location = new System.Drawing.Point(3, 50);
            this.lblLabelCurrentCategory.Name = "lblLabelCurrentCategory";
            this.lblLabelCurrentCategory.Size = new System.Drawing.Size(134, 21);
            this.lblLabelCurrentCategory.TabIndex = 6;
            this.lblLabelCurrentCategory.Text = "Current Category:";
            // 
            // lblCategoryProgress
            // 
            this.lblCategoryProgress.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryProgress.Appearance.Options.UseFont = true;
            this.lblCategoryProgress.Location = new System.Drawing.Point(3, 77);
            this.lblCategoryProgress.Name = "lblCategoryProgress";
            this.lblCategoryProgress.Size = new System.Drawing.Size(142, 21);
            this.lblCategoryProgress.TabIndex = 7;
            this.lblCategoryProgress.Text = "Category Progress:";
            // 
            // progressBarHP
            // 
            this.progressBarHP.Location = new System.Drawing.Point(151, 23);
            this.progressBarHP.Name = "progressBarHP";
            this.progressBarHP.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarHP.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.progressBarHP.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.Red;
            this.progressBarHP.Properties.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Red;
            this.progressBarHP.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.progressBarHP.Size = new System.Drawing.Size(150, 20);
            this.progressBarHP.TabIndex = 8;
            // 
            // lblCurrentCategory
            // 
            this.lblCurrentCategory.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCurrentCategory.Appearance.Options.UseFont = true;
            this.lblCurrentCategory.Location = new System.Drawing.Point(151, 50);
            this.lblCurrentCategory.Name = "lblCurrentCategory";
            this.lblCurrentCategory.Size = new System.Drawing.Size(145, 21);
            this.lblCurrentCategory.TabIndex = 9;
            this.lblCurrentCategory.Text = "category placeholder";
            // 
            // progressBarCategory
            // 
            this.progressBarCategory.Location = new System.Drawing.Point(151, 77);
            this.progressBarCategory.Name = "progressBarCategory";
            this.progressBarCategory.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarCategory.Size = new System.Drawing.Size(150, 20);
            this.progressBarCategory.TabIndex = 10;
            // 
            // StudyStatsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "StudyStatsControl";
            this.Size = new System.Drawing.Size(311, 109);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarHP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarCategory.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private DevExpress.XtraEditors.LabelControl lblCurrentHP;
        private DevExpress.XtraEditors.LabelControl lblLabelCurrentCategory;
        private DevExpress.XtraEditors.LabelControl lblCategoryProgress;
        private DevExpress.XtraEditors.ProgressBarControl progressBarHP;
        private DevExpress.XtraEditors.LabelControl lblCurrentCategory;
        private DevExpress.XtraEditors.ProgressBarControl progressBarCategory;
    }
}
