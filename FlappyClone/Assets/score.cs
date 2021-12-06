using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int score1 = 0;
    public static int bestScore = 0;
    public static int worstScore = 100000;
    public static int stageScore = 1;
    // Start is called before the first frame update
    void Start()
    {
        score1 = 0;
        stageScore = 1;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = score1.ToString();
    }
}
