using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI.UIPanels
{
    public class StartPanel : PanelBase
    {
        [SerializeField] private Button continueButton;
        public override event Action ClickedPanel;

        protected override void OnClickedPanel()
        {
           ClickedPanel?.Invoke();
        }
    }
}