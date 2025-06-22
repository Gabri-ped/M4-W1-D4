using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    private Material _material;
    private ColorManager _colorManager;
   
    void Start()
    { 
       _material = GetComponent<Renderer>().material;
       _colorManager = FindObjectOfType<ColorManager>();
    }
 
    private void OnMouseDown()
    {
        _colorManager.SetColor(_material.color);
    }
}
