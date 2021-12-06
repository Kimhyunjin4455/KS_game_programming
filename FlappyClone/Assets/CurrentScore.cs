using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = "Score: " + score.score1.ToString();
        //현재 점수는 한번만 반영하면 되서 업데이트 필요없음.
    }


}
