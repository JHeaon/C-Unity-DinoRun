using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] GameObject[] gameobject = new GameObject[3];

    Vector2 startPos;
    int num;
    float currtime = 0;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        createObstacle();
    }


    void createObstacle()
    {
        currtime += Time.deltaTime;
        if (currtime > 3)
        {

            num = UnityEngine.Random.Range(0, 3);
            GameObject Obstacle = Instantiate(gameobject[num]);
            Obstacle.transform.position = new Vector2(10, -0.9f);
            Destroy(Obstacle, 5f);
            currtime = 0;
        }
    }



}
