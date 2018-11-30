using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BackToDoTheFuture
{
    class ThreadLogics
    {
        // 定数定義
        private const string SOUND_FILE_NAME = @"Siren.mp3";

        // 変数定義
        private string nowPath = System.IO.Directory.GetCurrentDirectory();
        private List<string> todoList = new List<string>();
        private DateTime dtNext = DateTime.Now.AddSeconds(-1); // 仮に現在の1秒前を設定しておく
        private string nextTodoStr = "";
        private Boolean isNotified = true;
        private Boolean isTaskEnd = false;
        private Task tsk;

        // Windows Media Player を利用する準備（.NET Framework 4以上対応）
        // 参照url　https://qiita.com/fujieda/items/d8642eae891d096d4028
        // 参照url　https://msdn.microsoft.com/ja-jp/library/cc429720.aspx
        private readonly dynamic _wmp = Activator.CreateInstance(Type.GetTypeFromProgID("WMPlayer.OCX.7"));


        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ThreadLogics()
        {
            tsk = new Task(this.CheckingThread);

            tsk.Start();
        }


        /// <summary>
        /// 終了処理
        /// </summary>
        private void ThreadEnd()
        {
            // Task修了フラグをセット
            this.isTaskEnd = true;

            // Taskの終了処理
            tsk.Wait();
            tsk.Dispose();

            return;
        }


        /// <summary>
        /// setter
        /// </summary>
        public void SetTaskEnd()
        {
            this.isTaskEnd = true;

            return;
        }

        public void SetIsNotified()
        {
            this.isNotified = true;

            return;
        }

        public void SetToDoData(string[] todo)
        {
            this.todoList.Clear();

            this.todoList.AddRange(todo);

            return;
        }
        

        /// <summary>
        /// 通知音の再生
        /// </summary>
        public void PlaySound()
        {
            _wmp.URL = Directory.GetParent(nowPath) + "\\BTDTF_sound\\" + SOUND_FILE_NAME;
            _wmp.Controls.play();
            
            return;
        }


        /// <summary>
        /// 通知音の停止
        /// </summary>
        public void StopSound()
        {
            _wmp.Controls.Stop();

            return;
        }


        /// <summary>
        /// スレッド（ToDoのチェック用）
        /// </summary>
        private void CheckingThread()
        {
            // フラグがセットされるまでは無限ループ
            while(!isTaskEnd)
            {
                // 現在のDateTime
                DateTime dtNow = DateTime.Now;

                // 通知日時が来たとき
                if((dtNow >= dtNext) && !this.isNotified)
                {
                    MainPanel.SetNotifiedToDo(this.nextTodoStr);
                    this.PlaySound();

                    this.isNotified = true;
                }

                Thread.Sleep(100);
            }

            return;
        }


        /// <summary>
        /// 次のToDoを検索する
        /// </summary>
        public ToDoData SearchNextToDo(DateTime nowDateTime)
        {
            int maxList = this.todoList.Count;
            ToDoData td;
            for (int i = 0; i < maxList; i++)
            {
                td = ToDoData.GetToDoDataSet(todoList[i]);

                string destDateTimeStr = string.Format("{0}/{1}/{2} {3}:{4}:00",
                    td.GetToDoYear(), td.GetToDoMonth(), td.GetToDoDay(), td.GetToDoHour(), td.GetToDoMinute()
                );
                DateTime destDateTime = Convert.ToDateTime(destDateTimeStr);

                if (nowDateTime < destDateTime)
                {
                    // 通知済みなら次のToDoをセットする
                    if(this.isNotified)
                    {
                        this.dtNext = destDateTime;
                        this.nextTodoStr = td.GetToDoDetail();
                        this.isNotified = false;
                    }

                    // 次のToDoを返す
                    return td;
                }
            }

            // 該当ToDoがない時はnullを返す
            return null;
        }



    }
}
