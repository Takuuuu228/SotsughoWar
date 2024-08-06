using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int academicYear = 1; // �����l�Ƃ���1�N���Ɖ���

    private static GameManager instance;

    // Start is called before the first frame update
    void Start()
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

    // Update is called once per frame
    void Update()
    {

    }

    // �w�N��1���Z���郁�\�b�h
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

    // �w�N���擾���郁�\�b�h
    public int GetAcademicYear()
    {
        return academicYear;
    }
}
