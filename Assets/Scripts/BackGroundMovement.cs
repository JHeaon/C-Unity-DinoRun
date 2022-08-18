using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed = 1f;
    [SerializeField] float posValue;
    [SerializeField] GameObject gameobject;

    Vector2 startPos;
    float newPos;

    void Start()
    {
        startPos = gameobject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        backgroundmovement();
        repeat();
    }


    void backgroundmovement()
    {
        gameobject.transform.position = new Vector2(gameobject.transform.position.x - (speed * Time.deltaTime), gameobject.transform.position.y);

    }

    void repeat()
    {
        if (gameobject.transform.position.x <= posValue)
        {
            gameobject.transform.position = startPos;
        }
    }
}
