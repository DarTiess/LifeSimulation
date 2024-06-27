using Infrastructure.EventsBus;
using Infrastructure.EventsBus.Signals;
using UnityEngine;
using Zenject;


namespace Infrastructure.Level
{
    public class Bootstrap : MonoBehaviour
    {
        private LevelLoader _levelLoader;

        [Inject]
        public void Construct(LevelLoader levelLoader)
        {
            _levelLoader = levelLoader;
        }

    }
}
