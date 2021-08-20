﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CircleRacing
{
    public partial class Finish : Form
    {
        public Finish()
        {
            InitializeComponent();
        }

        //Запуск гонки
        private void Repeat_B_Click(object sender, EventArgs e)
        {
            new Visualization().Show();
            this.Hide();
        }


        //Возврат к стартовому меню
        private void BackMenu_B_Click(object sender, EventArgs e)
        {
            new Start_menu().Show();
            this.Hide();
        }
    }
}
