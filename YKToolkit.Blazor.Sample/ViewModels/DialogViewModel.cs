namespace YKToolkit.Blazor.Sample.ViewModels
{
    public class DialogViewModel
    {
        public DialogViewModel(IModalService modalService)
        {
            this._modalService = modalService;

            this.TestDialogCommand = new DelegateCommand(_ => TestDialog());
        }

        private async void TestDialog()
        {
            var result = await this._modalService.ShowDialogAsync("メッセージダイアログのテストです。");
        }

        public DelegateCommand TestDialogCommand { get; private set; }

        private IModalService _modalService;
    }
}
