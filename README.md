# CcfoliaDiceAnalyzer
## 概要
ココフォリアで`x[繰り返し回数] [繰り返すコマンド]`を実行した結果を集計するアプリです<br>
自分で使う用に作りましたが、<br>
・セッション前に今日のダイスの偏りを知りたい方<br>
・CoCの技能ポイントをケチるために自分の出目を知りたい方<br>
・太陽神が憑いている方<br>
・作者のストーカー<br>
など、ご自由に利用ください。
## 用法
`x5 1D100`を実行した結果を元に説明します<br>
他のコマンドの場合についてはこの節を参考に行ってください
#### 1.以下の部分を`Ctrl+V`などでコピー
```
#1
(1D100) > 42

#2
(1D100) > 74

#3
(1D100) > 6

#4
(1D100) > 63

#5
(1D100) > 21
```
#### 2.CcfoliaDiceAnalyzer.exeを起動
#### 3.入力フォームに`Ctrl+V`などでペースト
#### 4.`(6版)1D100`を押す
#### 5.出力フォーム(入力不可)に集計結果が表示される
## 対応コマンド
### [CoC6版]
<table>
<thead>
<tr><th colspan="2">1D100</th></tr>
</thead>
<tbody>
<tr><th>クリティカル</th><th>1~5</th></tr>
<tr><th>ファンブル</th><th>96~100</th></tr>
</tbody>
</table>

### [SW2.5]
<table>
<thead>
<tr><th colspan="2">2D6</th></tr>
</thead>
<tbody>
<tr><th>自動成功/達成値+5</th><th>12</th></tr>
<tr><th>ファンブル</th><th>2</th></tr>
</tbody>
</table>

### [シノビガミ]
・ファンブル/失敗/成功/スペシャルの割合も出力
<table>
<thead>
<tr><th colspan="2">nSG±修正＠s#f>=x</th></tr>
</thead>
<tbody>
<tr><th>ダイス数</th><th>n</th></tr>
<tr><th>修正値</th><th>(任意)</th></tr>
<tr><th>スペシャル</th><th>s</th></tr>
<tr><th>ファンブル</th><th>f</th></tr>
<tr><th>目標値</th><th>x</th></tr>
</tbody>
</table>

## その他
・ココフォリアに合わせて、集計結果に色が付いていることがあります。
