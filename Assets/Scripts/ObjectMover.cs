using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    [SerializeField] float speed = 4.0f;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
    }
}
