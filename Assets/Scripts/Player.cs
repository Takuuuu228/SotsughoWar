using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;
    float damageRate = 2f; // 1�b�Ԃ�2���������郌�[�g

    private GameManager gameManager;

    void Start()
    {
        gameManager = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        // Player����
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

        // HP������������
        ReduceHPOverTime();
    }

    void ReduceHPOverTime()
    {
        Debug.Log("HP: " + gameManager.hp);
        gameManager.hp -= damageRate * Time.deltaTime; // Time.deltaTime���g���Ċ��炩�Ɍ���
        if (gameManager.hp <= 0)
        {
            gameManager.hp = 0;
            Debug.Log("Player is dead.");
            gameManager.LoadGameOver(); // �Q�[���I�[�o�[�V�[�������[�h
        }
        Debug.Log("HP: " + gameManager.hp);
    }
}
