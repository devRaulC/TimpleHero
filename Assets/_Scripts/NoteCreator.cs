using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteCreator : MonoBehaviour
{
    public List<GameObject> buttonsList = new List<GameObject>();
    public List<GameObject> notesList = new List<GameObject>();
    public GameObject noteGO;

    // Start is called before the first frame update
    void Start()
    {
        noteGO = GameObject.FindGameObjectWithTag("MasterNote");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)){
            Instantiate(notesList[0], buttonsList[0].transform.position, Quaternion.identity, noteGO.transform);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Verde");
            Instantiate(notesList[1], buttonsList[1].transform.position, Quaternion.identity, noteGO.transform);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("azul");
            Instantiate(notesList[2], buttonsList[2].transform.position, Quaternion.identity, noteGO.transform);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("amarillo");
            Instantiate(notesList[3], buttonsList[3].transform.position, Quaternion.identity, noteGO.transform);
        }

    }
}
