using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] float speed = 4.0f;
    [SerializeField] int unit;

    float nowPos;
    

    // Start is called before the first frame update
    void Start()
    {
        nowPos = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        transform.position = new Vector3(transform.position.x, nowPos + Mathf.PingPong(Time.time / 2.0f, 0.2f), transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Use the singleton instance
            if (GameManager.Instance != null)
            {
                if (this.gameObject.CompareTag("Unit"))
                {
                    GameManager.Instance.AddScore(unit);
                }
                if (this.gameObject.CompareTag("Research"))
                {
                    //GameManager.Instance.AddResearchPoint();
                }
                    
                Destroy(gameObject);
            }
            else
            {
                Debug.LogError("GameManager instance not found!");
            }
        }
    }
}
