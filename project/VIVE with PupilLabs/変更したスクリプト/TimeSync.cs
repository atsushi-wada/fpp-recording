using System;
using System.Text;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NetMQ;
using NetMQ.Sockets;
using MessagePack;


using System.IO;

namespace PupilLabs
{
    public class TimeSync : MonoBehaviour
    {



        [SerializeField] RequestController requestCtrl;
        
        public double UnityToPupilTimeOffset { get; private set; }

 

        private string info_tBefore;
        private string info_pupilTime;
        private string info_tAfter;
        private string info_unityTime;
        private string info_UnityToPupilTimeOffset;
        public ArrayList TimeList = new ArrayList();



        public double tBefore;
        public double pupilTime;
        public double tAfter;
        public double unityTime;
        public string fileNameforTime;






        private void Start()
        {
            fileNameforTime = "TimeSyncInfo.txt";
        }




        void OnEnable()
        {
            requestCtrl.OnConnected += UpdateTimeSync;
        }
        
        public double GetPupilTimestamp()
        {
            if (!requestCtrl.IsConnected)
            {
                Debug.LogWarning("Not connected");
                return 0;
            }
            
            string response;
            requestCtrl.SendCommand("t", out response);
            //Debug.Log(response);
            return double.Parse(response, System.Globalization.CultureInfo.InvariantCulture.NumberFormat); ;
        }

        public double ConvertToUnityTime(double pupilTimestamp)
        {
            if (!requestCtrl.IsConnected)
            {
                Debug.LogWarning("Not connected");
                return 0;
            }

            return pupilTimestamp - UnityToPupilTimeOffset;
        }

        public double ConvertToPupilTime(double unityTime)
        {
            if (!requestCtrl.IsConnected)
            {
                Debug.LogWarning("Not connected");
                return 0;
            }

            return unityTime + UnityToPupilTimeOffset;
        }

        [ContextMenu("Update TimeSync")]
        public void UpdateTimeSync()
        {
            if (!requestCtrl.IsConnected)
            {
                Debug.LogWarning("Not connected");
                return;
            }

            tBefore = Time.realtimeSinceStartup;
            pupilTime = GetPupilTimestamp();
            tAfter = Time.realtimeSinceStartup;
            unityTime = (tBefore + tAfter) / 2.0;
            UnityToPupilTimeOffset = pupilTime - unityTime;

            Debug.Log("tBefore is " + tBefore);
            Debug.Log("pupilTime is " + pupilTime);
            Debug.Log("tAfter is " + tAfter);
            Debug.Log("unity time is "+unityTime);
            Debug.Log("UnityToPupilTimeOffset is " + UnityToPupilTimeOffset);


        }

        [System.Obsolete("Setting the pupil timestamp might be in conflict with other plugins.")]
        public void SetPupilTimestamp(double time)
        {
            if (!requestCtrl.IsConnected)
            {
                Debug.LogWarning("Not connected");
                return;
            }

            string response;
            string command = "T " + time.ToString("0.000000", System.Globalization.CultureInfo.InvariantCulture);

            float tBefore = Time.realtimeSinceStartup;
            requestCtrl.SendCommand(command, out response);
            float tAfter = Time.realtimeSinceStartup;

            UnityToPupilTimeOffset = -(tAfter - tBefore) / 2f;
        }

        [ContextMenu("Check Time Sync")]
        public void CheckTimeSync()
        {
            if (!requestCtrl.IsConnected)
            {
                Debug.LogWarning("Check Time Sync: not connected");
                return;
            }
            double pupilTime = GetPupilTimestamp();
            double unityTime = Time.realtimeSinceStartup;
            Debug.Log($"Unity time: {unityTime}");
            Debug.Log($"Pupil Time: {pupilTime}");
            Debug.Log($"Unity to Pupil Offset {UnityToPupilTimeOffset}");
            Debug.Log($"out of sync by {unityTime + UnityToPupilTimeOffset - pupilTime}");
        }



        public void TimeInfoOutput()
        {
            info_tBefore = ("tBefore is " + tBefore);
            info_pupilTime = ("pupilTime is " + pupilTime);
            info_tAfter = ("tAfter is " + tAfter);
            info_unityTime = ("unity time is " + unityTime);
            info_UnityToPupilTimeOffset = ("UnityToPupilTimeOffset is " + UnityToPupilTimeOffset);


            TimeList.Add(info_tBefore);
            TimeList.Add(info_pupilTime);
            TimeList.Add(info_tAfter);
            TimeList.Add(info_unityTime);
            TimeList.Add(info_UnityToPupilTimeOffset);


            Debug.Log("fileNameforTime is " + fileNameforTime);


            string[] myArr = (string[])TimeList.ToArray(typeof(string));
            var encoding = Encoding.GetEncoding("shift_jis");
            File.WriteAllLines(fileNameforTime, myArr, encoding);


            TimeList = new ArrayList();


        }



    }
    
}