using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Aeroplane;

public class Check : MonoBehaviour
{

    // <>

    public GameObject Cam;
    PhotonView pView;

    void Start()
    {
        pView = GetComponent<PhotonView>();
        if(pView.isMine)
        {
          
        }
        else
        {
            Cam.SetActive(false);
            GetComponent<AeroplaneController>().enabled = false;
        }

    }
}
