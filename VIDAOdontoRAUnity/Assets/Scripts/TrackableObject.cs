using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackableObject : MonoBehaviour {

    // Marker responsible for defining the system's origin
    public Transform OriginMarker;
    
    public USocketHandler SocketHandler = null;

    // Use this for initialization
    void Start()
    {
        if (SocketHandler != null)
        {

        }
        else Debug.LogError(transform.name + ": No TCPConnection component found!");
    }

    // Update is called once per frame
    void Update()
    {
        //print("Pos: " + RelMakerPos().ToString());
        //print("Rot: " + RelMarkerRot().ToString());
        if(SocketHandler != null)
        {
            Debug.Log("SentTCP");

            SocketHandler.SendSMessage("pos{" + RelMakerPos().ToString() + "}rot{" + RelMarkerRot().eulerAngles.ToString() + "}");
        }
        else Debug.LogError(transform.name + ": No TCPConnection component found!");
    }


    // Gets the position of the object relative to the Origin Marker
    Vector3 RelMakerPos()
    {
        Vector3 Pos, temp;
        temp = OriginMarker.position - transform.position;

        Pos.x = Vector3.Project(temp, OriginMarker.right).magnitude;
        if (Vector3.Dot(temp, OriginMarker.right) > 0) Pos.x *= -1;

        Pos.y = Vector3.Project(temp, OriginMarker.up).magnitude;
        if (Vector3.Dot(temp, OriginMarker.up) > 0) Pos.y *= -1;

        Pos.z = Vector3.Project(temp, OriginMarker.forward).magnitude;
        if (Vector3.Dot(temp, OriginMarker.forward) > 0) Pos.z *= -1;

        return Pos;
    }
    // Gets the rotation of the object relative to the Origin Marker
    Quaternion RelMarkerRot()
    {
        return Quaternion.FromToRotation(OriginMarker.forward, transform.forward);
    }
}
