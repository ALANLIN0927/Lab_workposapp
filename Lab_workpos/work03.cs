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
using static Lab_workpos.work3;

namespace Lab_workpos
{
    public partial class work03 : Form
    {
        public work03()
        {
            InitializeComponent();
        }
        int beercount = 0;
        decimal beertotal;
        string beerword;
        private void btnbeer_Click(object sender, EventArgs e)
        {
            Product beer;
            beer.Name = "啤酒Beer";
            beer.price = 120;
            beercount++;
            beertotal = beercount * beer.price;
            beerword=$"{beer.Name}*{beercount},共$NT{beertotal}元"                  ;
            listtxt.Text = beerword +"\n"+ dragonword +whiskyword + redbeefword;
            label2.Text = "NT:" + (redbeefcount * 320 + whiskycount * 350 + dragoncount * 180 + beercount * 120).ToString();
        }
        int dragoncount = 0;
        string dragonword;
        private void btndragon_Click(object sender, EventArgs e)
        {
            Product dragon;
            dragon.Name = "龍蛇蘭";
            dragon.price = 180;
            dragoncount++;
            decimal dragontotal;
            dragontotal = dragoncount * dragon.price;
            dragonword = $"{dragon.Name}*{dragoncount},共$NT{dragontotal}元 ";
            listtxt.Text = beerword + "\n" + dragonword + whiskyword + redbeefword;
            label2.Text = "NT:"+(redbeefcount * 320 + whiskycount * 350 + dragoncount * 180 + beercount * 120).ToString();
        }
        int whiskycount = 0;
        string whiskyword;
        private void btnwiski_Click(object sender, EventArgs e)
        {
            Product whisky;
            whisky.Name = "威士忌";
            whisky.price = 350;
            whiskycount++;
            decimal whiskytotal;
            
            whiskytotal = whiskycount * whisky.price;
            whiskyword = $"{whisky.Name}*{whiskycount},共$NT{whiskytotal}元 ";
            listtxt.Text = beerword+ "\n-------" + dragonword + whiskyword + redbeefword;
            label2.Text ="NT:"+ (redbeefcount * 320 + whiskycount * 350 + dragoncount * 180 + beercount * 120).ToString();
        }
        int redbeefcount = 0;
        string redbeefword;
        private void redbeer_Click(object sender, EventArgs e)
        {
            Product redbeef;
            redbeef.Name = "紅酒";
            redbeef.price = 320;
            redbeefcount++;
            decimal redbeeftotal ;
            redbeeftotal = redbeefcount * redbeef.price;
            redbeefword = $"{redbeef.Name}*{whiskycount},共$NT{redbeeftotal}元 ";
            listtxt.Text = beerword + "\n--------" + dragonword + whiskyword+redbeefword;

            label2.Text = "NT:"+(redbeefcount * 320 + whiskycount * 350 + dragoncount * 180 + beercount * 120).ToString();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            listtxt.Text = null;  
        }

        private void cash_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label2.Text);
        }

        private void creditcard_Click(object sender, EventArgs e)
        {
            
            int b = (redbeefcount * 320 + whiskycount * 350 + dragoncount * 180 + beercount * 120);
            decimal c = b * 0.9m;
            string a;
            string d;
            a = c.ToString();
            d = b.ToString();
            MessageBox.Show("總共:"+b+"元"+"\n"+"折扣後為:"+a+"元");
            
        }
        //public  totalprice()
        //{
        //    int fullprice = redbeefcount * 320 + whiskycount * 350 + dragoncount * 180 + beercount * 120;

        //}
    }
}
