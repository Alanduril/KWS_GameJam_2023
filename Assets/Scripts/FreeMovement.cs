using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class FreeMovement : MonoBehaviour
{
    [SerializeField] float VerticalMovement = 0.5F;
    [SerializeField] float HorizontalMovement = 0.5F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float Horizontal = Input.GetAxis("Horizontal")*HorizontalMovement*Time.deltaTime;
       float Vertical = Input.GetAxis("Vertical")*VerticalMovement*Time.deltaTime;
       transform.Translate(Horizontal,Vertical,0);
    }
}
