using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputM : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            EventManager.HorizontalArrowPressed.Invoke(Input.GetAxis("Horizontal"));
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            EventManager.VerticalArrowPressed.Invoke(Input.GetAxis("Vertical"));
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            EventManager.SpacePressed.Invoke();
        }

        if (Input.GetMouseButtonDown(0))
        {
            EventManager.ScreenClickedLeft.Invoke();
        }

        if (Input.GetMouseButtonDown(1))
        {
            EventManager.ScreenClickedRight.Invoke();
        }

    }
}


