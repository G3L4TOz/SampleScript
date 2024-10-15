using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] int score = 0;
    private void Awake()
    {
        Debug.Log("Game Controller is here");
        int numGameCtrl = FindObjectsOfType<GameController>().Length;
        if (numGameCtrl > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void AddScore()
    {
        score += 5;
        Debug.Log("Score : " + score);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            AddScore();
        }
    }
}
