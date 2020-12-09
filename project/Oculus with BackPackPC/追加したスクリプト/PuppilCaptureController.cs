//UnityからPupilcaptureを起動するためのスクリプト 
//
//以下のURLからのコピペ
//　http://kconcon3.hatenablog.com/entry/2018/01/11/220000
//
//




using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using UnityEngine;

public class PuppilCaptureController : MonoBehaviour
{
    // メンバ変数
    Process proc;
    PupilLabs.TimeSync tymeSync;



    // アプリ起動時に呼ばれる
    void Start()
    {
        // 別アプリ(プロセス)起動
        
        proc = new Process();
        proc.StartInfo.FileName = @"C:\Users\exp\Downloads\pupil_v1.21-5-ga9d492e_windows_x64\pupil_capture_windows_x64_v1.21-5-ga9d492e/pupil_capture.exe";   // 起動させる別アプリ名をここに入れて下さい(フルパス指定でも可) 
        proc.Start();
        UnityEngine.Debug.Log("pupil_capture start!");


    }




    // アプリ終了時に呼ばれる
    private void OnApplicationQuit()
    {
        // 別アプリ終了処理

        string recordingDirectry2 = string.Format("{0}", proc.StartInfo.FileName);
        UnityEngine.Debug.Log(recordingDirectry2);


        if (!proc.HasExited)
        {
            // 別アプリが起動中の場合のみ終了させる
            UnityEngine.Debug.Log("pupil_capture の終了処理。");
            proc.CloseMainWindow();
            proc.WaitForExit(10000);
 


        }
        if (proc.HasExited)
        {
            UnityEngine.Debug.Log("pupil_capture が終了しました。");
        }
        else
        {
            UnityEngine.Debug.Log("pupil_capture が終了しませんでした。");
        }
        proc.Close();
        proc = null;
    }



}