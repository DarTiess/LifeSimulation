using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI.UIPanels
{
    public class SettingsPanel: PanelBase
    {
        [Header("Plane Size")]
        [SerializeField] private Text minPlaneSize;
        [SerializeField] private Text maxPlaneSize;
        [SerializeField] private Slider planeSlider;
        [Header("Animal Amount")]
        [SerializeField] private Text animalCount;
        [SerializeField] private Slider animalSlider;
        [Header("Speed Settings")]
        [SerializeField] private Text minSpeed;
        [SerializeField] private Text maxSpeed;
        [SerializeField] private Slider speedSlider;

        public override event Action ClickedPanel;
        protected override void OnClickedPanel()
        {
           ClickedPanel?.Invoke();
        }
    }
}