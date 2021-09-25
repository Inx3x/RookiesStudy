using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    // 나한테 rigidbody  가 있어야 ㅎ한다.
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision @{collision.gameObject.name}!");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggger !");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.mousePosition); //Screen position

        //Debug.Log(Camera.main.ScreenToViewportPoint(Input.mousePosition));      //2D상의 좌표

        //if (Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));

        //    Vector3 dir = mousePos - Camera.main.transform.position;
        //    dir = dir.normalized;

        //    Debug.DrawRay(Camera.main.transform.position, dir * 100.0f, Color.red, 1.0f);

        //    RaycastHit hit;
        //    if (Physics.Raycast(Camera.main.transform.position, dir, out hit, 100.0f))
        //        Debug.Log($"Raycast Camera @{hit.collider.gameObject.name}");
        //}

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(Camera.main.transform.position, ray.direction * 100.0f, Color.red, 1.0f);

            //비트플래그
            //int mask = (1 << 8);

            LayerMask mask = LayerMask.GetMask("Monster")| LayerMask.GetMask("Wall");

            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, 100.0f, mask))
            {
                Debug.Log($"Raycast Camera @{hit.collider.gameObject.name}");
            }
        }
    }

   
}
