using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBG : MonoBehaviour
{
    public float speed;

    public float endX;
    public float startX;

    // Update is called once per frame
    void Update()
    {
        //Move BG towards right
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= endX)
        {
            Vector2 pos = new Vector2(startX, transform.position.y);
            transform.position = pos;
        }
    }
}
