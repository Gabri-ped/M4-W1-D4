using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
  [SerializeField] private Renderer _renderer;
    public Color _selectedColor { get; private set; }
    
    public void SetColor(Color color)
    {
        _selectedColor = color;
        if (_renderer != null)
        {
            _renderer.material.color = _selectedColor;
        }
    }
}
