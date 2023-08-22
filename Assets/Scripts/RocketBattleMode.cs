using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBattleMode : MonoBehaviour
{
    [SerializeField]
    private float _rotateSpeed = 10f;
    [SerializeField]
    private float _speed = 10f;
    Rigidbody _rb;
    private bool _isScrollingUp = false;

    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            RotateLeft();
        }
        if (Input.GetKey(KeyCode.D))
        {
            RotateRight();
        }
        if (Input.GetKey(KeyCode.W))
        {
            _rb.velocity = transform.up * _speed;
            _isScrollingUp = true;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _rb.velocity = transform.up * _speed * -1;

            _isScrollingUp = true;
        }
        else
        {
            _isScrollingUp = false;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            ShootBullet();
        }

    }

    private void RotateLeft()
    {
        _rb.rotation *= Quaternion.Euler(0,0,_rotateSpeed * Time.deltaTime);
    }

    private void RotateRight()
    {
        _rb.rotation *= Quaternion.Euler( 0,0,_rotateSpeed * Time.deltaTime * -1);
    }

    private void FixedUpdate()
    {

        if (_isScrollingUp)
        {
            //_rb.AddForce(transform.up * _speed);
            Debug.Log("going");
        }
        else
        {
            _rb.velocity = Vector3.Lerp(_rb.velocity, Vector3.zero, .1f);
        }
    }

    private void ShootBullet()
    {
        Debug.Log("shooting");
    }
}
