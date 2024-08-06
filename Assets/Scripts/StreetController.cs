using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetController : MonoBehaviour
{
    GameObject Obj;
    float streetPositionX;
    int i;

    [SerializeField] float speed;
    [SerializeField] GameObject[] Streets;

    // Start is called before the first frame update
    void Start()
    {
        streetPositionX = 0f;
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        streetPositionX += speed * Time.deltaTime;
        
        if(streetPositionX > 20.0f)
        {
            StageGenerate();
            StageEliminate();
        }
    }

    void StageGenerate()
    {
        Obj = Instantiate(Streets[i], new Vector3(100.0f, 0, 0), Quaternion.identity);
        Obj.transform.parent = this.gameObject.transform;
        streetPositionX = 0f;
        if(i < Streets.Length - 1)
        {
            i++;
        }
        else
        {
            i = 0;
        }

    }

    void StageEliminate()
    {
        foreach (Transform child in transform)
        {
            if (child.transform.position.x < -20f)
            {
                Destroy(child.gameObject);
            }
        }
    }
}
