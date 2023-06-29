using UnityEngine;

namespace Platformer.GameManager
{
    public class HardLevelController : MonoBehaviour
    {
        private float survivalSeconds { get; set; }
        
        private int currentHardLevel;

        private void CountSurvivalSeconds()
        {
            
        }

        private void ResetSurvivalSeconds()
        {
            survivalSeconds = 0;
        }

        private void IncreaseHardLevel()
        {
            currentHardLevel += 1;
        }

        public void ResetHardLevel()
        {
            currentHardLevel = 0;
        }
    }
}