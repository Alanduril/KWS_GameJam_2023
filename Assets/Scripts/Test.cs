using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject logo;
    private float m_Speed;
    private Vector2 myVector;
    private bool up;

    void Start()
    {
        up = true;
        m_Speed = 0.005f;
        myVector = new Vector2(logo.transform.position.x, logo.transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if(logo.transform.position.y > 3){
             m_Speed = -0.005f;
        }

        if(logo.transform.position.y < -3){
            m_Speed = 0.005f;
        }

        logo.transform.position = new Vector2(logo.transform.position.x, logo.transform.position.y + m_Speed);
    }
}
