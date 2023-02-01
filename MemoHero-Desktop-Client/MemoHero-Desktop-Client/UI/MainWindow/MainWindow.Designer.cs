
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
            this.lblWelcome = new DevExpress.XtraEditors.LabelControl();
            this.gridCards = new DevExpress.XtraGrid.GridControl();
            this.gridViewCards = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnNewCard = new DevExpress.XtraEditors.SimpleButton();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageUserStatus = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.expArts = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblArts = new DevExpress.XtraEditors.LabelControl();
            this.lblArtsLevel = new DevExpress.XtraEditors.LabelControl();
            this.lblComputersLevel = new DevExpress.XtraEditors.LabelControl();
            this.lblComputers = new DevExpress.XtraEditors.LabelControl();
            this.expComputers = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblHistoryLevel = new DevExpress.XtraEditors.LabelControl();
            this.lblHistory = new DevExpress.XtraEditors.LabelControl();
            this.expHistory = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblLanguagesLevel = new DevExpress.XtraEditors.LabelControl();
            this.lblLanguages = new DevExpress.XtraEditors.LabelControl();
            this.expLanguages = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblScienceLevel = new DevExpress.XtraEditors.LabelControl();
            this.lblScience = new DevExpress.XtraEditors.LabelControl();
            this.expScience = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblDueCardsCount = new DevExpress.XtraEditors.LabelControl();
            this.btnCardEdit = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expArts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expComputers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expHistory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expLanguages.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expScience.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Appearance.Options.UseFont = true;
            this.lblWelcome.Location = new System.Drawing.Point(12, 63);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(161, 39);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "lblWelcome";
            // 
            // gridCards
            // 
            this.gridCards.Location = new System.Drawing.Point(676, 63);
            this.gridCards.MainView = this.gridViewCards;
            this.gridCards.Name = "gridCards";
            this.gridCards.Size = new System.Drawing.Size(590, 613);
            this.gridCards.TabIndex = 1;
            this.gridCards.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCards});
            this.gridCards.DoubleClick += new System.EventHandler(this.gridCards_DoubleClick);
            // 
            // gridViewCards
            // 
            this.gridViewCards.GridControl = this.gridCards;
            this.gridViewCards.Name = "gridViewCards";
            this.gridViewCards.OptionsBehavior.ReadOnly = true;
            // 
            // btnNewCard
            // 
            this.btnNewCard.Location = new System.Drawing.Point(542, 79);
            this.btnNewCard.Name = "btnNewCard";
            this.btnNewCard.Size = new System.Drawing.Size(75, 23);
            this.btnNewCard.TabIndex = 2;
            this.btnNewCard.Text = "Create New Card";
            this.btnNewCard.Click += new System.EventHandler(this.btnNewCard_Click);
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.btnLogOut,
            this.btnCardEdit});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 3;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageUserStatus,
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl.Size = new System.Drawing.Size(1278, 57);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Caption = "Log Out";
            this.btnLogOut.Id = 1;
            this.btnLogOut.ImageOptions.Image = global::MemoHeroDesktopClient.Properties.Resources.icons8_logout_52;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogOut_ItemClick);
            // 
            // ribbonPageUserStatus
            // 
            this.ribbonPageUserStatus.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPageUserStatus.Name = "ribbonPageUserStatus";
            this.ribbonPageUserStatus.Text = "User";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogOut);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Cards";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCardEdit);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Study";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // expArts
            // 
            this.expArts.Location = new System.Drawing.Point(25, 222);
            this.expArts.MenuManager = this.ribbonControl;
            this.expArts.Name = "expArts";
            this.expArts.Size = new System.Drawing.Size(296, 18);
            this.expArts.TabIndex = 3;
            // 
            // lblArts
            // 
            this.lblArts.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArts.Appearance.Options.UseFont = true;
            this.lblArts.Location = new System.Drawing.Point(25, 187);
            this.lblArts.Name = "lblArts";
            this.lblArts.Size = new System.Drawing.Size(65, 29);
            this.lblArts.TabIndex = 4;
            this.lblArts.Text = "lblArts";
            // 
            // lblArtsLevel
            // 
            this.lblArtsLevel.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtsLevel.Appearance.Options.UseFont = true;
            this.lblArtsLevel.Location = new System.Drawing.Point(327, 217);
            this.lblArtsLevel.Name = "lblArtsLevel";
            this.lblArtsLevel.Size = new System.Drawing.Size(93, 23);
            this.lblArtsLevel.TabIndex = 5;
            this.lblArtsLevel.Text = "lblArtsLevel";
            // 
            // lblComputersLevel
            // 
            this.lblComputersLevel.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputersLevel.Appearance.Options.UseFont = true;
            this.lblComputersLevel.Location = new System.Drawing.Point(327, 301);
            this.lblComputersLevel.Name = "lblComputersLevel";
            this.lblComputersLevel.Size = new System.Drawing.Size(151, 23);
            this.lblComputersLevel.TabIndex = 12;
            this.lblComputersLevel.Text = "lblComputersLevel";
            // 
            // lblComputers
            // 
            this.lblComputers.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputers.Appearance.Options.UseFont = true;
            this.lblComputers.Location = new System.Drawing.Point(25, 271);
            this.lblComputers.Name = "lblComputers";
            this.lblComputers.Size = new System.Drawing.Size(137, 29);
            this.lblComputers.TabIndex = 11;
            this.lblComputers.Text = "lblComputers";
            // 
            // expComputers
            // 
            this.expComputers.Location = new System.Drawing.Point(25, 306);
            this.expComputers.MenuManager = this.ribbonControl;
            this.expComputers.Name = "expComputers";
            this.expComputers.Size = new System.Drawing.Size(296, 18);
            this.expComputers.TabIndex = 10;
            // 
            // lblHistoryLevel
            // 
            this.lblHistoryLevel.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryLevel.Appearance.Options.UseFont = true;
            this.lblHistoryLevel.Location = new System.Drawing.Point(327, 385);
            this.lblHistoryLevel.Name = "lblHistoryLevel";
            this.lblHistoryLevel.Size = new System.Drawing.Size(118, 23);
            this.lblHistoryLevel.TabIndex = 15;
            this.lblHistoryLevel.Text = "lblHistoryLevel";
            // 
            // lblHistory
            // 
            this.lblHistory.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.Appearance.Options.UseFont = true;
            this.lblHistory.Location = new System.Drawing.Point(25, 355);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(97, 29);
            this.lblHistory.TabIndex = 14;
            this.lblHistory.Text = "lblHistory";
            // 
            // expHistory
            // 
            this.expHistory.Location = new System.Drawing.Point(25, 390);
            this.expHistory.MenuManager = this.ribbonControl;
            this.expHistory.Name = "expHistory";
            this.expHistory.Size = new System.Drawing.Size(296, 18);
            this.expHistory.TabIndex = 13;
            // 
            // lblLanguagesLevel
            // 
            this.lblLanguagesLevel.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguagesLevel.Appearance.Options.UseFont = true;
            this.lblLanguagesLevel.Location = new System.Drawing.Point(327, 469);
            this.lblLanguagesLevel.Name = "lblLanguagesLevel";
            this.lblLanguagesLevel.Size = new System.Drawing.Size(152, 23);
            this.lblLanguagesLevel.TabIndex = 18;
            this.lblLanguagesLevel.Text = "lblLanguagesLevel";
            // 
            // lblLanguages
            // 
            this.lblLanguages.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguages.Appearance.Options.UseFont = true;
            this.lblLanguages.Location = new System.Drawing.Point(25, 439);
            this.lblLanguages.Name = "lblLanguages";
            this.lblLanguages.Size = new System.Drawing.Size(137, 29);
            this.lblLanguages.TabIndex = 17;
            this.lblLanguages.Text = "lblLanguages";
            // 
            // expLanguages
            // 
            this.expLanguages.Location = new System.Drawing.Point(25, 474);
            this.expLanguages.MenuManager = this.ribbonControl;
            this.expLanguages.Name = "expLanguages";
            this.expLanguages.Size = new System.Drawing.Size(296, 18);
            this.expLanguages.TabIndex = 16;
            // 
            // lblScienceLevel
            // 
            this.lblScienceLevel.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScienceLevel.Appearance.Options.UseFont = true;
            this.lblScienceLevel.Location = new System.Drawing.Point(327, 553);
            this.lblScienceLevel.Name = "lblScienceLevel";
            this.lblScienceLevel.Size = new System.Drawing.Size(125, 23);
            this.lblScienceLevel.TabIndex = 21;
            this.lblScienceLevel.Text = "lblScienceLevel";
            // 
            // lblScience
            // 
            this.lblScience.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScience.Appearance.Options.UseFont = true;
            this.lblScience.Location = new System.Drawing.Point(25, 523);
            this.lblScience.Name = "lblScience";
            this.lblScience.Size = new System.Drawing.Size(102, 29);
            this.lblScience.TabIndex = 20;
            this.lblScience.Text = "lblScience";
            // 
            // expScience
            // 
            this.expScience.Location = new System.Drawing.Point(25, 558);
            this.expScience.MenuManager = this.ribbonControl;
            this.expScience.Name = "expScience";
            this.expScience.Size = new System.Drawing.Size(296, 18);
            this.expScience.TabIndex = 19;
            // 
            // lblDueCardsCount
            // 
            this.lblDueCardsCount.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueCardsCount.Appearance.Options.UseFont = true;
            this.lblDueCardsCount.Location = new System.Drawing.Point(12, 108);
            this.lblDueCardsCount.Name = "lblDueCardsCount";
            this.lblDueCardsCount.Size = new System.Drawing.Size(156, 33);
            this.lblDueCardsCount.TabIndex = 24;
            this.lblDueCardsCount.Text = "labelControl1";
            // 
            // btnCardEdit
            // 
            this.btnCardEdit.Caption = "Edit Selected Card";
            this.btnCardEdit.Id = 2;
            this.btnCardEdit.Name = "btnCardEdit";
            this.btnCardEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCardEdit_ItemClick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 688);
            this.Controls.Add(this.lblDueCardsCount);
            this.Controls.Add(this.lblScienceLevel);
            this.Controls.Add(this.lblScience);
            this.Controls.Add(this.expScience);
            this.Controls.Add(this.lblLanguagesLevel);
            this.Controls.Add(this.lblLanguages);
            this.Controls.Add(this.expLanguages);
            this.Controls.Add(this.lblHistoryLevel);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.expHistory);
            this.Controls.Add(this.lblComputersLevel);
            this.Controls.Add(this.lblComputers);
            this.Controls.Add(this.expComputers);
            this.Controls.Add(this.lblArtsLevel);
            this.Controls.Add(this.lblArts);
            this.Controls.Add(this.expArts);
            this.Controls.Add(this.ribbonControl);
            this.Controls.Add(this.btnNewCard);
            this.Controls.Add(this.gridCards);
            this.Controls.Add(this.lblWelcome);
            this.IconOptions.Image = global::MemoHeroDesktopClient.Properties.Resources.Logo;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expArts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expComputers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expHistory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expLanguages.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expScience.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblWelcome;
        private DevExpress.XtraGrid.GridControl gridCards;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCards;
        private DevExpress.XtraEditors.SimpleButton btnNewCard;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageUserStatus;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnLogOut;
        private DevExpress.XtraEditors.ProgressBarControl expArts;
        private DevExpress.XtraEditors.LabelControl lblArts;
        private DevExpress.XtraEditors.LabelControl lblArtsLevel;
        private DevExpress.XtraEditors.LabelControl lblComputersLevel;
        private DevExpress.XtraEditors.LabelControl lblComputers;
        private DevExpress.XtraEditors.ProgressBarControl expComputers;
        private DevExpress.XtraEditors.LabelControl lblHistoryLevel;
        private DevExpress.XtraEditors.LabelControl lblHistory;
        private DevExpress.XtraEditors.ProgressBarControl expHistory;
        private DevExpress.XtraEditors.LabelControl lblLanguagesLevel;
        private DevExpress.XtraEditors.LabelControl lblLanguages;
        private DevExpress.XtraEditors.ProgressBarControl expLanguages;
        private DevExpress.XtraEditors.LabelControl lblScienceLevel;
        private DevExpress.XtraEditors.LabelControl lblScience;
        private DevExpress.XtraEditors.ProgressBarControl expScience;
        private DevExpress.XtraEditors.LabelControl lblDueCardsCount;
        private DevExpress.XtraBars.BarButtonItem btnCardEdit;
    }
}