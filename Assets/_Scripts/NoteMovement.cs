using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMovement : MonoBehaviour
{
    private float xPos;

    void Update()
    {
        xPos = this.transform.position.x;
        this.transform.Translate(Vector3.left * 10 * Time.deltaTime);

        if (xPos <= -20.0f) {
            //Destroy(this.gameObject);
        } 
    }

}
