﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sklep
{
    public partial class Form1 : Form
    {
        SKLEPEntities sklepEntities = new SKLEPEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetData_Click(object sender, EventArgs e)
        {
            DbSet<Drukarki> drukarki = sklepEntities.Drukarki;

        
        }
    }
}
