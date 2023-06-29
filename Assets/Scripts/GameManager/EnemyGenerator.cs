using UnityEngine;

namespace Platformer.GameManager
{
    public class EnemyGenerator : MonoBehaviour
    {
        private int limitNumber;

        private enum enemyTypes
        {
            MELEE,
            RANGE_GROUND,
            RANGE_FLYING
        }

        public void GenerateEnemy()
        {
            
        }

        private Vector2 RandomizePosition()
        {
            return Vector2.one;
        }

        private enemyTypes RandomizeType()
        {
            return enemyTypes.MELEE;
        }
    }
}