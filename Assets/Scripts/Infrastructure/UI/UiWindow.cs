using UI.UIPanels;
using UnityEngine;

namespace Infrastructure.Level.UI
{
    public class UiWindow: MonoBehaviour
    {
        [SerializeField] private StartPanel startPanel;
        [SerializeField] private SettingsPanel settingsPanel;
        [SerializeField] private GamePanel gamePanel;

        private void Start()
        {
            startPanel.ClickedPanel += OpenSettingsPanel;
            settingsPanel.ClickedPanel += OnPlayGame;
            
            OnStart();
        }

        private void OnStart()
        {
            HideAllPanels();
            startPanel.Show();
        }

        private void OnPlayGame()
        {
            HideAllPanels();
            gamePanel.Show();
        }

        private void OpenSettingsPanel()
        {
            HideAllPanels();
            settingsPanel.Show();
        }
        private void HideAllPanels()
        {
            startPanel.Hide();
            settingsPanel.Hide();
            gamePanel.Hide();
        }

        
    }
}