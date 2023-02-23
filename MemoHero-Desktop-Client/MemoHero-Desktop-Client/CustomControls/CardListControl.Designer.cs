
namespace MemoHeroDesktopClient.CustomControls
{
    partial class CardListControl
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
            this.gridCards = new DevExpress.XtraGrid.GridControl();
            this.gridViewCards = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCards)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCards
            // 
            this.gridCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCards.Location = new System.Drawing.Point(0, 0);
            this.gridCards.MainView = this.gridViewCards;
            this.gridCards.Name = "gridCards";
            this.gridCards.Size = new System.Drawing.Size(500, 500);
            this.gridCards.TabIndex = 2;
            this.gridCards.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCards});
            // 
            // gridViewCards
            // 
            this.gridViewCards.GridControl = this.gridCards;
            this.gridViewCards.Name = "gridViewCards";
            this.gridViewCards.OptionsBehavior.ReadOnly = true;
            // 
            // CardListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridCards);
            this.Name = "CardListControl";
            this.Size = new System.Drawing.Size(500, 500);
            ((System.ComponentModel.ISupportInitialize)(this.gridCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCards)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCards;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCards;
    }
}
