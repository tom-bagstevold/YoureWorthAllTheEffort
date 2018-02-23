using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public WebCamTexture mCamera = null;
    public GameObject plane;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Script has been started");
        plane = GameObject.FindWithTag("Player");


        mCamera = null;
        WebCamDevice[] wdcs = WebCamTexture.devices;
        for (int n = 0; n < wdcs.Length; ++n)
        {
            if (wdcs[n].isFrontFacing)
            {
                mCamera = new WebCamTexture(wdcs[n].name);
            }
        }

        if (mCamera == null)
        {
            mCamera = new WebCamTexture();
        }



       // mCamera = new WebCamTexture();
        plane.GetComponent<Renderer>().material.mainTexture = mCamera;
        mCamera.Play();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
