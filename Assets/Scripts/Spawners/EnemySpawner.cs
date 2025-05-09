using UnityEngine;

namespace Spawners
{
    public class EnemySpawner<T> : MonoBehaviour where T : Enemy
    {
        public T Create(Unit target, T prefab)
        {
            T enemy = Instantiate(prefab);
            enemy.Init(target);
            enemy.gameObject.SetActive(false);

            return enemy;
        }

        public void Spawn(T enemy, Vector3 position)
        {
            enemy.transform.position = position;

            enemy.gameObject.SetActive(true);
        }
    }
}