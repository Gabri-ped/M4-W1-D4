using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator3D : MonoBehaviour
{
    [SerializeField] private GameObject _quadPrefab;
    [SerializeField] private int _column = 10;
    [SerializeField] private int _row = 10;
    [SerializeField] private int _deep = 10;
    [SerializeField] private float offsetCol = 1f;
    [SerializeField] private float offsetRow = 1f;
    [SerializeField] private float offsetDeep = 1f;
    [SerializeField] private Transform parentTransform;
    void Start()
    {
        Instantiator();
    }
    private void Instantiator()
    {
        for (int z = 0; z < _deep; z++)
        {
            for (int y = 0; y < _row; y++)
            {
                for (int x = 0; x < _column; x++)
                {
                    Vector3 position = new Vector3(x * offsetCol, y * offsetRow, z * offsetDeep);
                    Instantiate(_quadPrefab, position, Quaternion.identity, this.transform);
                }
            }
        }
    }
}
