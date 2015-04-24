﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GaMMBo.Test
{

    static class Controller
    {
        public static bool guest = false;
        public static MainForm frmMain = new MainForm();
        public static LoginForm frmLogin = new LoginForm();
        public static CategoriesForm frmCategories = new CategoriesForm();
        public static PrefMenu frmPref = new PrefMenu();
        public static ResultsForm frmResults = new ResultsForm();

        public static String catName;


        public static int getUserId()
        {
            return Account.getUserId();
        }

        public static void createTemproraryAccount()
        {
            Account.createTemproraryAccount();
        }
        public static void deleteTemproraryAccount()
        {
            Account.deleteTemproraryAccount();
        }

        public static void login(string userName, string password)
        {
            Account.login(userName, password);
        }

        public static void addUser(string userName, string password1, string password2)
        {
            Account.addUser(userName, password1, password2);
        }
        public static void getResults()
        {

            //int[] categoryIds = Searching.topTenSearch();


            String catName = "";
            catName = Controller.catName + "_Images";


            //frmResults.top1.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[0].ToString() + ".jpg");
            //frmResults.top2.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[1].ToString() + ".jpg");
            //frmResults.top3.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[2].ToString() + ".jpg");
            //frmResults.top4.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[3].ToString() + ".jpg");
            //frmResults.top5.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[4].ToString() + ".jpg");
            //frmResults.top6.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[5].ToString() + ".jpg");
            //frmResults.top7.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[6].ToString() + ".jpg");
            //frmResults.top8.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[7].ToString() + ".jpg");
            //frmResults.top9.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[8].ToString() + ".jpg");
            //frmResults.top10.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[9].ToString() + ".jpg");

        }






















        // entry point of program
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Controller.frmMain);

            // buttons call proxy methods directly
            // it seems overly redundant to have methods that call methods


            // searchs will be methods in controller

        }

    }
}