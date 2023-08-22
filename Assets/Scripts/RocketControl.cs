using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketControl : MonoBehaviour
{
    [SerializeField]
    private float _speed = 30f;
    private Rigidbody _rb;
    private bool _isScrollingUp = false;
    public Transform loc;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float verticalinptut = Input.GetAxis("Mouse ScrollWheel");



        if (Input.GetKey(KeyCode.W) || verticalinptut > 0)
        {
            //_rb.velocity = Vector3.up * _speed;
            _rb.velocity = transform.up * _speed;
            //_rb.AddForce(transform.up * _speed );
            _isScrollingUp = true;
        }
        else if(Input.GetKey(KeyCode.S) || verticalinptut < 0)
        {
            _rb.velocity = Vector3.up * _speed * -1;

            _isScrollingUp = true;
        }
        else if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            float scroll = touch.deltaPosition.y / Screen.height;
            Debug.Log("scroll: "+scroll);
            if (scroll>0)
            {
                _rb.velocity = Vector3.up * _speed * -1;
            }else if (scroll < 0)
            {
                _rb.velocity = Vector3.up * _speed * 1;

            }
            Debug.Log("velocity" + _rb.velocity);
            _isScrollingUp = true;
        }
        else
        {
            _isScrollingUp = false;
        }

    }

    private void FixedUpdate()
    {

        if (_isScrollingUp)
        {
            //_rb.AddForce(transform.up * _speed);
        }
        else
        {
            _rb.velocity = Vector3.Lerp(_rb.velocity, Vector3.zero, .1f);
        }
        if (Input.GetKey(KeyCode.F))
        {
            MoveToTransform(loc);
        }
    }

    public void MoveToTransform(Transform target)
    {
        //_rb.MovePosition(Vector3.MoveTowards(transform.position, target.position, _speed));
        transform.position = target.position;
    }
}
