using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CcfoliaDIceAnalyzer
{
    public partial class AppWindow : Form
    {
        private string fullText;
        //出目
        private string singleRollPattern;
        //補正値
        private string adjustingValuePattern;
        //出力用
        private string tableAttributePattern;
        public AppWindow()
        {
            InitializeComponent();
        }

        private void CoC6_D100(object sender, EventArgs e)
        {
            if (ResultForm.TextLength == 0)
                return;

            int freq;
            var dicevalues = new List<int>();
            var freqtable = new int[20];
            string appendtext;



            //入力テキストの格納，微調整
            fullText = ResultForm.Text;
            fullText += "\n";
            //入出力用の正規表現パターンの定義
            //[記法]
            //[0-9]:0,1,2,...,9のいずれか
            //+:直前の表現に一致する文字が一文字以上
            //?:最短一致(一致する文字列候補の内，最も短い文字列を選ぶ．(.+)を使う場合に特に有効
            //{n,長さの最低値:書式指定子(数値>0);書式指定子(数値<0);書式指定子(数値=0)}
            singleRollPattern = "＞ ([0-9]+?)\n";
            tableAttributePattern = "{0,3:D} ～ {1,3:D} {2,3:D} {3,4:##%;;0%}\n";



            //正規表現によるパターンマッチングを使って出目を抽出，整数変換
            try
            {
                //Match.Groups[0]:パターンに一致する文字列
                //Match.Groups[1]:[0-9]+?に一致する文字列
                foreach (Match m in Regex.Matches(fullText, singleRollPattern))
                {
                    dicevalues.Add(int.Parse(m.Groups[1].Value));
                }
            }
            catch
            {
                Console.WriteLine("error:Regex.Matches()");
            }



            //度数分布表(freqtable)用に度数を数える
            //階級:1-5,6-10,..,96-100
            for (int i = 0; i < dicevalues.Count; i++)
            {
                Console.WriteLine(dicevalues[i]);
                freq = (dicevalues[i] - 1) / 5;
                freqtable[freq]++;
            }
            //結果の出力
            #region
            OutPutForm.Text = "   range  num rate\n";


            //文字色を暗橙色にして，クリティカル(1-5)を出力
            appendtext = string.Format(
                tableAttributePattern,
                1, 5, freqtable[0],
                (double)freqtable[0] / dicevalues.Count);
            OutPutForm.AppendText(appendtext, Color.DarkOrange);


            //CF以外(6-95)を出力
            for (int i = 1; i < 19; i++)
            {
                appendtext = string.Format(
                    tableAttributePattern,
                    (i * 5) + 1, (i + 1) * 5, freqtable[i],
                    (double)freqtable[i] / dicevalues.Count);
                OutPutForm.AppendText(appendtext);
            }


            //文字色を赤色にして，ファンブル(96-100)を出力
            appendtext = string.Format(
                tableAttributePattern,
                96, 100, freqtable[19],
                (double)freqtable[19] / dicevalues.Count);
            OutPutForm.AppendText(appendtext, Color.Red);
            #endregion
            //入力を消去
            ResultForm.Text = "";
        }
        private void SW_Act2D6(object sender, EventArgs e)
        {
            if (ResultForm.TextLength == 0)
                return;

            int freq;
            var dicevalues = new List<int>();
            var freqtable = new int[11];
            string appendtext;



            //入力テキストの格納，微調整
            fullText = ResultForm.Text;
            fullText += "\n";
            //入出力用の正規表現パターンの定義
            //[記法]
            //[0-9]:0,1,2,...,9のいずれか
            //+:直前の表現に一致する文字が一文字以上
            //?:最短一致(一致する文字列候補の内，最も短い文字列を選ぶ．(.+)を使う場合に特に有効
            //{n,長さの最低値:書式指定子(数値>0);書式指定子(数値<0);書式指定子(数値=0)}
            singleRollPattern = "＞ ([0-9]+?)\n";
            tableAttributePattern = "{0,4:D} {1,4:D} {2,4:##%;;0%}\n";



            //正規表現によるパターンマッチングを使って出目を抽出，整数変換
            try
            {
                //Match.Groups[0]:パターンに一致する文字列
                //Match.Groups[1]:[0-9]+?に一致する文字列
                foreach (Match m in Regex.Matches(fullText, singleRollPattern))
                {
                    dicevalues.Add(int.Parse(m.Groups[1].Value));
                }
            }
            catch
            {
                Console.WriteLine("error:Regex.Matches()");
            }



            //度数分布表(freqtable)用に度数を数える
            //階級:2,3,...,12
            for (int i = 0; i < dicevalues.Count; i++)
            {
                Console.WriteLine(dicevalues[i]);
                freq = dicevalues[i] - 2;
                freqtable[freq]++;
            }
            //結果の出力
            #region
            OutPutForm.Text = " val  num rate\n";


            //文字色を赤色にして，ゴジッテーン(1,1)を出力
            appendtext = string.Format(
                tableAttributePattern,
                2, freqtable[0],
                (double)freqtable[0] / dicevalues.Count);
            OutPutForm.AppendText(appendtext, Color.Red);


            //CF以外(3-11)を出力
            for (int i = 3; i < 12; i++)
            {
                appendtext = string.Format(
                    tableAttributePattern,
                    i, freqtable[i - 2],
                    (double)freqtable[i - 2] / dicevalues.Count);
                OutPutForm.AppendText(appendtext);
            }


            //文字色を暗橙色にして，自動成功/達成値+5(6,6)を出力
            appendtext = string.Format(
                tableAttributePattern,
                12, freqtable[10],
                (double)freqtable[10] / dicevalues.Count);
            OutPutForm.AppendText(appendtext, Color.DarkOrange);
            #endregion
            //入力を消去
            ResultForm.Text = "";
        }
        private void SG_Roll(object sender, EventArgs e)
        {
            if (ResultForm.TextLength == 0)
                return;

            int freq;
            Match match;
            int adjustingvalue, special, fumble, targetvalue;
            var dicevalues = new List<int>();
            var freqtable = new int[11];
            var resultstable = new int[4];
            string appendtext;



            //入力テキストの格納，微調整
            fullText = ResultForm.Text;
            fullText += "\n";
            //入出力用の正規表現パターンの定義
            //[記法]
            //[0-9]:0,1,2,...,9のいずれか
            //*:直前の表現に一致する文字が0文字以上
            //+:直前の表現に一致する文字が一文字以上
            //?:最短一致(一致する文字列候補の内，最も短い文字列を選ぶ．(.+)を使う場合に特に有効
            //{n,長さの最低値:書式指定子(数値>0);書式指定子(数値<0);書式指定子(数値=0)}
            singleRollPattern = "＞ ([0-9]+?) ＞ (.).+?\n";
            adjustingValuePattern = "SG([+-]?[0-9]*?)@([0-9]+?)#([0-9]+?)>=([0-9]+?)[)]";
            tableAttributePattern = "{0,4:D} {1,4:D} {2,4:##%;;0%}\n";

            //補正値・スぺ値・F値・目標値
            #region
            //補正値の抽出，格納
            //Ex.(SG+2@11#2>=7)
            match = Regex.Match(fullText, adjustingValuePattern);
            bool IsAdjusted = int.TryParse(
                match.Groups[1].Value,
                out adjustingvalue);
            //補正値がなければ0にする
            if (!IsAdjusted)
                adjustingvalue = 0;

            //スぺ値・F値・目標値の抽出，格納
            special     = int.Parse(match.Groups[2].Value);
            fumble      = int.Parse(match.Groups[3].Value);
            targetvalue = int.Parse(match.Groups[4].Value);
            #endregion


            //正規表現によるパターンマッチングを使って出目を抽出，整数変換
            try
            {
                //Match.Groups[0]:パターンに一致する文字列
                //Match.Groups[1]:[0-9]+?に一致する文字列
                //Match.Groups[2]:.に一致する文字列
                foreach (Match m in Regex.Matches(fullText, singleRollPattern))
                {
                    dicevalues.Add(int.Parse(m.Groups[1].Value));
                    //各判定結果が出た回数を数える
                    switch(m.Groups[2].Value)
                    {
                    case "フ":
                        resultstable[0]++;
                        break;
                    case "失":
                        resultstable[1]++;
                        break;
                    case "成":
                        resultstable[2]++;
                        break;
                    case "ス":
                        resultstable[3]++;
                        break;
                    default:
                        break;
                    }
                }
            }
            catch
            {
                Console.WriteLine("error:Regex.Matches()");
            }



            //度数分布表(freqtable)用に度数を数える
            //階級:2,3,...,12
            //補正値分の修正を入れて集計する
            for (int i = 0; i < dicevalues.Count; i++)
            {
                Console.WriteLine(dicevalues[i]);
                freq = dicevalues[i] - 2 - adjustingvalue;
                freqtable[freq]++;
            }
            //結果の出力
            #region
            OutPutForm.Text = " val  num rate\n";


            //文字色を暗赤色にして，ファンブルを出力
            for (int i = 2; i <= fumble; i++)
            {
                appendtext = string.Format(
                    tableAttributePattern,
                    (i + adjustingvalue),
                    freqtable[i - 2],
                    (double)freqtable[i - 2] / dicevalues.Count);
                OutPutForm.AppendText(appendtext, Color.DarkRed);
            }


            //文字色を赤色にして，失敗を出力
            for (int i = fumble+1; i < targetvalue-adjustingvalue; i++)
            {
                appendtext = string.Format(
                    tableAttributePattern,
                    (i + adjustingvalue),
                    freqtable[i - 2],
                    (double)freqtable[i - 2] / dicevalues.Count);
                OutPutForm.AppendText(appendtext, Color.Red);
            }


            //文字色を青色にして，成功を出力
            for (int i = targetvalue-adjustingvalue; i < special; i++)
            {
                appendtext = string.Format(
                    tableAttributePattern,
                    (i + adjustingvalue),
                    freqtable[i - 2],
                    (double)freqtable[i - 2] / dicevalues.Count);
                OutPutForm.AppendText(appendtext, Color.Blue);
            }


            //文字色を暗橙色にして，スペシャルを出力
            for (int i = special; i <= 12; i++)
            {
                appendtext = string.Format(
                    tableAttributePattern,
                    (i + adjustingvalue),
                    freqtable[i - 2],
                    (double)freqtable[i - 2] / dicevalues.Count);
                OutPutForm.AppendText(appendtext, Color.DarkOrange);
            }


            //各判定結果が出た割合を出力
            appendtext = string.Format(
                "ファンブル：{0,2:##%;;0%} " +
                "失敗：{1,2:##%;;0%}\n" +
                "成功：{2,2:##%;;0%} " +
                "スペシャル：{3,2:##%;;0%}\n",
                (double)resultstable[0] / dicevalues.Count,
                (double)resultstable[1] / dicevalues.Count,
                (double)resultstable[2] / dicevalues.Count,
                (double)resultstable[3] / dicevalues.Count);
            OutPutForm.AppendText(appendtext);
            #endregion
            //入力を消去
            ResultForm.Text = "";
        }
    }
    //LinqでMatchCollectionを扱えるように拡張しているらしい
    //AsEnumerable拡張メソッド
    public static class RegexExtension
    {
        public static IEnumerable<Match> AsEnumerable(this MatchCollection mc)
        {
            foreach (Match m in mc)
                yield return m;
        }
    }

    public static class RichTextBoxExtensions
    {

        //AppendTextの拡張メソッド
        //参照：https://stackoverflow.com/questions/1926264/color-different-parts-of-a-richtextbox-string
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}

