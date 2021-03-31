using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getScore : MonoBehaviour
{

    private Text score;
    private GameObject score1;
    private GameObject score2;
    private GameObject score3;
    private GameObject score4;
    private GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("score").GetComponent<Text>();

        score1 = GameObject.Find("score1");
        score2 = GameObject.Find("score2");
        score3 = GameObject.Find("score3");
        score4 = GameObject.Find("score4");

        cube = GameObject.Find("Cube");



        score.text = "Touch White Panels With The Cube For Random Events!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
