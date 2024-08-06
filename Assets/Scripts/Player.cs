using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            if(transform.position.z > -1.5f)
            {
                transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
            }
            
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            if (transform.position.z < 1.5f)
            {
                transform.position += new Vector3(0, 0, speed * Time.deltaTime);
            }
        }

    }
}
