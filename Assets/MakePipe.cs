using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{

    public GameObject Pipe;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2)
		{
            GameObject NewPipe = Instantiate(Pipe);
            NewPipe.transform.position = new Vector3(3, Random.Range(-2.0f, 5.0f), 0);
            timer = 0;
            Destroy(NewPipe, 10.0f);
        }
    }
}
