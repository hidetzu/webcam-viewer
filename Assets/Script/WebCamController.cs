using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class WebCamController : MonoBehaviour {

    public int Width = 1920;
    public int Height = 1080;
    public int FPS = 30;

    private WebCamTexture webcamTexture;

    void Start()
    {
#if false
        RawImage rawimage = this.GetComponents<RawImage>()[0];
        WebCamDevice[] devices = WebCamTexture.devices;
        // display all cameras
        for (var i = 0; i < devices.Length; i++)
        {
            Debug.Log(devices[i].name);
        }

        webcamTexture = new WebCamTexture(devices[0].name, Width, Height, FPS);
        rawimage.material.mainTexture = webcamTexture;
        //rawimage.color = new Color(rawimage.color.r, rawimage.color.g, rawimage.color.b, 0.5f);
        GetComponent<Renderer>().material.mainTexture = webcamTexture;
        webcamTexture.Play();
#else
        WebCamDevice[] devices = WebCamTexture.devices;
        webcamTexture = new WebCamTexture(devices[0].name, this.Width, this.Height, this.FPS);
        GetComponent<Renderer>().material.mainTexture = webcamTexture;
        webcamTexture.Play();
#endif
    }

    // Update is called once per frame
    void Update () {
    }
}
