using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] Game _gameManager;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _gameManager.StopGame();    
        }
    }
}
