using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorShift : MonoBehaviour
{
    public Renderer rend;
    public Transform tran;
    void Start()
    {
        rend = GetComponent<Renderer>();
        tran = GetComponent<Transform>();
    }

    public void ColorChange()
    {
        rend.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

    public void OnCollisionEnter (Collision collisionInfo)
    {
      if (collisionInfo.collider.tag == "Obstacle")
      {
        ColorChange();
        Debug.Log("BIG new colour time B)");
      }
    }

    //
    // void OnTriggerEnter(Collider other)
    // {
    //     ColorChange();
    // }
}
