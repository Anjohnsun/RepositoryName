using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerM : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;

    [SerializeField] private bool _canMove = true;

    [SerializeField] private float _playerSpeed;
    [SerializeField] private float _playerRotationSpeed;
    [SerializeField] private float _playerJumpForce;

    [SerializeField] private GameObject _bulletPrefab;
    [Range(0, 50)]
    [SerializeField] private int _ammoRackSize = 0;
    [Range(0, 50)]
    [SerializeField] private int _ammoRackFullness = 0;
    [SerializeField] private Transform bulletPoint;

    public Rigidbody Rb { get => _rb; }
    public bool CanMove { get => _canMove; set => _canMove = value; }
    public float PlayerSpeed { get => _playerSpeed; }
    public float PlayerRotationSpeed { get => _playerRotationSpeed; }
    public float PlayerJumpForce { get => _playerJumpForce; }
    public GameObject BulletPrefab { get => _bulletPrefab; }
    public Transform BulletPoint { get => bulletPoint; }
    public int AmmoRackSize { get => _ammoRackSize; set => _ammoRackSize = value; }
    public int AmmoRackFullness { get => _ammoRackFullness; set => _ammoRackFullness = value; }
}
