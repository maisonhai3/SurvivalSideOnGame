using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Platformer.GameManager
{
    public class EnemyGenerator : MonoBehaviour
    {
        [SerializeField] private GameObject enemyPrefab;
        [SerializeField] private GameObject worldConfinement;
        
        private int limitNumber;

        private float minX; private float maxX;
        private float minY; private float maxY;

        private enum enemyTypes
        {
            MELEE,
            RANGE_GROUND,
            RANGE_FLYING
        }

        private void OnEnable()
        {
            // Should be refactored after PoC
            GetConfinerValues();
            GenerateEnemy();
        }

        public void GenerateEnemy()
        {
            for (var i = 0; i <= 10; i++)
            {
                var randomPosition = RandomizePosition();
                var enemy = Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
            }
        }

        private Vector3 RandomizePosition()
        {
            var randomX = Random.Range(minX, maxX);
            var randomY = Random.Range(minY, maxY);
            var randomPosition = new Vector3(randomX, randomY, 1);
            return randomPosition;
        }

        private enemyTypes RandomizeType()
        {
            return enemyTypes.MELEE;
        }

        private void GetConfinerValues()
        {
            BoxCollider2D collider = worldConfinement.GetComponent<BoxCollider2D>();    		
		
            maxY = collider.offset.y + (collider.size.y / 2f);
            minY = collider.offset.y - (collider.size.y / 2f);
            minX = collider.offset.x - (collider.size.x / 2f);
            maxX = collider.offset.x + (collider.size.x /2f);
        }
    }
}