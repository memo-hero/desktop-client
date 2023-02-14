
namespace MemoHeroDesktopClient.CustomControls
{
    partial class UserStatsControl
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
            this.lblWelcome = new DevExpress.XtraEditors.LabelControl();
            this.tableStats = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Appearance.Options.UseFont = true;
            this.lblWelcome.Location = new System.Drawing.Point(3, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(161, 39);
            this.lblWelcome.TabIndex = 41;
            this.lblWelcome.Text = "lblWelcome";
            // 
            // tableStats
            // 
            this.tableStats.ColumnCount = 1;
            this.tableStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableStats.Location = new System.Drawing.Point(26, 45);
            this.tableStats.Name = "tableStats";
            this.tableStats.RowCount = 5;
            this.tableStats.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableStats.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableStats.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableStats.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableStats.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableStats.Size = new System.Drawing.Size(452, 452);
            this.tableStats.TabIndex = 42;
            // 
            // UserStatsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableStats);
            this.Controls.Add(this.lblWelcome);
            this.Name = "UserStatsControl";
            this.Size = new System.Drawing.Size(500, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblWelcome;
        private System.Windows.Forms.TableLayoutPanel tableStats;
    }
}
