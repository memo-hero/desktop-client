
namespace MemoHeroDesktopClient.CustomControls
{
    partial class CategoryStats
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.lblCategoryName = new DevExpress.XtraEditors.LabelControl();
            this.lblCategoryLevel = new DevExpress.XtraEditors.LabelControl();
            this.progressCategory = new DevExpress.XtraEditors.ProgressBarControl();
            this.pictureCategory = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 17.09F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 42.91F)});
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Controls.Add(this.pictureCategory);
            this.tablePanel1.Location = new System.Drawing.Point(-11, -10);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 57F)});
            this.tablePanel1.Size = new System.Drawing.Size(528, 106);
            this.tablePanel1.TabIndex = 44;
            this.tablePanel1.UseSkinIndents = true;
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 1);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 33.88F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26.12F)});
            this.tablePanel2.Controls.Add(this.lblCategoryLevel);
            this.tablePanel2.Controls.Add(this.progressCategory);
            this.tablePanel2.Controls.Add(this.lblCategoryName);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(81, 12);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 0);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(434, 81);
            this.tablePanel2.TabIndex = 45;
            this.tablePanel2.UseSkinIndents = true;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Appearance.Options.UseFont = true;
            this.lblCategoryName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.tablePanel2.SetColumn(this.lblCategoryName, 0);
            this.lblCategoryName.Location = new System.Drawing.Point(13, 12);
            this.lblCategoryName.Name = "lblCategoryName";
            this.tablePanel2.SetRow(this.lblCategoryName, 0);
            this.lblCategoryName.Size = new System.Drawing.Size(227, 32);
            this.lblCategoryName.TabIndex = 46;
            this.lblCategoryName.Text = "Category Placeholder";
            // 
            // lblCategoryLevel
            // 
            this.lblCategoryLevel.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryLevel.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.lblCategoryLevel, 1);
            this.lblCategoryLevel.Location = new System.Drawing.Point(313, 48);
            this.lblCategoryLevel.Name = "lblCategoryLevel";
            this.tablePanel2.SetRow(this.lblCategoryLevel, 1);
            this.lblCategoryLevel.Size = new System.Drawing.Size(108, 20);
            this.lblCategoryLevel.TabIndex = 46;
            this.lblCategoryLevel.Text = "Level Placeholder";
            // 
            // progressCategory
            // 
            this.tablePanel2.SetColumn(this.progressCategory, 0);
            this.progressCategory.Location = new System.Drawing.Point(13, 49);
            this.progressCategory.Name = "progressCategory";
            this.tablePanel2.SetRow(this.progressCategory, 1);
            this.progressCategory.Size = new System.Drawing.Size(296, 18);
            this.progressCategory.TabIndex = 46;
            // 
            // pictureCategory
            // 
            this.tablePanel1.SetColumn(this.pictureCategory, 0);
            this.pictureCategory.Location = new System.Drawing.Point(13, 20);
            this.pictureCategory.Name = "pictureCategory";
            this.tablePanel1.SetRow(this.pictureCategory, 0);
            this.pictureCategory.Size = new System.Drawing.Size(64, 64);
            this.pictureCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCategory.TabIndex = 48;
            this.pictureCategory.TabStop = false;
            // 
            // CategoryStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "CategoryStats";
            this.Size = new System.Drawing.Size(506, 85);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.tablePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.PictureBox pictureCategory;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.LabelControl lblCategoryName;
        private DevExpress.XtraEditors.ProgressBarControl progressCategory;
        private DevExpress.XtraEditors.LabelControl lblCategoryLevel;
    }
}
