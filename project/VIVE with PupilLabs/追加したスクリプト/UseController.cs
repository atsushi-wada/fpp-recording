using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.IO;
using System.Text;
using UnityEditor.Recorder;
using UnityEditor.Recorder.Input;
using UnityEngine.XR;

public class UseController : MonoBehaviour
{

    //ZEDManager manager;
    GameObject ZedManagerObject;    //Unity上のObjectが入る変数
    public ZEDManager manager;      //C#のScriptが入る変数
    GameObject RecordMessageObject;     //Unity上のObjectが入る変数
    public RecordMessage recordMessage; //C#のScriptが入る変数

    GameObject CalibrationControllerObject;     //Unity上のObjectが入る変数
    public PupilLabs.CalibrationController calibration; //C#のScriptが入る変数

    GameObject UnityRecorderControllerObject;
    public UnityRecorderController unirecorderController;


    private float a;




    public void InitArray()
    {
        double[][] sensorArray = new double[2][];

    }


    // Start is called before the first frame update
    void Start()
    {
        //ZedManagerObject = GameObject.FindGameObjectWithTag("ZED_Rig_Stereo"); //オブジェクトを入れるための変数
        //manager = ZedManagerObject.GetComponent<ZEDManager>();
        //recordMessage = RecordMessageObject.GetComponent<RecordMessage>();

    }

    // Update is called once per frame
    void Update()
    {
        


        //if (OVRInput.Get(OVRInput.Button.One))
        if (Input.GetButtonDown("RecordButtton"))
        {

            manager.startZedTime = manager.zedCamera.GetCameraTimeStamp();
            //manager.recScript.test = !manager.recScript.test;

            if (manager.needRecordFrame)
            {
                manager.recScript.StopRecording();
                manager.zedCamera.DisableRecording();
                manager.needRecordFrame = false;
                if (unirecorderController.recorderController.IsRecording())
                {
                    unirecorderController.recorderController.StopRecording();
                }
                Debug.Log("ZEDmini, Stop recording!");
                string[] myArr = (string[])manager.sensorList.ToArray(typeof(string));
                var encoding = Encoding.GetEncoding("shift_jis");
                File.WriteAllLines(manager.csvOutputFileName, myArr, encoding);
                manager.sensorList = new ArrayList();
            }
            else
            {
                manager.recScript.StartRecording();
                manager.timesync.CheckTimeSync();

                Debug.Log("ZEDmini, Start Recording!");
                float fps = manager.zedCamera.GetRequestedCameraFPS();
                string dirName = string.Format("output_unity_fps=" + fps);
                Debug.Log(dirName);


                if (Directory.Exists(dirName))
                {
                    Debug.Log("ディレクトリは存在します");
                    recordMessage.dirMake = 0;
                }
                else
                {


                    Debug.Log("保存先のディレクトリが存在しません．");
                    Directory.CreateDirectory(dirName);
                    Debug.Log("ディレクトリを作成しました．再度録画ボタンを押してください．");

                    recordMessage.dirMake = 1;


                    return;
                }

                System.DateTime RecStartTimeDT = System.DateTime.Now;
                string RecStartTime_string = RecStartTimeDT.ToString("yyyy_MM_dd_HH_mm_ss");


                string fileName = System.IO.Path.Combine(dirName, RecStartTime_string);
                string fileName_CSV = string.Format("{0}.csv", fileName);
                string fileName_SVO = string.Format("{0}.svo", fileName);
                manager.sensorList.Add(manager.label);
                Debug.Log(fileName_CSV);
                Debug.Log(fileName_SVO);
                manager.csvOutputFileName = fileName_CSV;
                manager.svoOutputFileName = fileName_SVO;
                if (manager.zedCamera.EnableRecording(manager.svoOutputFileName,
                    sl.SVO_COMPRESSION_MODE.AVCHD_BASED) == sl.ERROR_CODE.SUCCESS)
                {
                    manager.needRecordFrame = true;
                    if (!unirecorderController.recorderController.IsRecording())
                    {
                        unirecorderController.recorderController.PrepareRecording();
                        unirecorderController.recorderController.StartRecording();

                    }
                }
                else
                {
                    Debug.LogError("Failed to start SVO Recording");
                    recordMessage.recordErr = 1;
                    manager.needRecordFrame = false;
                }
            }


        }


        /*else if (Input.GetButtonDown("CalibrationButtton")){

            calibration.ToggleCalibration();

        }*/


       


    }










    // アプリ終了時に呼ばれる
    private void OnApplicationQuit()
    {

    }





}
