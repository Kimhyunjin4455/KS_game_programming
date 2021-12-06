using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdFly : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpStrength;
    // Start is called before the first frame update
    void Start() // 시작할때
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()  // 매 프레임마다
    {
        if (Input.GetMouseButton(0)) //마우스가 눌렸으면
        {
            GetComponent<AudioSource>().Play(); // 오디오 파일 재생
            rb.velocity = Vector2.up * jumpStrength; //(0,3) 위쪽 y좌표 방향으로 3만큼의 속도.
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (score.score1 > score.bestScore)
        {
            score.bestScore = score.score1;
        }
        if (score.score1 < score.worstScore)
        {
            score.worstScore = score.score1;
        }
        SceneManager.LoadScene("gameOverScene");
    }
}
