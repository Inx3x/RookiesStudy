using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    // Start is called before the first frame update
    void Start()
    {
        _speed = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(
            Input.GetAxisRaw("Horizontal") * _speed * Time.deltaTime, 
            0.0f, 
            Input.GetAxisRaw("Vertical") * _speed * Time.deltaTime);
    }
}
