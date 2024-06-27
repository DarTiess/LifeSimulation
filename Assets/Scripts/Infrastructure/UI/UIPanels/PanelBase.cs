using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI.UIPanels
{
    public abstract class PanelBase : MonoBehaviour
    {
        [SerializeField] private Button _button;
        public virtual event Action ClickedPanel;

        private void Start()
        {
            if(_button!=null)
            _button.onClick.AddListener(OnClickedPanel);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        public void Show()
        {
            gameObject.SetActive(true);
        }

        protected virtual void OnClickedPanel()
        {
          
        }
    }
}