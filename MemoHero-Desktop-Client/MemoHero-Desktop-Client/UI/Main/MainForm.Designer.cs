
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnCardEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnCreateCard = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteCard = new DevExpress.XtraBars.BarButtonItem();
            this.btnImport = new DevExpress.XtraBars.BarButtonItem();
            this.btnExport = new DevExpress.XtraBars.BarButtonItem();
            this.btnStudy = new DevExpress.XtraBars.BarButtonItem();
            this.btnServerSync = new DevExpress.XtraBars.BarButtonItem();
            this.btnAbout = new DevExpress.XtraBars.BarButtonItem();
            this.barItemLanguage = new DevExpress.XtraBars.BarSubItem();
            this.btnSetLanguageEnglish = new DevExpress.XtraBars.BarButtonItem();
            this.btnSetLanguageSpanish = new DevExpress.XtraBars.BarButtonItem();
            this.pageUserStatus = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pageGroupUser = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageGroupConfiguration = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageStudy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pageGroupStudy = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageCards = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pageGroupServer = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageGroupCards = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageGroupBackup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
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
            this.btnImport,
            this.btnExport,
            this.btnStudy,
            this.btnServerSync,
            this.btnAbout,
            this.barItemLanguage,
            this.btnSetLanguageEnglish,
            this.btnSetLanguageSpanish});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 15;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pageUserStatus,
            this.pageStudy,
            this.pageCards});
            this.ribbonControl.QuickToolbarItemLinks.Add(this.btnAbout);
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
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
            this.btnLogOut.Tag = true;
            this.btnLogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogOut_ItemClick);
            // 
            // btnCardEdit
            // 
            this.btnCardEdit.Caption = "Edit selected card";
            this.btnCardEdit.Id = 2;
            this.btnCardEdit.ImageOptions.Image = global::MemoHeroDesktopClient.Properties.Resources.card_edit_52;
            this.btnCardEdit.Name = "btnCardEdit";
            this.btnCardEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnCardEdit.Tag = true;
            this.btnCardEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCardEdit_ItemClick);
            // 
            // btnCreateCard
            // 
            this.btnCreateCard.Caption = "Create new card";
            this.btnCreateCard.Hint = "Create Card";
            this.btnCreateCard.Id = 3;
            this.btnCreateCard.ImageOptions.Image = global::MemoHeroDesktopClient.Properties.Resources.card_create_32;
            this.btnCreateCard.Name = "btnCreateCard";
            this.btnCreateCard.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnCreateCard.Tag = true;
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
            this.btnDeleteCard.Tag = true;
            this.btnDeleteCard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteCard_ItemClick);
            // 
            // btnImport
            // 
            this.btnImport.Caption = "Import Collection";
            this.btnImport.Hint = "Import Backup";
            this.btnImport.Id = 5;
            this.btnImport.ImageOptions.Image = global::MemoHeroDesktopClient.Properties.Resources.import_32;
            this.btnImport.Name = "btnImport";
            this.btnImport.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnImport.Tag = true;
            this.btnImport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnImport_ItemClick);
            // 
            // btnExport
            // 
            this.btnExport.Caption = "Export Collection";
            this.btnExport.Hint = "Export Backup";
            this.btnExport.Id = 6;
            this.btnExport.ImageOptions.Image = global::MemoHeroDesktopClient.Properties.Resources.export_32;
            this.btnExport.Name = "btnExport";
            this.btnExport.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnExport.Tag = true;
            this.btnExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExport_ItemClick);
            // 
            // btnStudy
            // 
            this.btnStudy.Caption = "Study Cards";
            this.btnStudy.Id = 8;
            this.btnStudy.ImageOptions.Image = global::MemoHeroDesktopClient.Properties.Resources.study_32;
            this.btnStudy.Name = "btnStudy";
            this.btnStudy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnStudy.Tag = true;
            this.btnStudy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStudy_ItemClick);
            // 
            // btnServerSync
            // 
            this.btnServerSync.Caption = "Sync with server";
            this.btnServerSync.Id = 9;
            this.btnServerSync.ImageOptions.Image = global::MemoHeroDesktopClient.Properties.Resources.sync_32;
            this.btnServerSync.Name = "btnServerSync";
            this.btnServerSync.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnServerSync.Tag = true;
            this.btnServerSync.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnServerSync_ItemClick);
            // 
            // btnAbout
            // 
            this.btnAbout.Hint = "About";
            this.btnAbout.Id = 10;
            this.btnAbout.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAbout.ImageOptions.SvgImage")));
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAbout_ItemClick);
            // 
            // barItemLanguage
            // 
            this.barItemLanguage.Caption = "Change Language";
            this.barItemLanguage.Id = 12;
            this.barItemLanguage.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSetLanguageEnglish),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSetLanguageSpanish)});
            this.barItemLanguage.Name = "barItemLanguage";
            // 
            // btnSetLanguageEnglish
            // 
            this.btnSetLanguageEnglish.Caption = "English";
            this.btnSetLanguageEnglish.Id = 13;
            this.btnSetLanguageEnglish.Name = "btnSetLanguageEnglish";
            this.btnSetLanguageEnglish.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSetLanguageEnglish_ItemClick);
            // 
            // btnSetLanguageSpanish
            // 
            this.btnSetLanguageSpanish.Caption = "Español";
            this.btnSetLanguageSpanish.Id = 14;
            this.btnSetLanguageSpanish.Name = "btnSetLanguageSpanish";
            this.btnSetLanguageSpanish.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSetLanguageSpanish_ItemClick);
            // 
            // pageUserStatus
            // 
            this.pageUserStatus.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageUserStatus.Appearance.Options.UseFont = true;
            this.pageUserStatus.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pageGroupUser,
            this.pageGroupConfiguration});
            this.pageUserStatus.Name = "pageUserStatus";
            this.pageUserStatus.Text = "User";
            // 
            // pageGroupUser
            // 
            this.pageGroupUser.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.pageGroupUser.ItemLinks.Add(this.btnLogOut);
            this.pageGroupUser.Name = "pageGroupUser";
            // 
            // pageGroupConfiguration
            // 
            this.pageGroupConfiguration.ItemLinks.Add(this.barItemLanguage);
            this.pageGroupConfiguration.Name = "pageGroupConfiguration";
            this.pageGroupConfiguration.Text = "Configuration";
            // 
            // pageStudy
            // 
            this.pageStudy.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageStudy.Appearance.Options.UseFont = true;
            this.pageStudy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pageGroupStudy});
            this.pageStudy.Name = "pageStudy";
            this.pageStudy.Text = "Study";
            // 
            // pageGroupStudy
            // 
            this.pageGroupStudy.ItemLinks.Add(this.btnStudy);
            this.pageGroupStudy.Name = "pageGroupStudy";
            this.pageGroupStudy.Text = "Study";
            // 
            // pageCards
            // 
            this.pageCards.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageCards.Appearance.Options.UseFont = true;
            this.pageCards.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pageGroupServer,
            this.pageGroupCards,
            this.pageGroupBackup});
            this.pageCards.Name = "pageCards";
            this.pageCards.Text = "Cards";
            // 
            // pageGroupServer
            // 
            this.pageGroupServer.ItemLinks.Add(this.btnServerSync);
            this.pageGroupServer.Name = "pageGroupServer";
            this.pageGroupServer.Text = "Server";
            // 
            // pageGroupCards
            // 
            this.pageGroupCards.ItemLinks.Add(this.btnCreateCard);
            this.pageGroupCards.ItemLinks.Add(this.btnCardEdit);
            this.pageGroupCards.ItemLinks.Add(this.btnDeleteCard);
            this.pageGroupCards.Name = "pageGroupCards";
            this.pageGroupCards.Text = "Cards Management";
            // 
            // pageGroupBackup
            // 
            this.pageGroupBackup.ItemLinks.Add(this.btnImport);
            this.pageGroupBackup.ItemLinks.Add(this.btnExport);
            this.pageGroupBackup.Name = "pageGroupBackup";
            this.pageGroupBackup.Text = "Backup";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "English",
            "Español"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
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
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MainMenu.IconOptions.Icon")));
            this.IconOptions.Image = global::MemoHeroDesktopClient.Properties.Resources.Logo;
            this.Name = "MainMenu";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memo Hero";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageUserStatus;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageGroupUser;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageCards;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageGroupCards;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageStudy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageGroupStudy;
        private DevExpress.XtraBars.BarButtonItem btnLogOut;
        private DevExpress.XtraBars.BarButtonItem btnCardEdit;
        private DevExpress.XtraBars.BarButtonItem btnCreateCard;
        internal System.Windows.Forms.Panel mainPanel;
        private DevExpress.XtraBars.BarButtonItem btnDeleteCard;
        private DevExpress.XtraBars.BarButtonItem btnImport;
        private DevExpress.XtraBars.BarButtonItem btnExport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageGroupBackup;
        private DevExpress.XtraBars.BarButtonItem btnStudy;
        private DevExpress.XtraBars.BarButtonItem btnServerSync;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageGroupServer;
        private DevExpress.XtraBars.BarButtonItem btnAbout;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageGroupConfiguration;
        private DevExpress.XtraBars.BarSubItem barItemLanguage;
        private DevExpress.XtraBars.BarButtonItem btnSetLanguageEnglish;
        private DevExpress.XtraBars.BarButtonItem btnSetLanguageSpanish;
    }
}