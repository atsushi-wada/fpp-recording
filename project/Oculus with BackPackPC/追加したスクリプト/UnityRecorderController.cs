using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEditor;
using UnityEditor.Recorder;
using UnityEditor.Recorder.Input;

public class UnityRecorderController : MonoBehaviour
{
    [HideInInspector]
    public RecorderControllerSettings setting;
    [HideInInspector]
    public MovieRecorderSettings movieRecorderSettings;
    public RecorderController recorderController;

    // Start is called before the first frame update
    void Start()
    {
        // `RecorderControllerSettings`はScriptableObject
        setting = ScriptableObject.CreateInstance<RecorderControllerSettings>();
        // フレームレートを30fpsに設定します
        setting.FrameRate = 60f;
        // 手動設定にする
        setting.SetRecordModeToManual();

        // MovieRecorderSettingsもScriptableObject
        movieRecorderSettings = ScriptableObject.CreateInstance<MovieRecorderSettings>();
        // 撮影する対象を指定します
        
        // この設定では、ゲームビューを解像度640x480で撮影します
        movieRecorderSettings.ImageInputSettings = new GameViewInputSettings() { OutputWidth = 1280, OutputHeight = 720, };
        //1080p OutputWidth =1920, OutputHeight = 1080, 
        // 720p OutputWidth =1280, OutputHeight = 720,


        // 動画のファイル名を指定します。撮影された動画は、プロジェクトルート直下に、このファイル名で保存されます
        // movieRecorderSettings.OutputFile = "test_recording";

        // 動画のフォーマットを指定します。MP4とWEBMのどちらかを指定します。
        movieRecorderSettings.OutputFormat = MovieRecorderSettings.VideoRecorderOutputFormat.MP4;
        // レコーダーを有効にします
        movieRecorderSettings.Enabled = true;

        // レコーダーを追加します
       // setting.AddRecorderSettings(movieRecorderSettings);

        //初期化
        //recorderController = new RecorderController(setting);
    }

    // Update is called once per frame
  /*  void Update()
    {


        if (Input.GetKeyDown(KeyCode.R))
        {
            if (!recorderController.IsRecording())
            {
                recorderController.PrepareRecording();
                recorderController.StartRecording();


            }
            else
            {
                recorderController.StopRecording();
            }

        }



    }
    

*/

}