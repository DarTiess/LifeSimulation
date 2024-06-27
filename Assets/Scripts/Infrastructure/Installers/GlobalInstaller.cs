using Infrastructure.EventsBus;
using Infrastructure.Level;
using Zenject;

namespace Infrastructure.Installers
{
    public class GlobalInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            CreateEventBus();
            CreateLevelLoader();
        }
        
        private void CreateEventBus()
        {
            Container.BindInterfacesAndSelfTo<EventBus>().AsSingle();
        }
    
        private void CreateLevelLoader()
        {
            Container.BindInterfacesAndSelfTo<LevelLoader>().AsSingle();
        }
    }
}
