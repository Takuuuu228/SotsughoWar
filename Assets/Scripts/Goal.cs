using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] float speed = 4.0f;
    // OnTriggerEnter is called when the Collider other enters the trigger
    void Update()
    {
        transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager gameManager = FindObjectOfType<GameManager>();

            if (gameManager != null)
            {
                if (gameManager.GetAcademicYear() < 4)
                {
                    gameManager.IncrementAcademicYear();
                    Debug.Log("学年更新: "+ gameManager.academicYear);

                }
                else
                {
                    gameManager.LoadGameOver();
                }
            }
        }
    }
}
