﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocatableCamera : MonoBehaviour {
    // Spawn only one webcam texture
    bool sendInfo = false;
    public static WebCamTexture webcamTexture;
    public static int height;
    public static int width;
    // Color32[] colors;

    // Use this for initialization
    void Start () {
        webcamTexture = new WebCamTexture(896, 504);
        //webcamTexture = new WebCamTexture();

        //Renderer renderer = GetComponent<Renderer>();
        //renderer.material.mainTexture = webcamTexture;
        webcamTexture.Play();
        height = webcamTexture.height;
        width = webcamTexture.width;
        //colors = new Color32[webcamTexture.height * webcamTexture.width];
	}
	
	// Update is called once per frame
	void Update () {
  //      if (webcamTexture.didUpdateThisFrame)
  //      {
  //          colors = webcamTexture.GetPixels32();
  //          Color32 colorspec = colors[1];
  //          DebugToServer.Log.Send(colorspec.ToString());
  //      }

		//if (!sendInfo)
  //      {
  //          DebugToServer.Log.Send(webcamTexture.width.ToString() + " " + webcamTexture.height.ToString());
  //          sendInfo = true;
  //      }
	}
}
