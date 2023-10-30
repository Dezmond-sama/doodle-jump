using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform _spawnBorder;
    [SerializeField] private Platform _platformPrefab;
    [SerializeField] private float _levelWidth = 3f;
    [SerializeField] private Vector3 _startPoint;
    [SerializeField] private float _minY = .2f;
    [SerializeField] private float _maxY = 1.5f;
    [SerializeField] private float _maxX = 1.5f;
    private Vector3 _spawnPoint;
    private void Start()
    {
        _spawnPoint = _startPoint;
    }

    private void LateUpdate()
    {
        if (_spawnPoint.y < _spawnBorder.position.y)
        {
            _spawnPoint = GetNextSpawnPoint();
            GameObject p = Pool.Pop();
            if (p == null)
            {
                Instantiate(_platformPrefab, _spawnPoint, Quaternion.identity);
            }
            else
            {
                p.transform.position = _spawnPoint;
            }
        }
    }

    private Vector3 GetNextSpawnPoint()
    {
        Vector3 spawnPoint = _spawnPoint;
        spawnPoint.y += Random.Range(_minY, _maxY);
        spawnPoint.x = Mathf.Clamp(Random.Range(-_levelWidth, _levelWidth), spawnPoint.x - _maxX, spawnPoint.x + _maxX);
        return spawnPoint;
    }
}
