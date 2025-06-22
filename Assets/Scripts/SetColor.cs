using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    private ColorManager _colorManager;
    private Material _material;
    private Ray _ray;
    private Camera _main;
    void Start()
    {
       _colorManager = FindObjectOfType<ColorManager>();
       _material = GetComponent<Renderer>().material;
         _main = Camera.main;

    }
     
    void Update()
    {
      if (Input.GetMouseButtonDown(1))
            {
            _material.SetColor("_BaseColor", Color.white);
            }
      if (Input.GetMouseButton(0))
           {
            _ray = _main.ScreenPointToRay(Input.mousePosition);
            RaycastHit _hit;
           
            if (Physics.Raycast(_ray, out _hit))
            {
                if (_hit.collider.CompareTag("Player"))
                {
                  _hit.collider.gameObject.GetComponent<Renderer>().material.color = _colorManager._selectedColor;
                }
            }
           }
    }
}
