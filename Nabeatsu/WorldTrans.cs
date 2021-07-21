using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMax.NewCore21.MorningProject.Nabeatsu
{
    /// <summary>
    /// 与えられた数値を世界的な表現に変換するクラス
    /// </summary>
    public sealed class WorldTrans 
    {
        #region    定数
        private const int    KEYCODE = 3;
        private const string KEYWORD = "aho";
        #endregion 定数

        #region    プライベートメンバ
        private int _value;
        #endregion プライベートメンバ

        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="value">変換処理対象となる数字</param>
        public WorldTrans(int value)
        {
            _value = value;
        }

        /// <summary>
        /// ToStringのオーバーライド
        /// </summary>
        /// <returns>コンストラクタで指定された数値を変換処理した結果</returns>
        public override string ToString()
        {
            return ChangeToWorldNum();
        }

        #region    プライベートメソッド
        /// <summary>
        /// 変換処理
        /// </summary>
        /// <returns></returns>
        private string ChangeToWorldNum()
        {
            var ret = _value.ToString();

            // 3(KEYCODE)の倍数かそれが含まれるときはaho(KEYWORD)を返す
            if (_value % KEYCODE == 0)
            {
                ret = KEYWORD;
            }
            else if (ret.Contains(KEYCODE.ToString()))
            {
                ret = KEYWORD;
            }

            return ret;
        }
        #endregion プライベートメソッド

    }
}
