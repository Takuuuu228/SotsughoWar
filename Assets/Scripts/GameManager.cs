using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;  // ���̍s��ێ����܂�

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
                if (instance == null)
                {
                    Debug.LogError("GameManager instance not found!");
                }
            }
            return instance;
        }
        private set
        {
            instance = value;
        }
    }
    public int academicYear = 1; // �����l�Ƃ���1�N���Ɖ���
    public int score = 0;
    public int points;
    public int gauge;
    public float hp = 50;
    public float maxHp = 100;

    // Start is called before the first frame update
    void Awake()
    {
        // �V���O���g���p�^�[���̐ݒ�
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("Main");
    }

    public void LoadTitleScene()
    {
        SceneManager.LoadScene("Title");
    }

    // �w�N��1���Z���郁�\�b�h
    public void IncrementAcademicYear()
    {
        academicYear++;
    }

    // �w�N���擾���郁�\�b�h
    public int GetAcademicYear()
    {
        return academicYear;
    }
    public int GetScore()
    {
        return score;
    }
    public void AddScore(int points)
    {
        score += points;
        Debug.Log("Score:"+ score);
    }
    public void AddHP()
    {
        hp += 20;
        if(hp >= maxHp)
        {
            hp = maxHp;
        }
    }
}
