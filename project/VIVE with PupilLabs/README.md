# 目次
- [VIVE with PupilLabs について](#VIVE-with-PupilLabs-について)
- [VIVE with PupilLabs のオブジェクト](#VIVE-with-PupilLabs-のオブジェクト)    
	- [追加したゲームオブジェクトとその追加方法 および 追加した目的](#追加したゲームオブジェクトとその追加方法-および-追加した目的)  
	- [変更したC#のスクリプト](#変更したCのスクリプト)  
	- [追加したC#のスクリプト および 追加した目的](#追加したCのスクリプト-および-追加した目的)  
	- [オブジェクトに追加したスクリプト](#オブジェクトに追加したスクリプト)  
	- [Inspectorでの設定](#Inspectorでの設定)  
	- [ゲームオブジェクトの座標](#ゲームオブジェクトの座標)  
		- [画面に文字を表示するためのオブジェクト](#画面に文字を表示するためのオブジェクト)  
	- [ProjectSettings](#ProjectSettings)  
<br />
<br />
<br />

## VIVE with PupilLabs について
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
VIVE Pro と ZEDmini と PupilLabsを使用．<br>
パススルーしながらPupilLabsを利用し，
リアルタイムでどこに視点を置いているかを黄色の丸で表示するプロジェクトです．<br>
<br>
実行する際にはPupilCaptureを起動しておく必要があります．<br>
<br>
主な仕様は以下の通りです．<br>
- キーボードのCを押すことでキャリブレーション  
- コントローラのボタンで録画開始と録画停止が可能（PupilCaptureも同期）
録画に失敗した場合はその旨を画面に表示
<br>
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
<br>

### 必要な準備

＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
まずは環境構築から．<br>
[こちら](https://github.com/atsushi-wada/fpp-recording/tree/master/preparation/1.environment)を参考に，パススルーできるところまで進めてください．<br>
次に[こちら](https://github.com/atsushi-wada/fpp-recording/tree/master/preparation/2.PupilLabs)
を参考にPupilLabsをUnity上で使えるようにしてください．<br>
<br>
また，使用にあたって[実機使用に関しての諸注意](https://github.com/atsushi-wada/fpp-recording/blob/master/preparation/README.md)も目を通していただければと思います．<br>
（大したことは書いてないですが...）<br>
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
<br>
<br>
<br>
 ## VIVE with PupilLabs のオブジェクト
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
まずゲームオブジェクトは何があるのかを紹介します．<br>
以下の画像に載っている通りです．<br>
![オブジェクト](オブジェクト.PNG)  
すべてが元から用意されたものではないので，<br>
次にどれが追加したものかを載せておきます．<br />
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
<br>
<br>
### 追加したゲームオブジェクトとその追加方法 および 追加した目的
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
オブジェクトはヒエラルキー部分の右クリックで追加可能です．<br>
またオブジェクトの親子関係は分かるように書いたつもりですが，<br>
分かりにくかったら上で表示してる画像で確認してください．<br>
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>

	・ZED_Rig_StereoのCamera_eyesの下の 
	    ・Camera_eyes下の  
      		・Left_eye下の  
      			・Frame下の  
      				・Plane	：3DオブジェクトのPlaneで追加__視点を投影するための壁  
      		・Canvasの下の
      			・Text		：UIのTextで追加__録画の開始と停止、失敗を画面に表示するため
	・Gaze Trackerの下の
      		・RecordingController	：CreatEmptyで追加__PupilLabs側に録画の命令を送信するため	
	・UseController		：CreatEmptyで追加__csvファイルへの出力に関するスクリプトを使うため  
	・RecordMessage		：CreatEmptyで追加__録画の開始と停止、失敗を画面に表示するため<br>
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
<br>
<br>
### 変更したC#のスクリプト
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>

	・ZEDManager.cs
	・ZEDCameraEditor.cs
	・RecordingController.cs
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
これらはのスクリプトは[ここ](https://github.com/atsushi-wada/fpp-recording/tree/master/project/VIVE%20with%20PupilLabs/%E5%A4%89%E6%9B%B4%E3%81%97%E3%81%9F%E3%82%B9%E3%82%AF%E3%83%AA%E3%83%97%E3%83%88)に用意しています．

変更箇所も軽くまとめておきます．<br>
#### ZEDManager.cs<br>
<details>
<summary>変更箇所</summary>
<pre>
<code>
389行目～410行目に追記．
        csvに出力する時に使うものや，他のスクリプトを使うためのものです．
private void AcquireImages() の中
        1712行目～1721行目に追記．
        csvに書き出すデータをリストに追加する箇所です．
</code>
</pre>
</details>

#### ZEDCameraEditor.cs<br>
<details>
<summary>変更箇所</summary>
<pre>
<code>
600行目～648行目に追記。
        録画開始時に日付の取得と出力先の設定を行います。
        録画停止時にはリストをcsvに出力し、リストを初期化します。
</code>
</pre>
</details>

#### RecordingController.cs<br>
<details>
<summary>変更箇所</summary>
<pre>
<code>
void Update()の削除
	ZEDmManager.cs側で録画開始の処理を追加したため、削除しました。 
</code>
</pre>
</details>

＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
<br>
<br>
### 追加したC#のスクリプト および 追加した目的
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>

	・Void_NotVisualizingLayer.cs：Planeを画面上に表示しないため
	・UseController.cs： HMD付属のコントローラのボタンで録画開始と録画停止を行うため
	・RecordMessage.cs： 録画開始，録画停止，録画失敗を画面に表示するため
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
これらのスクリプトは[ここ](https://github.com/atsushi-wada/fpp-recording/tree/master/project/VIVE%20with%20PupilLabs/%E8%BF%BD%E5%8A%A0%E3%81%97%E3%81%9F%E3%82%B9%E3%82%AF%E3%83%AA%E3%83%97%E3%83%88)に用意しています．
<br>
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
<br>
<br>
### オブジェクトに追加したスクリプト
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
ゲームオブジェクトを追加しただけでは何も動作しません．<br>
C#のスクリプトにて，させたい動作を書く必要があります．<br>
また，書いたスクリプトをゲームオブジェクトに追加する必要があります．<br>
追加方法は<br>
・オブジェクトを選択し，右側に表示されるInspectorのAddComponentで検索して追加  
・Unityの下のProjectタブから追加したいスクリプトをドラッグして，追加したいオブジェクトのところにドロップ  
のどちらかです．<br>
置いてる場所が分からなかい場合は前者でいいと思います．<br>
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>

	・ZED_Rig_StereoのCamera_eyesの下の 
	    ・Camera_eyes下の  
      		・Left_eye：Void_NotVisualizingLayer.csを追加
	・UseController		：UseController.csを追加
	・RecordMessage		：RecordMessage.csを追加
	・RecordingController	：RecordingController.csを追加
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
<br>
<br>
### Inspectorでの設定
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
ゲームオブジェクトにスクリプトを追加するだけではうまく動作しないものもあります．<br>  
Inspectorで設定する前提で書いたスクリプトなどがあるとそうなります．<br>
このプロジェクトでInspectorで設定するものを書いておきます．<br>
（オブジェクトの指定などはドラッグ&ドロップするか，リストから指定する）<br>
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>

	・ZED_Ri_Stereo下の
		・Camera_eyesの下の
			・Left_eyeの下の
				・Plane：Layerを適当なものを追加して設定(Void_NotVisualizingLayer.csで参照するために使用する．用意したスクリプトではNotVisualizingとして書いている)
	・GazeTracker下の
		・Time Sync：Tagを適当なtagを作成して設定（tagはZEDmanager.csから参照するのに使用する．用意したスクリプトではTsyncとしている）
		・RecordingController：
			Tagを適当なtagを作成して設定（tagはZEDmanager.csから参照するのに使用する．用意したスクリプトではsyncとしている）
			Request Ctrl を Connection に設定
	・UseControllerのUseController：
		Manager には オブジェクトの ZED_Rig_Stereo を指定 
		Record Mesage には オブジェクトの RecordMessage を指定
		Calibration には オブジェクトの Calibration Controller を指定
	・RecordMessageのRecordMessage：
		Text_object には オブジェクトの Text を指定
		Manager には オブジェクトの ZED_Rig_Stereo を指定 
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
<br>
<br>
### ゲームオブジェクトの座標 
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
オブジェクトの座標は基本的にUnity上での絶対座標を使い，そのオブジェクトの中心の座標で表されます．<br>
また，子オブジェクトの座標は，UnityのInspector上では，親オブジェクトの座標を基準とした相対座標となっています．<br>
<br>
本プロジェクトで座標を気にする必要があるのは，<br>
画面に文字を表示するためのオブジェクトと
視点を表示するためのオブジェクト．<br>
<br>
その中で初期位置では見えにくかったりするものは位置調整が必要になります．<br>
位置調整は面倒だと思うので，参考程度に私が見やすいと思った座標を記載しています．<br>
（座標はUnityのInspector上で表示されるものを書いています）
<br />
<br />
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>

	・ZED_Rig_Stereo：(x,y,z)=(0,0,0)
		・Camera_eyes：(x,y,z)=(0,0,0)
			・Left_eye：(x,y,z)=(0,0,0)
				・Frame：(x,y,z)=(0,0,1)
					・Plane：(x,y,z)=(0,0,0.5)
			・Canvas：(x,y,z)=(0,0,2)
				・Text：(x,y,z)=(0,0,0)
<br>
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
<br>
<br>

### ProjectSettings
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
HMDに対応しているコントローラのボタンで録画の開始・停止を
実行するために必要な設定です．<br>
 Edit->ProjectSettings から設定します．<br>
 - Input にて
	- Fire3をRecordButttonにRenameし，PositiveButtonをjoystick button 9に設定<br>

＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
<br>
<br>

### 課題点
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
- 現状，PupilCapture と Unity で完全な同期が取れてはいない(フレーム取得のタイミングがわずかにズレている)ため，<br>後でデータから補間する必要がある点．<br>
- キャリブレーションを実行するためにキーボードでの入力が必要な点．（たぶんすぐに）
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
<br>
<br>
