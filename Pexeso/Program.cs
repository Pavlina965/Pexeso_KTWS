﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pexeso
{
    static class Program
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        public static ScoreDatabase Database;

        public static ScoreDatabase ScoreDatabase
        {
            get
            {
                if (Database == null)
                {
                    var fileHelper = new FileHelper();
                    Database = new ScoreDatabase(fileHelper.GetLocalFilePath("database.db3"));
                }
                return Database;
            }
        }
    }

}
