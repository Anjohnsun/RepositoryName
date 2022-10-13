using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletM : MonoBehaviour
{
    [SerializeField] private float _bulletSpeed = 1;

    private void Start()
    {
        StartCoroutine(RocketRotation());
    }
    void FixedUpdate()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward*_bulletSpeed, ForceMode.Acceleration);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Bullet Deleted");
        Destroy(gameObject);
    }

    private IEnumerator RocketRotation()
    {
        yield return new WaitForSeconds(0.03f);
        transform.Rotate(new Vector3(0, 0, 18));
        yield return StartCoroutine(RocketRotation());
    }
}
