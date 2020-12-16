using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;





public class RecordMessage : MonoBehaviour
{


    // Start is called before the first frame update

    public GameObject text_object = null; // Textオブジェクト


    GameObject ZedManagerObject; //Unity上のObjectが入る変数
    public ZEDManager manager; //C#のScriptが入る変数



    private int recordFlag;

    [HideInInspector]
    public int dirMake;
    
    [HideInInspector]
    public int recordErr;






    void Start()
    {
        recordFlag = 0;
        dirMake = 0;
        recordErr = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        Text record_message = text_object.GetComponent<Text>();





        if (manager.needRecordFrame) {
            // テキストの表示を入れ替える



            if (recordFlag < 180)
            {
                record_message.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
                record_message.text =  "Start Recording.";
                recordFlag++;
            }
            else
            {
                record_message.text = "";
            }

        }
        else
        {
            if (recordFlag > 0)
            {
                record_message.color = new Color(0.0f, 0.0f, 1.0f, 1.0f);
                record_message.text = "Stop Recording.";
                recordFlag--;
            }
            else
            {
                record_message.text = "";
            }
        }

        if (dirMake > 0)
        {
            record_message.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            record_message.text = "保存先のディレクトリが存在しません．\n\n" +
                "ディレクトリを作成しました．\n" +
                "文字が消えた後，再度録画ボタンを押してください．";
            dirMake++;

        }
        if (dirMake == 180) { dirMake = 0; }





        if(recordErr>0)
        {
            record_message.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            record_message.text = "録画に失敗しました．\n\n" +
                "文字が消えた後，再度録画ボタンを押してください．";
            recordErr++;

        }
        if (recordErr == 180) { recordErr = 0; }






    }
}
