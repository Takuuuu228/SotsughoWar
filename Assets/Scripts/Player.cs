using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;
    float damageRate = 2f; // 1秒間に2減少させるレート

    private GameManager gameManager;

    void Start()
    {
        gameManager = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        // Player操作
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

        // HPを減少させる
        ReduceHPOverTime();
    }

    void ReduceHPOverTime()
    {
        Debug.Log("HP: " + gameManager.hp);
        gameManager.hp -= damageRate * Time.deltaTime; // Time.deltaTimeを使って滑らかに減少
        if (gameManager.hp <= 0)
        {
            gameManager.hp = 0;
            Debug.Log("Player is dead.");
            gameManager.LoadGameOver(); // ゲームオーバーシーンをロード
        }
        Debug.Log("HP: " + gameManager.hp);
    }
}
