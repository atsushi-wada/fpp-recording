ここでは環境構築についての説明をします


## ViveSetup ～ SteamVRのセットアップまで

＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

まず最初に参考になりそうなページのURLを載せておきます。

[①](https://www.moguravr.com/htcvive-setup/)　僕が参考にしたページ

[②](http://www.monobitengine.com/vc/WebDoc/contents/VRSettings/Install_ViveSetup.htm)　改めて調べていたら見つけたもう少しわかりやすそうなページ

＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

以下では（SteamVRのセットアップまで）

僕が参考にしたページ[①](https://www.moguravr.com/htcvive-setup/)を見ながら行った作業を書いていきます。

[②](http://www.monobitengine.com/vc/WebDoc/contents/VRSettings/Install_ViveSetup.htm)のほうがわかりやすいと思ったら、そちらを見ていただければと思います。

まずはSteamのインストールを下記のURLから行う。

https://store.steampowered.com/?l=japanese


Steamを利用する際にはアカウントの作成を求められるので、適当なアカウントを作成。


Steamを起動出来たらVRゴーグルをパソコンに接続。


VRゴーグルを繋いで認識されたら
SteamからSteamVRがダウンロード・起動が可能となる。

Stemaの右上にVRという文字が出ているはずなので、
そこをクリック。



SteamVRが起動出来たらまずは
ベースステーション、コントローラが接続されるかを確認。


コントローラはSteamVRのメニューから
「デバイス」→「コントローラのペアリング」を行えば可能。
コントローラはフレームウェアのアップデートを求められることがある。
その場合は有線でPCに繋いでアップデートを行う

ベースステーションは電源を入れたら
後ろにあるスイッチでチャンネルを変更する。
片方をb、もう片方をcにする。


ベースステーションとコントローラが接続出来たら
SteamVRのメニューから「ルームセットアップを実行」を選択する。
画面の指示に従い、セットアップを行う。

＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝




＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

## Unityのダウンロード・インストールについて

＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝


まずは公式のページからUnityHubをダウンロード

https://unity3d.com/jp/get-unity/update/

UnityHubをダウンロードして起動したら
左側に「プロジェクト」「使い方を学ぶ」「インストール」という項目があるので、
「インストール」の項目を選ぶ。

すると右上にも「インストール」と書かれており、そこをクリックすると
Unity本体の正式リリース版の一覧が表示されるので、
好きなものを選んでインストール。


基本的には最新のものでいいと思いますが
後で入れるプラグインによっては最新のバージョンだと
対応していないものがあるかもしれません。
そこはプラグイン側の更新ログなどを確認してください。



Unityを使う際にアカウントを作ることになると思います。
AssetStoreを使う際に必要です。
アカウントを作った時のことは細かく覚えていないですが、画面に沿ってやっていけばできたと思います。
一応、アカウントを作る際のことも書いてあるページのURLを載せておきます。
https://techacademy.jp/magazine/1436

＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝




＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

## Steam VR Pluginの導入（VIVEをUnity上で認識させるために必要）について。

＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

まずは参考にしたサイトのURL。

http://www.monobitengine.com/vc/WebDoc/contents/Project_VRCloud/Install_SteamVR_Plugin.htm

Unityのアカウントを作った後、
AssetStoreでSteamVR Pluginを検索し、
ダウンロード・インポートしましょう。

AssetStoreはUnity上でも見れるし、。
ブラウザで見ていてもUnityが入ってたらUnityに切り替わってダウンロードします。


「ダウンロード」を押してしばらくすると
「Import Unity Package」というウィンドウが出るので、右下の「Import」を押す。

そのあとに「SteamVR_Settings」というウィンドウも出るので、「Accept All」をクリック。

＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝





＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

## ZEDmini関連のプラグイン

＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

ZED　miniに関連することは公式サイトを見ながら行った

https://www.stereolabs.com/docs/unity/


まず、ZED SDKをSTEREO LABSの公式サイトからダウンロード

https://www.stereolabs.com/developers/release/


次に
Unity用のZEDminiのプラグインをダウンロードする。
2019/10/09時点で「ZED_Unity_Plugin_v2.8.1.unitypackage」が最新。
これを以下のページからダウンロード。

https://github.com/stereolabs/zed-unity/releases


次に
Unityにダウンロードした「ZED_Unity_Plugin_v2.8.1.unitypackage」を
インポートする。
Unityのメニューから
「Assets」->「Import package」->「Custom Package」
とし、ダウンロードした「ZED_Unity_Plugin_v2.8.1.unitypackage」を選択する。

Steam VR Pluginを入れた時と同様に、
「Import Unity Package」というウィンドウが出るので、右下の「Import」を押す。

＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝





＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

## ZEDminiの映像をVIVEにパススルーする方法

＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

Unityの左川にある「Hierarchy」内の「MainCamera」を削除。

次にUnityの下側に表示されているであろう「Project」の中の
「Assets」->「ZED」->「Prefabs」
を見て、その中の「ZED_Rig_Stereo」を「Hierarchy」にドラッグして追加する。

「Hierarchy」内の「ZED Rig Stereo」を選択すると
右側に「Inspector」が表示される。
ここで「Add Component」->「Script」から「ZED Manager」を追加。

次に
Unityのメニューの「Edit」->「ProjectSetting」を押して
ウィンドウを出す。その中の「XR Settings」を見る。
そこの「Virtual Reality Supported」の項目にチェック。
OpenVRが入ってないとその項目が出なかったと記憶しています。
（OpenVRはSteamVRのプラグインを入れるときに一緒に入っているはず。）




あとはベースステーションの電源を入れて、
ZEDminiをUSB-Type-Cのところに繋いで
実行する（再生ボタンを押す）ことでパススルーはできる。

＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

そしてこの時、
「ZED Manager」からInputを選べるので、
SVOを選択し、パスを指定すると、VIVEでその動画が見れる。
ただ、そのままではスクリーンが空間に単独で存在し、
そこに顔を向けることになるので
どこかで設定する必要がある。


＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

