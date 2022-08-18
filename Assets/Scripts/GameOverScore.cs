using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScore : MonoBehaviour
{
    // Start is called before the first frame update
    TextMeshProUGUI temp;

    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = "BestScore : " + Score.bestscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
