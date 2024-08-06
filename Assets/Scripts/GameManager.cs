using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int academicYear = 1; // 初期値として1年生と仮定

    private static GameManager instance;

    // Start is called before the first frame update
    void Start()
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

    // Update is called once per frame
    void Update()
    {

    }

    // 学年を1加算するメソッド
    public void IncrementAcademicYear()
    {
        academicYear++;
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

    // 学年を取得するメソッド
    public int GetAcademicYear()
    {
        return academicYear;
    }
}
