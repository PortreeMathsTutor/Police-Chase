using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreUpdator : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreTex;
    public TextMeshProUGUI endTex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score > 19) { endTex.text = "GAME COMPLETED "; }
        else { endTex.text = " "; }
         score = GetCaught.score;
        scoreTex.text = "SCORE: " + score.ToString("0");
    }
}
