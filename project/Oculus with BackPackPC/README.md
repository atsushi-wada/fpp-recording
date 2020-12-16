# 目次
- [Oculus with BackPackPCについて](#Oculus-with-BackPackPCについて)
- [Oculus with BackPackPCのオブジェクト](#Oculus-with-BackPackPC-のオブジェクト)    
	- [追加したゲームオブジェクトとその追加方法 および 追加した目的](#追加したゲームオブジェクトとその追加方法-および-追加した目的)  
	- [変更したC#のスクリプト](#変更したCのスクリプト)  
	- [追加したC#のスクリプト および 追加した目的](#追加したCのスクリプト-および-追加した目的)  
	- [オブジェクトに追加したスクリプト](#オブジェクトに追加したスクリプト)  
	- [Inspectorでの設定](#Inspectorでの設定（オブジェクトの座標は後述）)  
	- [ゲームオブジェクトの座標](#ゲームオブジェクトの座標)  
		- [画面に文字を表示するためのオブジェクト](#画面に文字を表示するためのオブジェクト)   
		- [棒グラフの始点終点を決めるオブジェクト](#棒グラフの始点終点を決めるオブジェクト)  
<br />
<br />
<br />

## Oculus with BackPackPCについて
Oculus Rift S と ZEDmini を使用．  
パススルーしながらZEDmini内臓のIMUセンサから
加速度と角速度を抽出し，画面上にて棒グラフにてリアルタイムで表示するプロジェクト．

主な仕様は以下の通りです．
- コントローラのボタンで録画開始と録画停止が可能  
録画に失敗した場合はその旨を画面に表示
- 重力加速度を垂直方向に9.8m/s^2とし，それを取り除いた結果を棒グラフで表示 

(必要があれば適宜追記)

<br />
<br />

 ## Oculus with BackPackPC のオブジェクト

まずゲームオブジェクトは何があるのかを紹介します．  
以下の画像に載っている通りです．  

![オブジェクト](オブジェクト.PNG)  
すべてが元から用意されたものではないので、  
次にどれが追加したものかを載せておきます．
<br />

### 追加したゲームオブジェクトとその追加方法 および 追加した目的   
オブジェクトはヒエラルキー部分の右クリックで追加可能です．  
またオブジェクトの親子関係は分かるように書いたつもりですが，  
分かりにくかったら上で表示してる画像で確認してください．  

	・ZED_Rig_StereoのCamera_eyesの下の  
		・Canvasの下の
			・Text         ：UIのTextで追加__録画の開始と停止、失敗を画面に表示するため
			・GraphicalInfo：UIのTextで追加__棒グラフのラベルの表示のため  
		・Line_Accelaration_X	：CreatEmptyで追加__棒グラフの挙動を決定するため
		・Line_Accelaration_Y	：CreatEmptyで追加__棒グラフの挙動を決定するため
		・Line_Accelaration_Z	：CreatEmptyで追加__棒グラフの挙動を決定するため
		・Line_AngularVelocity_X ：CreatEmptyで追加__棒グラフの挙動を決定するため
		・Line_AngularVelocity_Y ：CreatEmptyで追加__棒グラフの挙動を決定するため
		・Line_AngularVelocity_Z ：CreatEmptyで追加__棒グラフの挙動を決定するため
	・UseController		：CreatEmptyで追加__csvファイルへの出力に関するスクリプトを使うため  
	・RecordMessage		：CreatEmptyで追加__録画の開始と停止、失敗を画面に表示するため  
	・GraphicalMessage	：CreatEmptyで追加__棒グラフのラベルの表示のため   
	・UnityRecorder		：CreatEmptyで追加__Unity上で表示される画面を録画するため  
	・LinePoints		：CreatEmptyで追加__棒グラフの始点・終点を決定するため
		・Set_○○	：CreatEmptyで追加__どれがどの棒グラフの始点・終点かを分かりやすくするため
			・Start_○○	：CreatEmptyで追加__棒グラフの視点
			・End_○○	：CreatEmptyで追加__棒グラフの終点
<br />

### 変更したC#のスクリプト
	・ZEDManager.cs
	・ZEDCameraEditor.cs
これらはのスクリプトは[ここ](https://github.com/atsushi-wada/fpp-recording/tree/master/project/Oculus%20with%20BackPackPC/%E5%A4%89%E6%9B%B4%E3%81%97%E3%81%9F%E3%82%B9%E3%82%AF%E3%83%AA%E3%83%97%E3%83%88)に用意しています．  
<br />


### 追加したC#のスクリプト および 追加した目的  
	・Acceleration_X.cs	： 棒グラフの動きを決めるため
	・Acceleration_Y.cs	： 棒グラフの動きを決めるため
	・Acceleration_Z.cs	： 棒グラフの動きを決めるため
	・AngularVelocity_X.cs	： 棒グラフの動きを決めるため
	・AngularVelocity_Y.cs	： 棒グラフの動きを決めるため
	・AngularVelocity_Z.cs	： 棒グラフの動きを決めるため
	・UseController.cs	： HMD付属のコントローラのボタンで録画開始と録画停止を行うため
	・RecordMessage.cs	： 録画開始，録画停止，録画失敗を画面に表示するため
	・GraphicalMessage.cs	： 棒グラフのラベルを表示するため（あとはリアルタイムでセンサデータを画面に数値として表示する際も使用）
	・UnityRecorderController.cs： UnityRecorderという機能をUnity上で操作しなくてよくするためのスクリプト

これらのスクリプトは[ここ](https://github.com/atsushi-wada/fpp-recording/tree/master/project/Oculus%20with%20BackPackPC/%E8%BF%BD%E5%8A%A0%E3%81%97%E3%81%9F%E3%82%B9%E3%82%AF%E3%83%AA%E3%83%97%E3%83%88)に用意しています．
<br />

### オブジェクトに追加したスクリプト
ゲームオブジェクトを追加しただけでは何も動作しません．  
C#のスクリプトにて，させたい動作を書く必要があります．  
また，書いたスクリプトをゲームオブジェクトに追加する必要があります．  
追加方法は  
・オブジェクトを選択し，右側に表示されるInspectorのAddComponentで検索して追加  
・Unityの下のProjectタブから追加したいスクリプトをドラッグして，追加したいオブジェクトのところにドロップ  
のどちらかです．  
置いてる場所が分からなかい場合は前者でいいと思います． 
	
	・Line_Accelaration_X	：LineRenderとAcceleration_X.csを追加
	・Line_Accelaration_Y	：LineRenderとAcceleration_Y.csを追加
	・Line_Accelaration_Z	：LineRenderとAcceleration_Z.csを追加
	・Line_AngularVelocity_X ：LineRenderとAngularVelocity_X.csを追加
	・Line_AngularVelocity_Y ：LineRenderとAngularVelocity_Y.csを追加
	・Line_AngularVelocity_Z ：LineRenderとAngularVelocity_Z.csを追加
	・UseController		：UseController.csを追加
	・RecordMessage		：RecordMessage.csを追加
	・GraphicalMessage	：GraphicalMessage.csを追加
	・UnityRecorder		：UnityRecorderController.csを追加
<br />

### Inspectorでの設定（オブジェクトの座標は後述）
ゲームオブジェクトにスクリプトを追加するだけではうまく動作しないものもある．  
Inspectorで設定する前提で書いたスクリプトなどがあるとそうなる．  
このプロジェクトでInspectorで設定するものを書いておく．  
（オブジェクトの指定などはドラッグ&ドロップするか，リストから指定する）

	・ZEDManeger
		RecordingのGameViewRecordingはZEDminiの映像ではなく，Unity上で表示される画面を録画するための設定．デモ動画用に追加した機能のため，実験では使わない．  
		AdvancedSettings の Set IMU Prior in AR は常にチェックをしておくこと．でないとセンサデータが時間経過で正しくない動作をする．（誤差が補正されず，移動してないのにセンサの値がドリフトしていく．）
	・Line_Accelaration_○のAcceleration_○ （○にはX,Y,Zが入る）  
		Start Point には オブジェクトの Start_AC_○ を指定  
		End Point   には オブジェクトの End_AC_○ を指定 
		Manager には オブジェクトの ZED_Rig_Stereo を指定 
	・Line_AngularVelocity_○のAngularVelocity_○ （○にはX,Y,Zの対応したものが入る）  
		Start Point には オブジェクトの Start_AngV_○ を指定 
		End Point   には オブジェクトの End_AngV_○ を指定 
		Manager には オブジェクトの ZED_Rig_Stereo を指定 
	・UseControllerのUseController
		Manager には オブジェクトの ZED_Rig_Stereo を指定 
		Record Mesage には オブジェクトの RecordMessage を指定
		Unityrecorder Controller には　オブジェクトの UnityRecorder を指定
	・RecordMessageのRecordMessage
		Text_object には オブジェクトの Text を指定
		Manager には オブジェクトの ZED_Rig_Stereo を指定 
	・GraphicalMessageのGraphicalMessage
		Text_object には オブジェクトの GraphicalInfo を指定
		Manager には オブジェクトの ZED_Rig_Stereo を指定 	
		
Acceleration_○.cs や AngularVelocity_○.cs のStart PointとEnd Pointの指定は，  
棒グラフの始点終点を決めるためだけのものなので，座標をスクリプト内で指定するなら不要．  
（その場合はスクリプト内のStartPointとEndPointも不要）
<br />

### ゲームオブジェクトの座標
オブジェクトの座標は基本的にUnity上での絶対座標を使い，そのオブジェクトの中心の座標で表される．  
また，子オブジェクトの座標は，UnityのInspector上では，親オブジェクトの座標を基準とした相対座標となっている． 
  
本プロジェクトで座標を気にする必要があるのは，  
画面に文字を表示するためのオブジェクトと
棒グラフの始点終点を決めるオブジェクト．  

位置調整は面倒だと思うので，参考程度に私が見やすいと思った座標を記載．
（座標はUnityのInspector上で表示されるものを書いています）
<br />

#### 画面に文字を表示するためのオブジェクト
	・ZED_Rig_Stereo：(x,y,z)=(0,0,0)
		・Camera_eyes：(x,y,z)=(0,0,0)
			・Canvas：(x,y,z)=(0,0,2)
				・Text：(x,y,z)=(0,2,-0.8)
				・GraphicalInfo：(x,y,z)=(-665.9,-87,-0.24)
<br />

#### 棒グラフの始点終点を決めるオブジェクト
	・LinePoints：(x,y,z)=(0,0,2)
		・Set_LAcceleration_○：(x,y,z)=(0,0,0)
			・Start_AC_X：(x,y,z)=(-1,0,0)
			・End_AC_X  ：(x,y,z)=(-0.9,0,0)
			・Start_AC_Y：(x,y,z)=(-1,-0.1,0)
			・End_AC_Y  ：(x,y,z)=(-0.9,-0.1,0)
			・Start_AC_Z：(x,y,z)=(-1,-0.2,0)
			・End_AC_Z  ：(x,y,z)=(-0.9,-0.2,0)
		・Set_AngularVelocity_○：(x,y,z)=(0,0,0)
			・Start_AngV_X：(x,y,z)=(-1,-0.3,0)
			・End_AngV_X  ：(x,y,z)=(-0.9,-0.3,0)
			・Start_AngV_Y：(x,y,z)=(-1,-0.4,0)
			・End_AngV_Y  ：(x,y,z)=(-0.9,-0.4,0)
			・Start_AngV_Z：(x,y,z)=(-1,-0.5,0)
			・End_AngV_Z  ：(x,y,z)=(-0.9,-0.5,0)
		

棒グラフの始点終点に関しては，先述のように座標をスクリプト側から指定することもできる．  
ただ，Unity上で動かしたほうが調整しやすかったので，  
用意しているスクリプトではゲームオブジェクトの座標を取得する方法にしている．  
なお，スクリプ内で座標を指定する場合は絶対座標で書く必要がある．  
<br />
<br />
<br />
