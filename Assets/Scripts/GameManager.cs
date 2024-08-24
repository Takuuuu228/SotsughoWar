using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;  // この行を保持します

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
    public int academicYear = 1; // 初期値として1年生と仮定
    public int score = 0;
    public int points;
    public int gauge;
    public float hp = 50;
    public float maxHp = 100;

    // Start is called before the first frame update
    void Awake()
    {
        // シングルトンパターンの設定
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

    // 学年を1加算するメソッド
    public void IncrementAcademicYear()
    {
        academicYear++;
    }

    // 学年を取得するメソッド
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
