using Caliburn.Micro;
using MHXYTools.View;

namespace MHXYTools.ViewModel {
    public class ShellViewModel : Conductor<IScreen>.Collection.OneActive {
        protected override void OnInitialize()
        {
            base.OnInitialize();
            Items.AddRange(new Screen[] { MainViewModel });
            ActivateItem(MainViewModel);
        }

        public MainViewModel MainViewModel { get; set; }
    }
}