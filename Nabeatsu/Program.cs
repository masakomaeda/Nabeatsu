using System;
using System.Linq;

namespace SMax.NewCore21.MorningProject.Nabeatsu
{
    class Program
    {
        /// <summary>
        /// メイン
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //*** ユーザーに値の入力を促す
            Console.WriteLine("１からＮまでの数値を世界的な表現で表します");
            Console.Write("Ｎ（数値）＝？");
            var inputStr = Console.ReadLine();

            //*** 文字、負数は処理対象外とする。
            if (!int.TryParse(inputStr,out int inputNum))
            {
                Console.WriteLine("あなたは日本レベルです、さようなら");
            }
            else if (inputNum <= 0)
            {
                Console.WriteLine("あなたアジアレベルです、さようなら");
            }
            else
            {
                var normalNum = Enumerable.Range(1, inputNum);
                var woldTransNum = normalNum.Select(n => new WorldTrans(n).ToString());
                var outputStr = string.Join(",", woldTransNum);

                //*** 結果を出力して終了
                Console.WriteLine(outputStr);
            }
        }
    }
}
