using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{

    Rigidbody2D rb;
    public float JumpPower;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        JumpPower = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
		{
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * JumpPower;   //(0,1) * 3
		}
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (Score.Bestscore < Score.score)  // �ְ��� ����
		{
            Score.Bestscore = Score.score;
		}
        SceneManager.LoadScene("GameOver");
	}
}
