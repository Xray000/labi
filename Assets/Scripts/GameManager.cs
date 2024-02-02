using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField]
    int timeToEnd;

    bool gamePaused = false;
    bool endGame = false;
    bool win = false;

    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        if (timeToEnd <= 0)
            timeToEnd = 120;

        InvokeRepeating(nameof(Stopper), 2, 1);
    }

    // Update is called once per frame
    void Update()
    {
        PauseCheck();
    }

    void Stopper()
    {
        timeToEnd--;
        print("Time: " + timeToEnd + "s");

        if(timeToEnd <= 0)
        {
            timeToEnd = 0;
            endGame = true;
        }

        if(endGame)
            EndGame();
    }

    public void EndGame()
    {
        CancelInvoke(nameof(Stopper));

        if (win)
        {
            print("WIN");
        }
        else
        {
            print("FAIL");
        }
    }

    void PauseCheck()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused == true)
                ResumeGame();
            else
                PauseGame();
        }
    }

    public void PauseGame()
    {
        print("Pause Game");
        Time.timeScale = 0;
        gamePaused = true;
    }

    public void ResumeGame()
    {
        print("Resume Game");
        Time.timeScale = 1;
        gamePaused = false;
    }
}
