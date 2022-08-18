using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public static int bestscore = 0;
    float currtime = 0;
    int num;

    TextMeshProUGUI temp;

    void Start()
    {
        temp = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        currtime += Time.deltaTime;
        num = Mathf.FloorToInt(currtime);
        if (num > bestscore)
        {
            bestscore = num;
        }
        temp.text = num.ToString();
    }

}
