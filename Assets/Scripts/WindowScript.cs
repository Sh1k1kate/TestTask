using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour
{
    [SerializeField] 
    private GameObject _window_to_close, _window_to_open;

    public void CloseWindow() 
    {
        _window_to_close.SetActive(false);
        _window_to_open.SetActive(true);
    }
    
}
