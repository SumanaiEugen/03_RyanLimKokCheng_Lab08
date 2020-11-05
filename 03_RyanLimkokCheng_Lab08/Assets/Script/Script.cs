using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script : MonoBehaviour
{
    float counter = 0;
    public GameObject scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.GetComponent<Text>().text = ("Start Function");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            scoreText.GetComponent<Text>().text = ("Spacebar:" + counter);
            print("Space Key pressed");
            counter++;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("Space Key Released");
        }

    }
}
