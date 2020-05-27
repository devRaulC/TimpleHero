using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMovement : MonoBehaviour
{
    private float xSpeed = 10.0f;

    void Update()
    {
        this.transform.Translate(Vector3.left * xSpeed * Time.deltaTime);
    }

}
