using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductOrderApp
{
    // 注文リストを元に合計金額を計算するクラス
    class ProductOrder
    {
        // 合計金額の変数
        //private int _totalFee = 0;
        // ProductValueクラスインスタンス化
        #region フィールド
        ProductValue productValue = new ProductValue();
        #endregion

        public ProductOrder()
        {   
        }

        #region プロパティ
        //_totalFeeのプロパティ
        //public int totalFee
        //{
        //    get { return _totalFee; }
        //}
        #endregion

        #region 計算メソッド
        // 注文リストを元に合計金額を計算するメソッド
        public int Calculation(List<string> _order)
        {
            
            // _totalFee初期化
            int _totalFee = 0;

            // _orderリストをforeachで展開し、if文で金額を照合し自クラスのフィールド変数に足す
            foreach (string order in _order)
            {
                // ProductValueクラスの変数で設定されている値を使用
                if (order == productValue.sashimiLName)
                {
                    _totalFee += productValue.sashimiLPrice;
                } else if (order == productValue.sashimiMName)
                {
                    _totalFee += productValue.sashimiMPrice;
                } else if (order == productValue.maguroName) 
                {
                    _totalFee += productValue.maguroPrice;
                } else if (order == productValue.buriName)
                {
                    _totalFee += productValue.buriPrice;
                } else if (order == productValue.takobutsuName)
                {
                    _totalFee += productValue.takobutsuPrice;
                } else if (order == productValue.chickenName)
                {
                    _totalFee += productValue.chickenPrice;
                } else if (order == productValue.cartilageName)
                {
                    _totalFee += productValue.cartilagePrice;
                } else if (order == productValue.tempuraName)
                {
                    _totalFee += productValue.tempuraPrice;
                } else if (order == productValue.yakitoriName)
                {
                    _totalFee += productValue.yakitoriPrice;
                } else if (order == productValue.roseName)
                {
                    _totalFee += productValue.rosePrice;
                } else if (order == productValue.tanName)
                {
                    _totalFee += productValue.tanPrice;
                } else if (order == productValue.chanjaName)
                {
                    _totalFee += productValue.chanjaPrice;
                } else if (order == productValue.kimchiName)
                {
                    _totalFee += productValue.kimchiPrice;
                } else if (order == productValue.cabbageName)
                {
                    _totalFee += productValue.cabbagePrice;
                } else if (order == productValue.picklesName)
                {
                    _totalFee += productValue.picklesPrice;
                } else if (order == productValue.shelljuiceName)
                {
                    _totalFee += productValue.shelljuicePrice;
                } else if (order == productValue.beerName)
                {
                    _totalFee += productValue.beerPrice;
                } else if (order == productValue.lemonName)
                {
                    _totalFee += productValue.lemonPrice;
                } else if (order == productValue.grapeName)
                {
                    _totalFee += productValue.grapePrice;
                } else if (order == productValue.highballName)
                {
                    _totalFee += productValue.highballPrice;
                } else if (order == productValue.jinName)
                {
                    _totalFee += productValue.jinPrice;
                }
            }
            // _order リスト初期化
            _order.Clear();
            return _totalFee;
        }
        #endregion
    }
}
