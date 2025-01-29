using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateDiamonds : MonoBehaviour
{
    public Vector3 rotate;

    private void Update()
    {
        transform.Rotate(rotate * Time.deltaTime);
    }
}
