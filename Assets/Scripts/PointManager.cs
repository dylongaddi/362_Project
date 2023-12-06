using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    public Text scoreText; 
    
    void epic(GameManager score)
    {
        scoreText.text = score.ToString() + " POINTS"; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
