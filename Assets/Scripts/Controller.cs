using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Transform tr;
    public ColorShift cube;

    void Start()
    {
        tr = GetComponent<Transform>();
    }

}
