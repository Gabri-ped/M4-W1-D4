using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator2D : MonoBehaviour
{
    [SerializeField] private GameObject _quadPrefab;
    [SerializeField] private int _column = 5;
    [SerializeField] private int _row = 5;
    [SerializeField] private float offsetCol = 1f;
    [SerializeField] private float offsetRow = 1f;
    [SerializeField] private Transform parentTransform;
    void Start()
    {
        Instantiator();
    }
    private void Instantiator()
    {
        for (int y = 0; y < _row; y++)
        {
            for (int x = 0; x < _column; x++)
            {
                Vector3 position = new Vector3(x * offsetCol, y * offsetRow, 0f);
                Instantiate(_quadPrefab,position,Quaternion.identity,this.transform);
            }
        }
    }
}
