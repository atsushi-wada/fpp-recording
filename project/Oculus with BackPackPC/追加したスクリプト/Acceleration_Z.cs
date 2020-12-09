using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Acceleration_Z : MonoBehaviour
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

    // GameObject LineAnimation; //Unity上のObjectが入る変数
    // public LineAnimation la;   //C#のScriptが入る変数


    [HideInInspector]
    private float Accelalation_voidG_z;

    private Vector3 pointA;
    private Vector3 pointB;

    [System.Obsolete]
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, StartPoint.position);
        lineRenderer.SetWidth(.05f, .05f);
        //howLong = Vector3.Distance(StartPoint.position, EndPoint.position);
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        lineRenderer.SetColors(Color.white, Color.blue);
        pointA = StartPoint.position;
        pointB = EndPoint.position;
    }

    [System.Obsolete]
    void Update()
    {
        Vector3 pointAlongLine = System.Math.Abs(manager.Accelalation_voidG.z) * Vector3.Normalize(pointB - pointA) /15 + pointA;
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
