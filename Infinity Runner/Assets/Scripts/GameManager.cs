using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public int score;
    public static GameManager inst;

    [SerializeField] TextMeshProUGUI scoreText;

    [SerializeField] Player_Movement playerMovement;

    public void IncrementScore()
    {
        score++;
        scoreText.text = "SCORE:" + score;
        // Increase the players speed
        playerMovement.speed += playerMovement.speedIncreasePerPoint;

    }


    private void Awake ()
    {
        inst = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
