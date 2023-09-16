using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewerMovement : MonoBehaviour
{
    public float speed;
    public float hight;
    public float rotate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            speed *= 3f;
        }
        else if(Input.GetKeyUp(KeyCode.LeftControl))
        {
            speed /= 3f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * -speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, -rotate, 0f, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, rotate, 0f, Space.World);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += transform.up * hight * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += transform.up * -hight * Time.deltaTime;
        }
    }
}
