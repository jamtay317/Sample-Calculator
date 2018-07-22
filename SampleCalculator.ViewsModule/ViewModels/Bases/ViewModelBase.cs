using Prism.Mvvm;

namespace SampleCalculator.ViewsModule.ViewModels.Bases
{
    public abstract class ViewModelBase:BindableBase
    {
        protected ViewModelBase()
        {
            RegisterCollections();
            RegisterCommands();
        }

        public virtual void RegisterCollections() { }
        public virtual void RegisterCommands() { }
    }
}