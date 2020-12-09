using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class GraphicalMessage : MonoBehaviour
{


    // Start is called before the first frame update

    public GameObject text_object = null; // Textオブジェクト

    GameObject ZedManagerObject; //Unity上のObjectが入る変数
    public ZEDManager manager; //C#のScriptが入る変数



    [HideInInspector]
    public int dirMake;
    [HideInInspector]
    public int recordErr;


    Text record_message;


    void Start()
    {
        // オブジェクトからTextコンポーネントを取得
        Text record_message = text_object.GetComponent<Text>();
        record_message.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        record_message.text = "LinerAcceleration.x\nLinerAcceleration.y\nLinerAcceleration.z\nAngularVelocity.x\nAngularVelocity.y\nAngularVelocity.z\n";
        record_message.alignment = TextAnchor.UpperRight;
        record_message.fontSize = 22;
        record_message.lineSpacing = 1.39f;



        Debug.Log(manager.unityRecord_or_not);
    }


    
// Update is called once per frame
  void Update()
    {

        Text record_message = text_object.GetComponent<Text>();
        //record_message.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);




        //Display the Potisition.
        //使うなら ZEDManager.cs 内の VectorOfPosition の宣言と更新をコメントアウトしてないことを確認してから。
        //record_message.text = string.Format("x is {0}\ny is {1}\nz is {2}\n", 
        //    manager.VectorOfPosition.x, manager.VectorOfPosition.y, manager.VectorOfPosition.z);



        //Display the Orientation.
        //使うなら ZEDManager.cs 内の VectorOfOrientation の宣言と更新をコメントアウトしてないことを確認してから。
        //record_message.text = string.Format("x is {0}\ny is {1}\nz is {2}\nw is {3}\n", 
        //    manager.VectorOfOrientation.x, manager.VectorOfOrientation.y, manager.VectorOfOrientation.z, manager.VectorOfOrientation.w);



        //Display the LinerAcceleration.
        //使うなら ZEDManager.cs 内の VectorOfAcceleration の宣言と更新をコメントアウトしてないことを確認してから。
        //record_message.text = string.Format("raw a.x is {0}\nraw a.y is {1}\nraw a.z is {2}\n", 
        //    manager.VectorOfAcceleration.x, manager.VectorOfAcceleration.y, manager.VectorOfAcceleration.z);



        //Display the AngularVelocity.
        //使うなら ZEDManager.cs 内の VectorOfVelocity の宣言と更新をコメントアウトしてないことを確認してから。
        //record_message.text = string.Format("raw a.x is {0}\nraw a.y is {1}\nraw a.z is {2}\n", 
        //    manager.VectorOfVelocity.x, manager.VectorOfVelocity.y, manager.VectorOfVelocity.z);



    }






}



