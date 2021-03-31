using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubeScript : MonoBehaviour
{

    private GameObject cube;
    private GameObject coffee;
    private GameObject cheese;
    private GameObject piano;
    private GameObject lunar;
    private Text score;

    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("Cube");
        coffee = GameObject.Find("CoffeeCup");
        cheese = GameObject.Find("Cheese");
        piano = GameObject.Find("Piano");
        lunar = GameObject.Find("Lunar");

        score = GameObject.Find("score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "score1")
        {
            score.text = "A Coffe Cup!";
            cube.SetActive(false);
            cube.transform.position = new Vector3(0, 0.14f, 2.47f);
            cube.SetActive(true);

            GameObject CC = GameObject.Instantiate(coffee);
            CC.transform.position = new Vector3(0, 0.5f, 2.47f);
        }
        else if (collision.gameObject.name == "score2")
        {
            score.text = "A Piece of Cheese!";
            cube.SetActive(false);
            cube.transform.position = new Vector3(0, 0.14f, 2.47f);
            cube.SetActive(true);

            GameObject CC = GameObject.Instantiate(cheese);
            CC.transform.position = new Vector3(0, 0.5f, 2.47f);
        }
        else if (collision.gameObject.name == "score3")
        {
            score.text = "A Part Of Piano!";
            cube.SetActive(false);
            cube.transform.position = new Vector3(0, 0.14f, 2.47f);
            cube.SetActive(true);

            GameObject CC = GameObject.Instantiate(piano);
            CC.transform.position = new Vector3(0, 0.5f, 2.47f);
        }
        else if (collision.gameObject.name == "score4")
        {
            score.text = "Waite.. It Looks Like A Spacecraft..";
            cube.SetActive(false);
            cube.transform.position = new Vector3(0, 0.14f, 2.47f);
            cube.SetActive(true);

            GameObject CC = GameObject.Instantiate(lunar);
            CC.transform.position = new Vector3(0, 0.5f, 2.47f);
        }
        else if(collision.gameObject.name == "safeGround")
        {
            score.text = "You Dropped The Cube, Be Careful!";
            cube.SetActive(false);
            cube.transform.position = new Vector3(0, 0.14f, 2.47f);
            cube.SetActive(true);
        }
    }
}
