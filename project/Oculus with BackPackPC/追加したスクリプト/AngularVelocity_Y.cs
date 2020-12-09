using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AngularVelocity_Y : MonoBehaviour
{

    private LineRenderer lineRenderer;
    //private float count;
    //private float howLong;

    public Transform StartPoint;
    public Transform EndPoint;

    [HideInInspector]
    public float lineDrawSpeed;

    private float size;

    GameObject ZedManagerObject; //Unity上のObjectが入る変数
    public ZEDManager manager; //C#のScriptが入る変数




    [System.Obsolete]
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, StartPoint.position);
        lineRenderer.SetWidth(.05f, .05f);
        //howLong = Vector3.Distance(StartPoint.position, EndPoint.position);
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        lineRenderer.SetColors(Color.white, Color.blue);


    }

    [System.Obsolete]
    void Update()
    {

        Vector3 pointA = StartPoint.position;
        Vector3 pointB = EndPoint.position;
        Vector3 pointAlongLine = System.Math.Abs(manager.VectorOfAngularVelocity.y) * Vector3.Normalize(pointB - pointA) / 500 + pointA;
        lineRenderer.SetPosition(1, pointAlongLine);

    }
}



/*
 * Color c2 = new Color(1, 1, 1, 0);
 * manager.VectorOfAcceleration.x, 
 * manager.VectorOfVelocity.x 
 * 
            + Mathf.Pow(manager.VectorOfAcceleration.y - 9.8f, 2)
     */
