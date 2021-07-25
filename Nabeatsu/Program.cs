using System;
using System.Linq;

namespace SMax.NewCore21.MorningProject.Nabeatsu
{
    class Program
    {
        /// <summary>
        /// メイン処理
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //*** ユーザーに値の入力を促す
            Console.WriteLine("１からＮまでの数値を世界的な表現で表します");
            Console.Write("Ｎ（数値）＝？");

            if (TryGetInputNum(Console.ReadLine(), out int inputNum))
            {
                var normalNum = Enumerable.Range(1, inputNum);
                var worldTransNum = normalNum.Select(n => new WorldTrans(n).ToString());
                var outputStr = string.Join(",", worldTransNum);

                //*** 結果を出力して終了
                Console.WriteLine(outputStr);
            }

            Console.WriteLine("オモロー！");
        }

        /// <summary>
        /// ユーザー入力値のチェックを行う
        /// </summary>
        /// <param name="inputStr">ユーザーの入力値</param>
        /// <param name="inputNum">数値に変換できたらその値、できないときはゼロ</param>
        /// <returns>数値に変換できたらTrue,できなかったらユーザーの頭脳レベルをコンソールへ表示しFalse</returns>
        static bool TryGetInputNum(string inputStr, out int inputNum)
        {
            if (int.TryParse(inputStr,out inputNum))
            {
                //*** 負数は処理対象外とする
                if (inputNum <= 0)
                {
                    Console.WriteLine("あなたはアジアレベルです、さようなら");
                    return false;
                }
            }
            else
            {
                //*** 数値以外は処理対象外とする
                Console.WriteLine("あなたは日本レベルです、さようなら");
                return false;
            }
 
            return true;
        }
         
    }
}
