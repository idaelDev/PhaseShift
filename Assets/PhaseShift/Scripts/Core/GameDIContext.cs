using IdaelDev.DependencyInjection;
using PhaseShift.Configs;
using UnityEngine;

namespace PhaseShift.Core
{
    public class GameDIContext : DIContext
    {

        [SerializeField] private GameSettings gameSettings;

        protected override void ConfigureServices(DIContainer container)
        {
            container.RegisterFactory<PhaseManager>(i  => new PhaseManager(gameSettings),Lifetime.Singleton);
        }
    }
}
