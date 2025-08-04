using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoinsSpawner : MonoBehaviour
{
    [SerializeField]
    private float _spawnInterval = 2f;
    [SerializeField]
    private float _radius = 0.5f;
    [SerializeField]
    private UnityEvent<Vector3> _spawnCoin;
    private Coroutine _spawnCoroutine;
    public void Initialize()
    {
        _spawnCoroutine = 
    }
}
