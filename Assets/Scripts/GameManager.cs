using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject gameobject;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Click();
    }


    public void Click()
    {
        gameobject.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("GamePlay");
    }
}
