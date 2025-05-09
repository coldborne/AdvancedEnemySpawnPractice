using Spawners;
using UnityEngine;

namespace SpawnPoints
{
    public class EnemySpawnPoint<T> : MonoBehaviour, ISpawnPoint where T : Enemy
    {
        [SerializeField] private EnemySpawner<T> _enemySpawner;
        [SerializeField] private T _enemyPrefab;
        [SerializeField] private Unit[] _targets;

        public void Spawn()
        {
            Unit target = _targets[Random.Range(0, _targets.Length)];
            T enemy = _enemySpawner.Create(target, _enemyPrefab);
            _enemySpawner.Spawn(enemy, transform.position);
        }
    }
}