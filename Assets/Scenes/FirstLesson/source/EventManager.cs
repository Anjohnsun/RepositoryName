using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public static UnityEvent<float> VerticalArrowPressed = new UnityEvent<float>();
    public static UnityEvent<float> HorizontalArrowPressed = new UnityEvent<float>();
    public static UnityEvent SpacePressed = new UnityEvent();
    public static UnityEvent ScreenClickedLeft = new UnityEvent();
    public static UnityEvent ScreenClickedRight = new UnityEvent();

    [SerializeField] PlayerM _player;

    private void Start()
    {
        VerticalArrowPressed.AddListener(moveRB);
        HorizontalArrowPressed.AddListener(rotateRB);
        SpacePressed.AddListener(JumpRB);
        ScreenClickedLeft.AddListener(Shoot);
        ScreenClickedRight.AddListener(Recharge);
    }

    //--------

    private void moveRB(float arrowValue)
    {
        if (_player.CanMove)
            PlayerMovement.Move(_player.Rb, arrowValue, _player.PlayerSpeed);
    }

    private void rotateRB(float arrowValue)
    {
        if (_player.CanMove)
            PlayerMovement.Rotate(_player.Rb, arrowValue, _player.PlayerSpeed);
    }

    private void JumpRB()
    {
        if (_player.CanMove)
            PlayerMovement.Jump(_player.Rb, _player.PlayerJumpForce);
    }

    private void ContinueMoving()
    {
        _player.CanMove = true;
    }
    private void StopMoving()
    {
        _player.CanMove = false;
    }

    private void Shoot()
    {
        PlayerCombat.Shoot(_player ,_player.BulletPrefab, _player.BulletPoint);
    }

    private void Recharge()
    {
        PlayerCombat.Recharge(_player);
    }
}
