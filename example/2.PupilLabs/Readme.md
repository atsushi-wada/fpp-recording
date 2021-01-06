# 目次
- [ソフトウェアのダウンロード・インストール](#ソフトウェアのダウンロード・インストール)
- [PupilLabsのUnityPackageを導入](#PupilLabsのUnityPackageを導入) 
- [PupilLabsを使うために](#PupilLabsを使うために)
<br />
<br />
<br />

## ソフトウェアのダウンロード・インストール
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
公式の用意したGitHubにも手順が載っています．→[ここ](https://github.com/pupil-labs/hmd-eyes)<br>
一応，こちらにもまとめておきます．<br>
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
まずは必要なソフトウェアをダウンロードします．<br>
[こちら](https://github.com/pupil-labs/pupil/releases)
から最新のものをダウンロードしてください．<br>
その中に入ってるPupil CaptureをProject実行時に使います．<br>
<br>
次にPupilLabsのUnityPackageをダウンロードします．<br>
[こちら](https://github.com/pupil-labs/hmd-eyes/releases)
からダウンロードしてください．<br>
なお，私が現在利用しているのはHmd-Eyes.VR.v1.1です．<br>
そして，このレポジトリに用意しているスクリプトは，Unity2019.1.9f1，Hmd-Eyes.VR.v1.1で作成・変更したものなので，<br>
それ以降のバージョンを使用する場合は，不具合が起こる可能性がありますので，ご注意ください．<br>
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
<br>
<br>
<br>
## PupilLabsのUnityPackageを導入
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
PupilLabsのPackageをインポートしたいプロジェクトを開きます．<br>
Unityのメニューから<br>
「Assets」->「Import package」->「Custom Package」<br>
とし、ダウンロードした「Hmd-Eyes.VR.v1.1.unitypackage」を選択．<br>
![PacageInstall](PacageInstall.PNG)<br>
「Import Unity Package」というウィンドウが出るので、右下の「Import」を押します．<br>
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
<br>
<br>
<br>
## PupilLabsを使うために
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
Unity上でPupilLabsを使うために<br>
次にUnityの下側に表示されているであろう「Project」タブを見る．
その中の「Assets」->「Plugins」->「Pupil」->「Prefabs」を見て、<br>
その中の「Gaze Tracker」を「Hierarchy」にドラッグして追加．<br>
![PupilLabs_Use](PupilLabs_Use.PNG) <br>
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
<br>
<br>
<br>
