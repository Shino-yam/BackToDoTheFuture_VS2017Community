using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackToDoTheFuture
{
    public partial class MainPanel : Form
    {
        // 変数定義
        private Boolean isVisibleColon = true;
        private string[] monthStr = new string[]
        {
            "---", "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC"
        };
        private int presentYear = 2018;
        private int presentMonth = 1;
        private int presentDay = 1;
        private int presentHour = 0;
        private int presentMinute = 0;
        private int presentSecond = 0;
        private static string notifiedToDo = "";
        private Boolean isBlinkedNotifiedToDo = false;
        ThreadLogics th;

        // 定数定義
        private const string FONT_7SEG = @"..\BTDTF_fonts\DSEG7Modern-RegularItalic.ttf"; // 7セグメントフォント
        private const string FONT_14SEG = @"..\BTDTF_fonts\DSEG14Modern-RegularItalic.ttf"; // 14セグメントフォント
        private const string FONT_DETAIL = @"..\BTDTF_fonts\KH-Dot-Hibiya-24.ttf"; // DETAIL用KHフォント

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainPanel()
        {
            InitializeComponent();

            th = new ThreadLogics();

            this.SetFont();
            this.buttonToDoSet.Focus();

            this.ReadDataFile();

        }


        /// <summary>
        /// ToDo設定ダイアログを表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonToDoSet_Click(object sender, EventArgs e)
        {
            ToDoSetPanel todoSet = new ToDoSetPanel();
            todoSet.ShowDialog();

            th.SetIsNotified();

            // 更新されたデータファイルを読み込む
            this.ReadDataFile();

            this.Refresh();

            return;
        }


        /// <summary>
        /// 通知済みToDoの点滅を停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBlinkStop_Click(object sender, EventArgs e)
        {
            this.isBlinkedNotifiedToDo = false;

            th.StopSound();

            this.textBoxNotifiedToDo.ForeColor = Color.Red;
            this.textBoxNotifiedToDo.BackColor = Color.Black;

            return;
        }


        /// <summary>
        /// 前のToDoを表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPrev_Click(object sender, EventArgs e)
        {
            // 時間不足で未実装
        }


        /// <summary>
        /// 次のToDoを表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNext_Click(object sender, EventArgs e)
        {
            // 時間不足で未実装
        }


        /// <summary>
        /// Timer（現在日時の取得と表示制御）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerGetPresent_Tick(object sender, EventArgs e)
        {
            // 現在の日時を取得
            DateTime dtNow = DateTime.Now;

            // 項目別に分解
            this.presentYear = dtNow.Year;
            this.presentMonth = dtNow.Month;
            this.presentDay = dtNow.Day;
            this.presentHour = dtNow.Hour;
            this.presentMinute = dtNow.Minute;
            this.presentSecond = dtNow.Second;

            // 月を英字3文字に変換
            string presentMonthStr = this.monthStr[this.presentMonth];

            // formに表示
            this.textBoxPresentYear.Text = string.Format("{0,0:D4}", presentYear);
            this.textBoxPresentMonth.Text = presentMonthStr;
            this.textBoxPresentDay.Text = string.Format("{0,0:D2}", presentDay);
            this.textBoxPresentHour.Text = string.Format("{0,0:D2}", presentHour);
            this.textBoxPresentMinute.Text = string.Format("{0,0:D2}", presentMinute);
            this.textBoxPresentSecond.Text = string.Format("{0,0:D2}", presentSecond);

            // ":" の点滅
            if(this.isVisibleColon)
            {
                this.labelPresentHM.Visible = true;
                this.labelPresentMS.Visible = true;
            }
            else
            {
                this.labelPresentHM.Visible = false;
                this.labelPresentMS.Visible = false;
            }
            this.isVisibleColon = (this.isVisibleColon) ? false : true;

            // 次のToDoを表示
            ToDoData td = th.SearchNextToDo(dtNow);

            if (td == null)
            {
                // formに表示
                this.textBoxToDoYear.Text = "----";
                this.textBoxToDoMonth.Text = "---";
                this.textBoxToDoDay.Text = "--";
                this.textBoxToDoHour.Text = "--";
                this.textBoxToDoMinute.Text = "--";
                this.textBoxToDoDetail.Text = "未来のToDoがありません。";
            }
            else
            {
                // formに表示
                this.textBoxToDoYear.Text = string.Format("{0,0:D4}", td.GetToDoYear());
                this.textBoxToDoMonth.Text = this.monthStr[td.GetToDoMonth()];
                this.textBoxToDoDay.Text = string.Format("{0,0:D2}", td.GetToDoDay());
                this.textBoxToDoHour.Text = string.Format("{0,0:D2}", td.GetToDoHour());
                this.textBoxToDoMinute.Text = string.Format("{0,0:D2}", td.GetToDoMinute());
                this.textBoxToDoDetail.Text = td.GetToDoDetail();

            }

            // 通知済みToDoがあれば表示
            if(notifiedToDo.Length > 0)
            {
                this.isBlinkedNotifiedToDo = true;
                this.textBoxNotifiedToDo.Text = notifiedToDo;

                notifiedToDo = "";
            }

            // 表示を点滅させる
            if (isBlinkedNotifiedToDo)
            {
                if (this.isVisibleColon)
                {
                    this.textBoxNotifiedToDo.ForeColor = Color.Red;
                    this.textBoxNotifiedToDo.BackColor = Color.Black;
                }
                else
                {
                    this.textBoxNotifiedToDo.ForeColor = Color.Black;
                    this.textBoxNotifiedToDo.BackColor = Color.Red;
                }
            }

            return;
        }


        /// <summary>
        /// フォントの設定
        /// </summary>
        private void SetFont()
        {
            //PrivateFontCollectionオブジェクトを作成する
            System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
            
            //PrivateFontCollectionにフォントを追加する
            pfc.AddFontFile(FONT_7SEG);
            pfc.AddFontFile(FONT_14SEG);
            pfc.AddFontFile(FONT_DETAIL);

            //PrivateFontCollectionの先頭のフォントのFontオブジェクトを作成する
            System.Drawing.Font fontDetail = new System.Drawing.Font(pfc.Families[2], 24);
            System.Drawing.Font font7seg = new System.Drawing.Font(pfc.Families[1], 45);
            System.Drawing.Font font14seg = new System.Drawing.Font(pfc.Families[0], 45);

            //textBoxコントロールのフォントに設定する
            //  "PRESENT TIME"
            this.textBoxPresentYear.Font = font7seg;
            this.textBoxPresentMonth.Font = font14seg;
            this.textBoxPresentDay.Font = font7seg;
            this.textBoxPresentHour.Font = font7seg;
            this.textBoxPresentMinute.Font = font7seg;
            this.textBoxPresentSecond.Font = font7seg;
            //  "TODO TIME"
            this.textBoxToDoDay.Font = font7seg;
            this.textBoxToDoMonth.Font = font14seg;
            this.textBoxToDoYear.Font = font7seg;
            this.textBoxToDoHour.Font = font7seg;
            this.textBoxToDoMinute.Font = font7seg;
            // "TODO DETAIL"
            this.textBoxToDoDetail.Font = fontDetail;
            // "NOTIFIED TODO"
            this.textBoxNotifiedToDo.Font = fontDetail;

            // 始末
            pfc.Dispose();

            return;
        }


        /// <summary>
        /// 通知済みToDoのsetter
        /// </summary>
        /// <param name="todoStr"></param>
        public static void SetNotifiedToDo(string todoStr)
        {
            notifiedToDo = todoStr;
        }


        /// <summary>
        /// データファイルの読み込み
        /// </summary>
        private void ReadDataFile()
        {
            string[] temp = ToDoData.ReadFile();

            th.SetToDoData(temp);

            return;
        }


        /// <summary>
        /// Formを閉じるときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            // スレッドの終了
            th.SetTaskEnd();
        }
    }
}
