using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    void Start() // 시작할때
    {
        GetComponent<AudioSource>().Play();
    }
    public void ReplayGame()
    {
        SceneManager.LoadScene("gamestart");

    }
}
