using System.Threading.Tasks;
using Infrastructure.EventsBus;
using Infrastructure.EventsBus.Signals;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Infrastructure.Level
{
    public class LevelLoader 
    {
        private readonly LevelSettings _settings;
        private readonly IEventBus _eventBus;

        public int NumLevel
        {
            get { return PlayerPrefs.GetInt("NumLevel"); }
            set { PlayerPrefs.SetInt("NumLevel", value); }
        }

        public int NumScene
        {                    
            get { return PlayerPrefs.GetInt("NumScene"); }
            set { PlayerPrefs.SetInt("NumScene", value); }
        }

        public LevelLoader(LevelSettings settings, IEventBus eventBus)
        {
            _settings = settings;
            _eventBus = eventBus;
            
            _eventBus.Subscribe<LevelStart>(StartGame);
            _eventBus.Subscribe<NextLevel>(LoadNextLevel);
            _eventBus.Subscribe<RestartGame>(RestartScene);
        }

        private void StartGame(LevelStart obj)
        {
           LoadScene();    
        }

        private void LoadNextLevel(NextLevel obj)
        {
            NumLevel += 1;
            NumScene += 1;
        
            LoadScene();   
        }

        private void LoadScene()
        {
            int numLoadedScene = NumScene;
            if (numLoadedScene <= _settings.NameScene.Count){numLoadedScene -= 1;}
            if (numLoadedScene > _settings.NameScene.Count){numLoadedScene = (numLoadedScene - 1) % _settings.NameScene.Count;}
            Debug.Log("Load Scene Number " + numLoadedScene + "Level Number " + NumLevel);

            SceneManager.LoadScene(_settings.NameScene[numLoadedScene]);
        }

        private void RestartScene(RestartGame obj)
        {
            Restart();
        }

        private async Task Restart()
        {
            await Task.Delay(1000);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
