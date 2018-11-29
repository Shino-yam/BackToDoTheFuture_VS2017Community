using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BackToDoTheFuture
{
    class ToDoData
    {
        // 定数定義
        public const string DATA_FILE_PATH = @"..\BTDTF_data\ToDoData.txt"; 


        // 変数定義
        private string todoId = "";
        private int todoYear = 2018;
        private int todoMonth = 1;
        private int todoDay = 1;
        private int todoHour = 0;
        private int todoMinute = 0;
        private string todoDetail = "";
        private Boolean isDeleted = false;


        /// <summary>
        /// ToDoデータ（リスト表示用）の作成
        /// </summary>
        /// <returns></returns>
        public string OutputToDo()
        {
            string todo = string.Format("{0,0:D4}/{1,0:D2}/{2,0:D2} {3,0:D2}:{4,0:D2} {5:S40} [id:{6}]",
                this.todoYear, this.todoMonth, this.todoDay, this.todoHour, this.todoMinute, this.todoDetail, this.todoId
            );

            return todo;
        }
        

        /// <summary>
        /// 文字列からToDoクラスに変換する
        /// </summary>
        /// <returns></returns>
        public static ToDoData GetToDoDataSet(string todoStr)
        {
            ToDoData td = new ToDoData();

            // 日時
            MatchCollection matches = Regex.Matches(todoStr, "[0-9]{2,4}");
            td.todoYear = Convert.ToInt32(matches[0].ToString());
            td.todoMonth = Convert.ToInt32(matches[1].ToString());
            td.todoDay = Convert.ToInt32(matches[2].ToString());
            td.todoHour = Convert.ToInt32(matches[3].ToString());
            td.todoMinute = Convert.ToInt32(matches[4].ToString());
            // ToDo詳細，ID
            string[] tempStr = todoStr.Split(' ');
            td.todoDetail = "";
            for (int i = 2; i < (tempStr.Length - 1); i++)
            {
                td.todoDetail += tempStr[i] + " ";
            }
            td.todoDetail = td.todoDetail.Trim(' ');
            td.todoId = tempStr[tempStr.Length - 1];

            return td;
        }


        /// <summary>
        /// ファイルに保存
        /// </summary>
        /// <param name="datas"></param>
        public static void WriteFile(string[] datas)
        {
            StreamWriter sw = new StreamWriter(DATA_FILE_PATH, false);
            for(int i = 0; i < datas.Length; i++)
            {
                sw.WriteLine(datas[i]);
            }
            sw.Flush();
            sw.Close();

            return;
        }


        /// <summary>
        /// ファイルから読み込み
        /// </summary>
        /// <returns></returns>
        public static string[] ReadFile()
        {
            StreamReader sr = new StreamReader(DATA_FILE_PATH);
            string temp = sr.ReadToEnd().Replace("\r", "").Trim('\n');
            sr.Close();

            string[] ret = temp.Split('\n');
            
            return ret;
        }


        /// <summary>
        /// setter
        /// </summary>
        public void SetToDo(string id, int year, int month, int day, int hour, int minute, string detail)
        {
            this.todoId = id;
            this.todoYear = year;
            this.todoMonth = month;
            this.todoDay = day;
            this.todoHour = hour;
            this.todoMinute = minute;
            this.todoDetail = detail;

            return;
        }

        public void SetDeletedFlg(Boolean flg)
        {
            this.isDeleted = flg;
        }


        /// <summary>
        /// getter
        /// </summary>
        /// <returns></returns>
        public string GetToDoId()
        {
            return this.todoId;
        }

        public int GetToDoYear()
        {
            return this.todoYear;
        }

        public int GetToDoMonth()
        {
            return this.todoMonth;
        }

        public int GetToDoDay()
        {
            return this.todoDay;
        }

        public int GetToDoHour()
        {
            return this.todoHour;
        }

        public int GetToDoMinute()
        {
            return this.todoMinute;
        }

        public string GetToDoDetail()
        {
            return this.todoDetail;
        }

        public Boolean GetDeleteFlg()
        {
            return this.isDeleted;
        }
        

    }
}
