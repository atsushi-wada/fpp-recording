# 目次
- [SVOからMP4へ変換について](#SVOからMP4へ変換について)  
- [必要な準備](#必要な準備)   
- [変換の流れ](#変換の流れ)  
<br />
<br />
<br />

## SVOからMP4へ変換について
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
Unity上でHMDとZEDminiを用いて録画した動画ファイルはSVO形式で保存されます．<br>
録画した動画を[こちらのプロジェクト](https://github.com/atsushi-wada/fpp-recording/tree/master/project/MP4Player)
で再生できるようにMP4に変換する手順についてまとめます．<br>
<br>
(必要があれば適宜追記)<br>
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
<br>

## 必要な準備
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
変換する際に歪み補正が必要となります．<br>
そこでStereolabsが公式サイトにて紹介されているサンプルコードを使います．<br>
サンプルコードのリンク一覧は[こちら](https://www.stereolabs.com/docs/code-samples/)<br>
<br>
今回使うのは"Video Export"です．<br>
サンプルは[C++](https://github.com/stereolabs/zed-examples/tree/master/svo%20recording/export/cpp)と
[Python](https://github.com/stereolabs/zed-examples/tree/master/svo%20recording/export/python)
の2種類用意されています．好きなほうを選んでください．<br>
リンクを押せばgithubの stereolabs/zed-examples 内のディレクトリにとびます．<br>
どちらもREADMEの指示に従って必要なものを用意し，<br>
サンプルコードを使える状態までもっていってください．<br>
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
上記のサンプルコードではAVIに変換するところまでしかやっていないため，<br>
それをさらにMP4に変換します．<br>
AVIからMP4に変換できるなら何を使っても問題ないと思いますが，<br>
私はffmpegを使用したため，<br>
手順（といってもざっくりですが）を書く際はffmpegでのやり方を書きます．<br>
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
<br>
<br>
<br>
## 変換の流れ
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
まずサンプルコードを使って
SVOからAVIに変換します．<br>
<br>
Pythonなら<br>
```
export_svo.py "path/to/file.svo" "path/to/file.avi" 0
```
C++なら<br>
```    
ZED_SVO_Export "path/to/file.svo" "path/to/file.avi" 0
```
です．<br>
これで歪み補正された状態のAVI形式の動画を用意できました．<br>
次にこれをMP4に変換します．<br>
```
ffmpeg -i path/to/file.avi path/to/file.mp4
```
これでAVIからMP4に変換できました．<br>
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝<br>
<br>
<br>

