using System.Collections.Generic;
using UnityEngine;

namespace Infrastructure.Level
{
    [System.Serializable]
    public class LevelSettings
    {
        [SerializeField] private List<string> nameScene;
        public List<string> NameScene => nameScene;
    }
}