
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
            this.btnStudy = new DevExpress.XtraBars.BarButtonItem();
            this.btnServerSync = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageUserStatus = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupUser = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageStudy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupStudy = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageCards = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupServer = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.btnStudy,
            this.btnServerSync});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 10;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageUserStatus,
            this.ribbonPageStudy,
            this.ribbonPageCards});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(638, 158);
            this.ribbonControl.SelectedPageChanged += new System.EventHandler(this.ribbonControl_SelectedPageChanged);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Caption = "Log out";
            this.btnLogOut.Id = 1;
            this.btnLogOut.ImageOptions.Image = global::MemoHeroDesktopClient.Properties.Resources.logout_32;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogOut_ItemClick);
            // 
            // btnCardEdit
            // 
            this.btnCardEdit.Caption = "Edit selected card";
            this.btnCardEdit.Id = 2;
            this.btnCardEdit.ImageOptions.Image = global::MemoHeroDesktopClient.Properties.Resources.card_edit_52;
            this.btnCardEdit.Name = "btnCardEdit";
            this.btnCardEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnCardEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCardEdit_ItemClick);
            // 
            // btnCreateCard
            // 
            this.btnCreateCard.Caption = "Create new card";
            this.btnCreateCard.Hint = "Create Card";
            this.btnCreateCard.Id = 3;
            this.btnCreateCard.ImageOptions.Image = global::MemoHeroDesktopClient.Properties.Resources.card_create_32;
            this.btnCreateCard.ImageOptions.LargeImage = global::MemoHeroDesktopClient.Properties.Resources.card_create_52;
            this.btnCreateCard.Name = "btnCreateCard";
            this.btnCreateCard.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnCreateCard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateCard_ItemClick);
            // 
            // btnDeleteCard
            // 
            this.btnDeleteCard.Caption = "Delete selected card";
            this.btnDeleteCard.Hint = "Delete Card";
            this.btnDeleteCard.Id = 4;
            this.btnDeleteCard.ImageOptions.Image = global::MemoHeroDesktopClient.Properties.Resources.card_delete_52;
            this.btnDeleteCard.Name = "btnDeleteCard";
            this.btnDeleteCard.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDeleteCard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteCard_ItemClick);
            // 
            // btnExport
            // 
            this.btnExport.Caption = "Import Collection";
            this.btnExport.Hint = "Import Backup";
            this.btnExport.Id = 5;
            this.btnExport.ImageOptions.Image = global::MemoHeroDesktopClient.Properties.Resources.import_32;
            this.btnExport.Name = "btnExport";
            this.btnExport.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Export Collection";
            this.barButtonItem1.Hint = "Export Backup";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.ImageOptions.Image = global::MemoHeroDesktopClient.Properties.Resources.export_32;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnStudy
            // 
            this.btnStudy.Caption = "Study Cards";
            this.btnStudy.Id = 8;
            this.btnStudy.ImageOptions.Image = global::MemoHeroDesktopClient.Properties.Resources.study_32;
            this.btnStudy.Name = "btnStudy";
            this.btnStudy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnStudy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStudy_ItemClick);
            // 
            // btnServerSync
            // 
            this.btnServerSync.Caption = "Sync with server";
            this.btnServerSync.Id = 9;
            this.btnServerSync.ImageOptions.Image = global::MemoHeroDesktopClient.Properties.Resources.sync_32;
            this.btnServerSync.Name = "btnServerSync";
            this.btnServerSync.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnServerSync.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnServerSync_ItemClick);
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
            this.ribbonPageGroupUser.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroupUser.ItemLinks.Add(this.btnLogOut);
            this.ribbonPageGroupUser.Name = "ribbonPageGroupUser";
            // 
            // ribbonPageStudy
            // 
            this.ribbonPageStudy.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPageStudy.Appearance.Options.UseFont = true;
            this.ribbonPageStudy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupStudy});
            this.ribbonPageStudy.Name = "ribbonPageStudy";
            this.ribbonPageStudy.Text = "Study";
            // 
            // ribbonPageGroupStudy
            // 
            this.ribbonPageGroupStudy.ItemLinks.Add(this.btnStudy);
            this.ribbonPageGroupStudy.Name = "ribbonPageGroupStudy";
            this.ribbonPageGroupStudy.Text = "Study";
            // 
            // ribbonPageCards
            // 
            this.ribbonPageCards.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPageCards.Appearance.Options.UseFont = true;
            this.ribbonPageCards.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupServer,
            this.ribbonPageGroupCards,
            this.pageBackup});
            this.ribbonPageCards.Name = "ribbonPageCards";
            this.ribbonPageCards.Text = "Cards";
            // 
            // ribbonPageGroupServer
            // 
            this.ribbonPageGroupServer.ItemLinks.Add(this.btnServerSync);
            this.ribbonPageGroupServer.Name = "ribbonPageGroupServer";
            this.ribbonPageGroupServer.Text = "Server";
            // 
            // ribbonPageGroupCards
            // 
            this.ribbonPageGroupCards.ItemLinks.Add(this.btnCreateCard);
            this.ribbonPageGroupCards.ItemLinks.Add(this.btnCardEdit);
            this.ribbonPageGroupCards.ItemLinks.Add(this.btnDeleteCard);
            this.ribbonPageGroupCards.Name = "ribbonPageGroupCards";
            this.ribbonPageGroupCards.Text = "Cards Management";
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
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageStudy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupStudy;
        private DevExpress.XtraBars.BarButtonItem btnLogOut;
        private DevExpress.XtraBars.BarButtonItem btnCardEdit;
        private DevExpress.XtraBars.BarButtonItem btnCreateCard;
        internal System.Windows.Forms.Panel mainPanel;
        private DevExpress.XtraBars.BarButtonItem btnDeleteCard;
        private DevExpress.XtraBars.BarButtonItem btnExport;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageBackup;
        private DevExpress.XtraBars.BarButtonItem btnStudy;
        private DevExpress.XtraBars.BarButtonItem btnServerSync;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupServer;
    }
}