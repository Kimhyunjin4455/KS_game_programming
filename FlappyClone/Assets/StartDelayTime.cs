using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartDelayTime : MonoBehaviour
{
    Text startDelayText;
    // Start is called before the first frame update
    void Start()
    {
        startDelayText = GetComponent<Text>();
        startDelayText.text = "2";

        StartCoroutine("StartDelay");
    }

    IEnumerator StartDelay()
    {
        for (int i = 1; i >= 0; i -= 1)
        {
            switch (i)
            {

                case 1:
                    startDelayText.text = "Let's";
                    break;
                case 0:
                    startDelayText.text = "Go!!";
                    break;
            }

            yield return new WaitForSeconds(1f);
        }

        this.gameObject.SetActive(false);
    }
    // Update is called once per frame

}
