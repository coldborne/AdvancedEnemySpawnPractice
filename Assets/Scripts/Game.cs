using System.Collections;
using SpawnPoints;
using UnityEngine;
using Random = UnityEngine.Random;

public class Game : MonoBehaviour
{
    [SerializeField] private WarriorSpawnPoint[] _warriorSpawnPoints;
    [SerializeField] private ArcherSpawnPoint[] _archerSpawnPoints;

    private ISpawnPoint[] _spawnPoints;

    private WaitForSeconds _waitForSeconds;

    private bool _isSpawning;
    private int _delay;

    private void Awake()
    {
        int totalSpawnPointCount = _warriorSpawnPoints.Length + _archerSpawnPoints.Length;
        _spawnPoints = new ISpawnPoint[totalSpawnPointCount];

        int index = 0;

        foreach (WarriorSpawnPoint warriorSpawnPoint in _warriorSpawnPoints)
        {
            _spawnPoints[index++] = warriorSpawnPoint;
        }

        foreach (ArcherSpawnPoint archerSpawnPoint in _archerSpawnPoints)
        {
            _spawnPoints[index++] = archerSpawnPoint;
        }

        _isSpawning = true;
        _delay = 2;

        _waitForSeconds = new WaitForSeconds(_delay);
    }

    private void Start()
    {
        StartCoroutine(SpawnNext());
    }

    private IEnumerator SpawnNext()
    {
        while (_isSpawning)
        {
            Spawn();

            yield return _waitForSeconds;
        }
    }

    private void Spawn()
    {
        ISpawnPoint spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
        spawnPoint.Spawn();
    }
}