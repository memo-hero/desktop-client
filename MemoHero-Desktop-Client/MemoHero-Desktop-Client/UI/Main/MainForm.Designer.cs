
namespace MemoHeroDesktopClient.UI.MainWindow
{
    partial class MainMenu
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
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnCardEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnCreateCard = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteCard = new DevExpress.XtraBars.BarButtonItem();
            this.btnExport = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageUserStatus = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupUser = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupStudy = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageCards = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupCards = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageBackup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.btnLogOut,
            this.btnCardEdit,
            this.btnCreateCard,
            this.btnDeleteCard,
            this.btnExport,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 9;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageUserStatus,
            this.ribbonPage2,
            this.ribbonPageCards});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(638, 158);
            this.ribbonControl.SelectedPageChanged += new System.EventHandler(this.ribbonControl_SelectedPageChanged);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Caption = "Log Out";
            this.btnLogOut.Id = 1;
            this.btnLogOut.ImageOptions.Image = global::MemoHeroDesktopClient.Properties.Resources.icons8_logout_52;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogOut_ItemClick);
            // 
            // btnCardEdit
            // 
            this.btnCardEdit.Hint = "Edit selected card";
            this.btnCardEdit.Id = 2;
            this.btnCardEdit.ImageOptions.Image = global::MemoHeroDesktopClient.Properties.Resources.edit_card_24;
            this.btnCardEdit.Name = "btnCardEdit";
            this.btnCardEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCardEdit_ItemClick);
            // 
            // btnCreateCard
            // 
            this.btnCreateCard.Hint = "Create Card";
            this.btnCreateCard.Id = 3;
            this.btnCreateCard.ImageOptions.Image = global::MemoHeroDesktopClient.Properties.Resources.new_card_24;
            this.btnCreateCard.Name = "btnCreateCard";
            this.btnCreateCard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateCard_ItemClick);
            // 
            // btnDeleteCard
            // 
            this.btnDeleteCard.Hint = "Delete Card";
            this.btnDeleteCard.Id = 4;
            this.btnDeleteCard.ImageOptions.Image = global::MemoHeroDesktopClient.Properties.Resources.delete_card_24;
            this.btnDeleteCard.Name = "btnDeleteCard";
            // 
            // btnExport
            // 
            this.btnExport.Hint = "Import Backup";
            this.btnExport.Id = 5;
            this.btnExport.ImageOptions.Image = global::MemoHeroDesktopClient.Properties.Resources.import_backup_24_1_;
            this.btnExport.Name = "btnExport";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Hint = "Export Backup";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.ImageOptions.Image = global::MemoHeroDesktopClient.Properties.Resources.download_backup_24;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 8;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // ribbonPageUserStatus
            // 
            this.ribbonPageUserStatus.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPageUserStatus.Appearance.Options.UseFont = true;
            this.ribbonPageUserStatus.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupUser});
            this.ribbonPageUserStatus.Name = "ribbonPageUserStatus";
            this.ribbonPageUserStatus.Text = "User";
            // 
            // ribbonPageGroupUser
            // 
            this.ribbonPageGroupUser.ItemLinks.Add(this.btnLogOut);
            this.ribbonPageGroupUser.Name = "ribbonPageGroupUser";
            this.ribbonPageGroupUser.Text = "ribbonPageGroupUser";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage2.Appearance.Options.UseFont = true;
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupStudy});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Study";
            // 
            // ribbonPageGroupStudy
            // 
            this.ribbonPageGroupStudy.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroupStudy.Name = "ribbonPageGroupStudy";
            this.ribbonPageGroupStudy.Text = "ribbonPageGroupStudy";
            // 
            // ribbonPageCards
            // 
            this.ribbonPageCards.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPageCards.Appearance.Options.UseFont = true;
            this.ribbonPageCards.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupCards,
            this.pageBackup});
            this.ribbonPageCards.Name = "ribbonPageCards";
            this.ribbonPageCards.Text = "Cards";
            // 
            // ribbonPageGroupCards
            // 
            this.ribbonPageGroupCards.ItemLinks.Add(this.btnCreateCard);
            this.ribbonPageGroupCards.ItemLinks.Add(this.btnCardEdit);
            this.ribbonPageGroupCards.ItemLinks.Add(this.btnDeleteCard);
            this.ribbonPageGroupCards.Name = "ribbonPageGroupCards";
            this.ribbonPageGroupCards.Text = "ribbonPageGroupCards";
            // 
            // pageBackup
            // 
            this.pageBackup.ItemLinks.Add(this.btnExport);
            this.pageBackup.ItemLinks.Add(this.barButtonItem1);
            this.pageBackup.Name = "pageBackup";
            this.pageBackup.Text = "Backup";
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 158);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(638, 561);
            this.mainPanel.TabIndex = 26;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 719);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.ribbonControl);
            this.IconOptions.Image = global::MemoHeroDesktopClient.Properties.Resources.Logo;
            this.Name = "MainMenu";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memo Hero";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageUserStatus;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupUser;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCards;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCards;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupStudy;
        private DevExpress.XtraBars.BarButtonItem btnLogOut;
        private DevExpress.XtraBars.BarButtonItem btnCardEdit;
        private DevExpress.XtraBars.BarButtonItem btnCreateCard;
        internal System.Windows.Forms.Panel mainPanel;
        private DevExpress.XtraBars.BarButtonItem btnDeleteCard;
        private DevExpress.XtraBars.BarButtonItem btnExport;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageBackup;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}