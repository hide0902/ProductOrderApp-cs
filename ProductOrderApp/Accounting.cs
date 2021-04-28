using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ProductOrderApp
{
    public partial class Accounting : Form
    {
        #region フィールド
        private Order order = new Order();
        // 合計金額(税抜き)
        private int _totalFee = 0;
        // 合計金額(税込み)
        private int _taxIncluded = 0;
        // 支払金額
        private int _payment = 0;
        // おつり
        private int _change = 0;
        // 注文履歴
        private List<string> _orderHistory = new List<string>();
        // 消費税率
        private double _tax = 0;
        // 注文数
        private int _orderCount = 0;
        // 店名
        private const string storeName = "○○水産";
        // レシート名
        private const string filename = "receiptProduct.txt";
        #endregion

        #region コンストラクタ
        // コンストラクタ
        public Accounting(int totalFee, List<string> orderHistory, double tax, int taxIncluded)
        {
            InitializeComponent();
            _totalFee = totalFee;
            _tax = tax;
            _taxIncluded = taxIncluded;
            foreach (string history in orderHistory)
            {
                _orderHistory.Add(history);
            }
            _orderCount = _orderHistory.Count();

        }
        #endregion

        #region プロパティ
        // 入力金額から税込み金額を引いておつりを計算しフィールド変数に代入
        public int change
        {
            set { _change = value - _taxIncluded; }
        }

        // フォームにて入力された金額をフィールド変数に代入
        public int payment
        {
            set { _payment = value; }
        }
        #endregion

        #region 清算ボタン
        // 清算ボタン
        private void liquidationButton_Click(object sender, EventArgs e)
        {
            // 入力された金額(文字列)を整数に変換できるかをチェック
            try
            {
                // 整数に変換し、自クラスのプロパティpaymentでフィールド変数に代入
                this.payment = int.Parse(paymentTextBox.Text);
                // 支払金額を自クラスのプロパティchangeに渡し、おつりを計算
                this.change = _payment;

                // おつりがあるかどうかで処理を分岐
                //　おつりがある場合は、おつりを表示し、自クラスreceipt()メソッドを呼び出してレシート出力
                // おつりがない場合は、丁度と表示し、自クラスreceipt()メソッドを呼び出してレシート出力
                // 支払金額が足りない場合は、不足金額を表示し、レシートは出力しない
                if (_change > 0)
                {
                    MessageBox.Show("おつりは\\" + _change.ToString("#,0") + "です。\nありがとうございました。");
                    receipt();
                    recoiptInput();
                    order.orderHistory();
                    this.Close();
                }
                else if (_change == 0)
                {
                    MessageBox.Show("\\" + _payment.ToString("#,0") + "円丁度いただきました。");
                    receipt();
                    recoiptInput();
                    order.orderHistory();
                    this.Close();
                }
                else if (_change < 0)
                {
                    int notEnough = _taxIncluded - _payment;
                    MessageBox.Show("後\\" + notEnough.ToString("#,0") + "足りません。");
                }
            }
            catch (Exception ex)
            {
                // 入力金額が空白、半角整数出ない場合に表示
                if (paymentTextBox.Text == "")
                {
                    MessageBox.Show("金額を入力してください");
                }
                else
                {
                    MessageBox.Show("金額は半角整数で入力してください。");
                }
            }
        }
        #endregion

        #region レシート出力
        // レシートを出力するメソッド
        public void receipt()
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(filename, true, Encoding.UTF8);
                writer.WriteLine(storeName);
                writer.WriteLine(" ");
                writer.WriteLine(DateTime.Now.ToString("yyyy年MM月dd日 HH時mm分"));
                writer.WriteLine("-------------------");
                foreach (string history in _orderHistory)
                {
                    writer.WriteLine(history);
                }
                writer.WriteLine("-------------------");
                writer.WriteLine("支払合計" + " " + "\\" + _taxIncluded);
                writer.WriteLine("ご注文数" + " " + _orderCount + "品");
                writer.WriteLine("お支払金額" + " " + "\\" + _payment);
                writer.WriteLine("おつり" + " " + "\\" + _change);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                writer.Close();
            }
        }
        #endregion

        #region レシート入力
        // レシートを入力するメソッド
        public void recoiptInput()
        {
            string line = "";
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(filename);
                while (!reader.EndOfStream)
                {
                    line += reader.ReadLine();
                    line += "\n";
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                reader.Close();
            }
        }
        #endregion

        #region 入力画面
        // 入力画面(3桁区切りで「,」)
        private void Accounting_Load(object sender, EventArgs e)
        {
            paymentDisplayTexBox.Text = _taxIncluded.ToString("#,0");
        }
        #endregion
    }
}
