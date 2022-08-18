using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonOnClick : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject gameobject;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Click()
    {
        gameobject.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("GamePlay");
    }
}
