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

namespace BackToDoTheFuture
{
    public partial class ToDoSetPanel : Form
    {
        // 変数宣言
        private string exToDo = "";


        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ToDoSetPanel()
        {
            InitializeComponent();

            // DateTimePicker にカスタムフォーマットを適用
            this.dateTimePickerToDoDate.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerToDoDate.CustomFormat = "yyyy年MM月dd日";
            this.dateTimePickerToDoTime.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerToDoTime.CustomFormat = "HH時mm分";

            // DateTimePicker に現在の日時をセット
            this.SetNowDateTime();

            // ファイルから読み込み
            string[] datas = ToDoData.ReadFile();
            this.checkedListBoxToDoList.Items.AddRange(datas);

            return;
        }


        /// <summary>
        /// 「登録」ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSet_Click(object sender, EventArgs e)
        {
            // ToDoID用の現在日時を取得
            DateTime nowDt = DateTime.Now;
            string todoId = string.Format("{0,0:D4}{1,0:D2}{2,0:D2}{3,0:D2}{4,0:D2}{5,0:D2}{6,0:D3}",
                nowDt.Year, nowDt.Month, nowDt.Day, nowDt.Hour, nowDt.Minute, nowDt.Second, nowDt.Millisecond    
            );

            // DateTimePicker の値取得
            DateTime setDate = this.dateTimePickerToDoDate.Value;
            DateTime setTime = this.dateTimePickerToDoTime.Value;

            // 過去チェック
            string checkDateTimeStr = string.Format("{0,0:D4}/{1,0:D2}/{2,0:D2} {3,0:D2}:{4,0:D2}:00",
                setDate.Year, setDate.Month, setDate.Day, setTime.Hour, setTime.Minute
            );
            DateTime checkDateTime = Convert.ToDateTime(checkDateTimeStr);

            if(DateTime.Now > checkDateTime)
            {
                DialogResult dlgResult = MessageBox.Show(
                    "過去のToDoを設定すると，タイムスリップが必要になりますがよろしいですか？",
                    "ToDoが過去です",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation
                );

                if(dlgResult == DialogResult.No)
                {
                    return;
                }

            }

            // ToDo の取得
            string todoDetail = this.textBoxToDoDetail.Text;
            if(todoDetail.Length == 0)
            {
                todoDetail = "(ToDo詳細未記入)";
            }

            // ToDoクラスに登録
            ToDoData todo = new ToDoData();
            todo.SetToDo(todoId, setDate.Year, setDate.Month, setDate.Day, setTime.Hour, setTime.Minute, todoDetail);
            string todoStr = todo.OutputToDo();

            if(this.exToDo.Length > 0)
            {
                this.checkedListBoxToDoList.Items.Remove(exToDo);
                this.exToDo = "";
            }
            this.checkedListBoxToDoList.Items.Add(todoStr);

            // ソート
            int todoMax = this.checkedListBoxToDoList.Items.Count;
            string[] tempArray = new string[todoMax];
            this.checkedListBoxToDoList.Items.CopyTo(tempArray, 0);
            Array.Sort(tempArray);
            this.checkedListBoxToDoList.Items.Clear();
            this.checkedListBoxToDoList.Items.AddRange(tempArray);


            return;
        }


        /// <summary>
        /// 「キャンセル」ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>new 
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // DateTimePicker に現在の日時をセット
            this.SetNowDateTime();

            // ToDo詳細を削除
            this.textBoxToDoDetail.Text = "";

            // exToDo を削除
            this.exToDo = "";

            return;
        }


        /// <summary>
        /// 「チェックしたToDoを削除」ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int chk = this.checkedListBoxToDoList.CheckedItems.Count;
            string[] chkItems = new string[chk];
            this.checkedListBoxToDoList.CheckedItems.CopyTo(chkItems, 0);
            for(int i = 0; i < chk; i++)
            {
                this.checkedListBoxToDoList.Items.Remove(chkItems[i]);
            }

            return;
        }


        /// <summary>
        /// リスト項目を選択したときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkedListBoxToDoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 選択しているToDoを文字列として取得
            int index = this.checkedListBoxToDoList.SelectedIndex;
            if(index < 0)
            {
                index = 0;
            }
            string selectedToDo = this.checkedListBoxToDoList.Items[index].ToString();
            this.exToDo = selectedToDo;

            // 入力欄に反映
            ToDoData td = ToDoData.GetToDoDataSet(selectedToDo);
            // 年月日
            string dateStr = string.Format("{0,0:D4}/{1,0:D2}/{2,0:D2}", td.GetToDoYear(), td.GetToDoMonth(), td.GetToDoDay());
            DateTime dtDate = Convert.ToDateTime(dateStr);
            this.dateTimePickerToDoDate.Value = dtDate;
            // 時刻
            string timeStr = string.Format("{0,0:D2}:{1,0:D2}:00", td.GetToDoHour(), td.GetToDoMinute());
            DateTime dtTime = Convert.ToDateTime(timeStr);
            this.dateTimePickerToDoTime.Value = dtTime;
            // ToDo詳細
            this.textBoxToDoDetail.Text = td.GetToDoDetail();

            return;
        }


        /// <summary>
        /// フォームを閉じるときに，データを保存する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToDoSetPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            int max = this.checkedListBoxToDoList.Items.Count;
            string[] datas = new string[max];
            this.checkedListBoxToDoList.Items.CopyTo(datas, 0);
            ToDoData.WriteFile(datas);

            return;
        }


        /// <summary>
        /// DateTimePicker に現在の日時をセットする
        /// </summary>
        private void SetNowDateTime()
        {
            DateTime dt = DateTime.Now;
            this.dateTimePickerToDoDate.Value = dt;
            this.dateTimePickerToDoTime.Value = dt;

            return;
        }

    }
}
