using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformManager : MonoBehaviour
{
    public GameObject myCube;

    public GameObject rotado;
    public GameObject escalado;
    public GameObject RotadoyEscalado;

    public Vector3 originalRotation;
    public Vector3 originalScale;

    public bool isRotated;
    public bool isScale;

    // Start is called before the first frame update
    void Start()
    {
        isRotated = false;
        originalRotation = myCube.transform.eulerAngles;
        originalScale = myCube.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (isRotated)
            {
                myCube.transform.eulerAngles = originalRotation;
                isScale = false;
            }
            else
            {
                myCube.transform.eulerAngles = rotado.transform.eulerAngles;
                isScale = true;
            }
            if (isScale)
            {
                myCube.transform.localScale = originalScale;
                isScale = false;
            }
            else
            {
                myCube.transform.localScale = rotado.transform.localScale;
                isScale = true;
            }
        }
    }
}
