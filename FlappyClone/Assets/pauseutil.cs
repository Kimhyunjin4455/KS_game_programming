using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseutil : MonoBehaviour
{
    bool pauseActive = false;
    // Start is called before the first frame update

    public void PauseBtn()
    {
        if (pauseActive)
        {
            Time.timeScale = 1;
            pauseActive = false;
        }
        else
        {
            Time.timeScale = 0;
            pauseActive = true;
        }
    }
}
