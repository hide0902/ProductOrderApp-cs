using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductOrderApp
{
    public partial class Order : Form
    {
        #region フィールド
        // ProductOrderクラスインスタンス化
        private ProductOrder productOrder = new ProductOrder();
        // ProductValueクラスインスタンス化
        private ProductValue productValue = new ProductValue();
        // 注文を受付て金額を計算するリスト(金額計算後に初期化)
        private List<string> _order = new List<string>();
        // 注文履歴を保存しておくリスト（レシート発行に使用）
        private List<string> _orderHistory = new List<string>();
        // 合計金額の変数（税抜き）
        private int _totalFree = 0;
        // 合計金額の変数（税込み）
        private int _taxIncluded = 0;
        // 消費税率の変数
        private const double _tax = 1.1;
        #endregion

        #region コンストラクタ
        public Order()
        {
            InitializeComponent();
        }
        #endregion
        public void orderHistory()
        {
            _orderHistory.Clear();
            _totalFree = 0;
            _taxIncluded = 0;
        }

        #region 注文ボタン
        // 注文ボタン、クリック後ProducutOrderクラスのCalculation()メソッドを呼び出し合計金額を計算する
        private void orderButton_Click(object sender, EventArgs e)
        {
            // if文で各チェックボックスがチェックされているかを判定し、チェックされている場合は_orderリストに追加する
            if (sashimiL.Checked == true) _order.Add(sashimiL.Text);
            if (sashimiM.Checked == true) _order.Add(sashimiM.Text);
            if (maguro.Checked == true) _order.Add(maguro.Text);
            if (buri.Checked == true) _order.Add(buri.Text);
            if (takobutsu.Checked == true) _order.Add(takobutsu.Text);
            if (chicken.Checked == true) _order.Add(chicken.Text);
            if (cartilage.Checked == true) _order.Add(cartilage.Text);
            if (tempura.Checked == true) _order.Add(tempura.Text);
            if (yakitori.Checked == true) _order.Add(yakitori.Text);
            if (tsukune.Checked == true) _order.Add(tsukune.Text);
            if (rose.Checked == true) _order.Add(rose.Text);
            if (tan.Checked == true) _order.Add(tan.Text);
            if (chanja.Checked == true) _order.Add(chanja.Text);
            if (kimchi.Checked == true) _order.Add(kimchi.Text);
            if (cabbage.Checked == true) _order.Add(cabbage.Text);
            if (pickles.Checked == true) _order.Add(pickles.Text);
            if (shelljuice.Checked == true) _order.Add(shelljuice.Text);
            if (beer.Checked == true) _order.Add(beer.Text);
            if (lemon.Checked == true) _order.Add(lemon.Text);
            if (grape.Checked == true) _order.Add(grape.Text);
            if (highball.Checked == true) _order.Add(highball.Text);
            if (jin.Checked == true) _order.Add(jin.Text);
           
            // foreach文で_orderリストから_orderHistoryリストにコピーする(_orderリストは、合計金額計算後初期化してしまう為)
            foreach (string history in _order)
            {
                _orderHistory.Add(history);
            }

            // チェックボックスがチェックさてているかを判定(1つもチェックされていないと、_orderリストが空の為falseになる)
            if (_order.Count > 0)
            {
                // ProductOrderクラスのCalculation()メソッドを呼び出し合計金額を計算(引数として_orderリストを渡す)
                int totalFree = productOrder.Calculation(_order);
                // ProductOrderクラスのtotalFee()メソッド(計算した合計金額のsetter)を呼び出し、自クラスのフィールド変数_totalFreeに足す)
                _totalFree += totalFree;
                // 税込み金額を計算し自クラスのフィールド変数_taxIncludedに代入(四捨五入し整数型に変換)
                _taxIncluded = (int)Math.Round(_totalFree * _tax);
                // メッセージボックスに現在の合計金額を表示(金額に3桁区切りに「,」を入れる)
                MessageBox.Show("注文を受け付けました。\n現在の合計金額\\" + _taxIncluded.ToString("#,0"));
            } else
            {
                // 1つもチェックされていない場合に表示
                MessageBox.Show("商品が選択されていません。");
            }
            // 注文ボタンクリック後にチェックボックスを全て初期化
            sashimiL.Checked = false;
            sashimiM.Checked = false;
            maguro.Checked = false;
            buri.Checked = false;
            takobutsu.Checked = false;
            chicken.Checked = false;
            cartilage.Checked = false;
            tempura.Checked = false;
            yakitori.Checked = false;
            tsukune.Checked = false;
            rose.Checked = false;
            tan.Checked = false;
            chanja.Checked = false;
            kimchi.Checked = false;
            cabbage.Checked = false;
            pickles.Checked = false;
            shelljuice.Checked = false; 
            beer.Checked = false;
            lemon.Checked = false;
            grape.Checked = false;
            highball.Checked = false;
            jin.Checked = false;
        }
        #endregion

        #region 会計ボタン
        // 会計ボタン
        private void accounting_Click(object sender, EventArgs e)
        {
            //　注文されているかを判定
            if (_totalFree > 0)
            {
                // Accountingクラスのインスタンスを生成(引数として、_totalFree, _orderHistory, _tax, _taxIncludedを渡す)
                Accounting accounting = new Accounting(_totalFree, _orderHistory, _tax, _taxIncluded);
                // Accountingのフォーム画面呼び出し(ShowDialog()の為、Accounting画面が表示中はその他の画面の操作ができなくなる)
                accounting.ShowDialog();
                _orderHistory.Clear();
                _totalFree = 0;
                _taxIncluded = 0;
            } else
            {
                MessageBox.Show("まだ商品が注文されていません");
            }
        }
        #endregion

        #region 商品名、価格の表示
        private void Order_Load(object sender, EventArgs e)
        {
            // ProductValueクラスの変数で設定されている値で、Orderフォーム画面の商品名、金額を表示
            sashimiL.Text = productValue.sashimiLName;
            sashimiLLabel.Text = "\\" + productValue.sashimiLPrice.ToString("#,0");
            sashimiM.Text = productValue.sashimiMName;
            sashimiMLabel.Text = "\\" + productValue.sashimiMPrice.ToString("#,0");
            maguro.Text = productValue.maguroName;
            maguroLabel.Text = "\\" + productValue.maguroPrice.ToString("#,0");
            buri.Text = productValue.buriName;
            buriLabel.Text = "\\" + productValue.buriPrice.ToString("#,0");
            takobutsu.Text = productValue.takobutsuName;
            takobutsuLabel.Text = "\\" + productValue.takobutsuPrice.ToString("#,0");
            chicken.Text = productValue.chickenName;
            chickenLabel.Text = "\\" + productValue.chickenPrice.ToString("#,0");
            cartilage.Text = productValue.cartilageName;
            cartilageLabel.Text = "\\" + productValue.cartilagePrice.ToString("#,0");
            tempura.Text = productValue.tempuraName;
            tempuraLabel.Text = "\\" + productValue.tempuraPrice.ToString("#,0");
            yakitori.Text = productValue.yakitoriName;
            yakitoriLabel.Text = "\\" + productValue.yakitoriPrice.ToString("#,0");
            tsukune.Text = productValue.tsukuneName;
            tsukuneLabel.Text = "\\" + productValue.tsukunePrice.ToString("#,0");
            rose.Text = productValue.roseName;
            roseLabel.Text = "\\" + productValue.rosePrice.ToString("#,0");
            tan.Text = productValue.tanName;
            tanLabel.Text = "\\" + productValue.tanPrice.ToString("#,0");
            chanja.Text = productValue.chanjaName;
            chanjaLabel.Text = "\\" + productValue.chanjaPrice.ToString("#,0");
            kimchi.Text = productValue.kimchiName;
            kimchiLabel.Text = "\\" + productValue.kimchiPrice.ToString("#,0");
            cabbage.Text = productValue.cabbageName;
            cabbageLabel.Text = "\\" + productValue.cabbagePrice.ToString("#,0");
            pickles.Text = productValue.picklesName;
            picklesLabel.Text = "\\" + productValue.picklesPrice.ToString("#,0");
            shelljuice.Text = productValue.shelljuiceName;
            shelljuiceLabel.Text = "\\" + productValue.shelljuicePrice.ToString("#,0");
            beer.Text = productValue.beerName;
            beerLabel.Text = "\\" + productValue.beerPrice.ToString("#,0");
            lemon.Text = productValue.lemonName;
            lemonLabel.Text = "\\" + productValue.lemonPrice.ToString("#,0");
            grape.Text = productValue.grapeName;
            grapeLabel.Text = "\\" + productValue.grapePrice.ToString("#,0");
            highball.Text = productValue.highballName;
            highballLabel.Text = "\\" + productValue.highballPrice.ToString("#,0");
            jin.Text = productValue.jinName;
            jinLabel.Text = "\\" + productValue.jinPrice.ToString("#,0");
        }
        #endregion
    }
}
