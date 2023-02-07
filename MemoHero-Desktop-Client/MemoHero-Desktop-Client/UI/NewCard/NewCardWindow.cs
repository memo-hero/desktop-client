using ClientBack.Domain.Cards;
using DevExpress.XtraEditors;
using MemoHeroDesktopClient.Common;
using MemoHeroDesktopClient.CustomControls;

namespace MemoHeroDesktopClient.UI.NewCard
{
    public partial class NewCardWindow : XtraForm
    {
        internal delegate void CreateCardHandler(object source, CreateCardArgs args);
        internal event CreateCardHandler CardCreated;
        private readonly CardFormControl cardFormControl = new CardFormControl();

        public NewCardWindow()
        {
            InitializeComponent();
            createPanel.Controls.Add(cardFormControl);
        }

        protected virtual void OnCardCreated(Card card) => CardCreated(this, new CreateCardArgs(card));

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            var result = cardFormControl.GetNewCard();
            if (result == null) return;
            OnCardCreated(result);
            cardFormControl.ClearForm();
        }
    }
}