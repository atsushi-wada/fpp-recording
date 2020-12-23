# 目次
- [VIVEとSteamVRのSetup](#VIVEとSteamVRのSetup)
- [Unityのダウンロード・インストール](#Unityのダウンロード・インストール) 
- [プロジェクトの作成](#プロジェクトの作成)
- [SteamVRのPluginを導入](#SteamVRのPluginを導入)
- [ZEDminiのPluginを導入](ZEDminiのPluginを導入)
	- [UnityPackage(Plugin)のインストール](#UnityPackage(Plugin)のインストール)
- [ZEDminiの映像をVIVEにパススルーする方法](#ZEDminiの映像をVIVEにパススルーする方法)
<br />
<br />
<br />

## VIVEとSteamVRのSetup
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br />
参考になりそうな(というか参考にした)ページのURLを載せておきます．<br />
[①](https://www.moguravr.com/htcvive-setup/)　僕が参考にしたページ<br />
[②](http://www.monobitengine.com/vc/WebDoc/contents/VRSettings/Install_ViveSetup.htm)　改めて調べていたら見つけたもう少しわかりやすそうなページ<br />
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br />
<br />
以下では僕が参考にしたページ[①](https://www.moguravr.com/htcvive-setup/)を見ながら行った作業を書いていきます．<br />
[②](http://www.monobitengine.com/vc/WebDoc/contents/VRSettings/Install_ViveSetup.htm)のほうがわかりやすいと思ったら、そちらを見ていただければと思います．<br />
<br />
以下手順です．<br />
<br />
まずはSteamを下記のURLからインストール<br /> https://store.steampowered.com/?l=japanese<br />
Steamを利用する際にはアカウントの作成を求められるので、適当なアカウントを作成．<br />
Steamを起動出来たらVIVEをPCに接続．<br />
VIVEが認識されたらSteamからSteamVRがダウンロード・起動が可能となります．<br />
Stemaの右上にVRという文字が出ているはずなので，そこをクリック．<br />
<br>
SteamVRが起動出来たらまずはベースステーションとコントローラが接続されるかを確認．<br>
<br>
コントローラはSteamVRのメニューから
「デバイス」→「コントローラのペアリング」を行えば接続可能．<br>
（適宜，フレームウェアのアップデートを求められることがあるので，その場合は有線でPCに繋いでアップデートを行ってください）<br>
<br>
ベースステーションは電源を入れたら後ろにあるスイッチでチャンネルを<br>
片方をb、もう片方をcに変更します．<br>
<br>
ベースステーションとコントローラが接続出来たら<br>
SteamVRのメニューから「ルームセットアップを実行」を選択．<br>
画面の指示に従い、セットアップを行ってください．<br>
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
<br>
<br>
<br>
## Unityのダウンロード・インストール
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br />
公式サイトに手順が載っていますので，そちらを見ながらでも出来ます．<br />
[Windows用](https://create.unity3d.com/jp-howoto-update-win?elqTrackId=f72976ab929342d1800ebde5ca95adbe&elq=00000000000000000000000000000000&elqaid=2114&elqat=2&elqCampaignId=)    
[Mac用](https://create.unity3d.com/jp-howto-update-mac?elqTrackId=22b8cbbf86414008855f29b4c80c0f2b&elq=00000000000000000000000000000000&elqaid=2114&elqat=2&elqCampaignId=)<br />
なお，私が現在利用しているのはUnityのバージョンは2019.1.9f1です．<br>
そして，このレポジトリに用意しているスクリプトは，Unity2019.1.9f1で作成・変更したものなので，
それ以降のバージョンを使用する場合は，不具合が起こる可能性がありますので，ご注意ください．<br>
また，後述するプラグインも，使用するUnityのバージョンによっては
対応していない可能性があります．<br>
プラグイン側の更新ログなどを確認してください．<br>
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>

公式サイトにも載っていますが，一応，こちらにも手順を書いておきます．<br>
<br>
まずは公式のページからUnityHubをダウンロード<br>
https://unity3d.com/jp/get-unity/update/ <br>
<br>
UnityHubをダウンロードして起動してください．<br>
左側に「プロジェクト」「使い方を学ぶ」「インストール」という項目があるので，
「インストール」の項目を選びます．<br>
![UnityHub](UnityHub.PNG) 
<br>
すると右上にも「インストール」と書かれており，そこをクリックするとUnity本体の正式リリース版の一覧が表示されます．<br>
その中からインストールしたいバージョンを選んでインストールしてください．<br>
<br>
また，Unity使う際，アカウントを作ることになります．<br>
このアカウントはAssetStoreを使う際に必要です．<br>
画面の指示に従って作成してください．<br>
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
<br>
<br>
<br>
## プロジェクトの作成
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>

UnityHubを起動し，プロジェクトの欄を選びます．<br>
はじめは何もないと思いますので，右上の新規作成をクリック．<br>
いくつかテンプレートが存在していますが，3Dを選び，
プロジェクトの保存先を決めて作成します．<br>
以降は基本的には作成したプロジェクト上での操作になります．<br>
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
<br>
<br>
<br>
## SteamVRのPluginを導入
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
まずは参考にしたサイトのURLを載せておきます．<br>
http://www.monobitengine.com/vc/WebDoc/contents/Project_VRCloud/Install_SteamVR_Plugin.htm<br>
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>

Unity内のAssetStoreタブを押します．<br>
そこでSteamVR Pluginを検索し，ダウンロード・インポートします．<br>
もしUnityのアカウントをまだ作ってないならこの時に画面の表示に従って作ってください．<br>
<br>
なお，ブラウザからも見ることができます．その場合，ダウンロードを押すと，Unityに切り替わってダウンロードします．<br>
NiCTのLANからだと上手くいかないこともあるため，気をつけてください．<br>
私はMacのネットワーク共有でguestWifiを使ってダウンロードしました．<br>
<br>
さて，「ダウンロード」を押してしばらくすると<br>
「Import Unity Package」というウィンドウが出るので、右下の「Import」を押します．<br>
そのあとに「SteamVR_Settings」というウィンドウも出るので、「Accept All」をクリックしてください．<br>
<br>
<br>
もし，ダウンロードなどが上手くいかない場合は，[こちら]()にSteamVRのPacageを置いています．<br>
（ファイル名はsteamvr_2_3_2.unitypackage）<br>
それを次節の[プラグインの導入](#UnityPackage(Plugin)のインストール)と同じようにImportしていただければ大丈夫です．<br>
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
<br>
<br>
<br>
## ZEDminiのPluginを導入
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
まずは参考にしたサイト，というか公式サイトのURLを載せておきます．<br>
https://www.stereolabs.com/docs/unity/ <br>
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>

まず、ZED SDKをSTEREO LABSの公式サイトからダウンロードします．<br>
https://www.stereolabs.com/developers/release/
<br>
次に
Unity用のZEDminiのプラグインを以下のURLからダウンロードします．<br>
https://github.com/stereolabs/zed-unity/releases  
なお，私が現在利用しているプラグインのバージョンは2.8.1です．<br>
（ファイル名はZED_Unity_Plugin_v2.8.1.unitypackage）<br>
それ以外のバージョンを使う際はUnityのバージョンや仕様の変更などを確認したうえでご利用ください．<br>
次にダウンロードしたプラグインをUnityにインストールします．<br>
<br>
### UnityPackage(Plugin)のインストール
Unityのメニューから
「Assets」->「Import package」->「Custom Package」
とし、ダウンロードした「ZED_Unity_Plugin_v2.8.1.unitypackage」を選択．<br>
![PacageInstall](PacageInstall.PNG)<br>
「Import Unity Package」というウィンドウが出るので、右下の「Import」を押す．<br>
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
<br>
<br>
<br>
## ZEDminiの映像をVIVEにパススルーする方法
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>

Unityの左側にある「Hierarchy」内の「MainCamera」と「Directional Light」を削除。<br>
<br>
次にUnityの下側に表示されているであろう「Project」タブを見る．<br>
その中の「Assets」->「ZED」->「Prefabs」を見て、その中の「ZED_Rig_Stereo」を「Hierarchy」にドラッグして追加．
![ZED_Rig_Stereo_Use](ZED_Rig_Stereo_Use.PNG) <br>
次に
Unityのメニューの「Edit」->「ProjectSetting」を押してウィンドウを出す．<br>
その中の「Player」->「XR Settings」を見る．<br>
そこの「Virtual Reality Supported」の項目にチェックが入っているか確認．（チェックがないならチェックする）<br>
OpenVRが入ってないとその項目が出ないです．<br>
（OpenVRはSteamVRのプラグインを入れるときに一緒に入っているはず．）<br>
もしその項目がないならインストールが上手くいってないということなので，
その場合はやり直してください．<br>
![ProjectSettingWindow](ProjectSettingWindow.PNG)
<br>
<br>
あとはベースステーションの電源を入れ，
ZEDminiをPCに繋いで実行する（Unityの真ん中，うえの方にある再生ボタンを押す）ことでパススルーができます．<br>
<br>





