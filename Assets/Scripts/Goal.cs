using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // OnTriggerEnter is called when the Collider other enters the trigger
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
