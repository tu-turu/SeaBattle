﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab3KPO
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool online
        {
            get;
            set;
        }

        private byte our_field
        {
            get;
            set;
        }

        private byte op_field
        {
            get;
            set;
        }

        private bool our_turn
        {
            get;
            set;
        }

        	public virtual void Field1()
	{
		throw new System.NotImplementedException();
	}

	public virtual void Field2()
	{
		throw new System.NotImplementedException();
	}

	public virtual void ShowWin()
	{
		throw new System.NotImplementedException();
	}

	public virtual void ShowLose()
	{
		throw new System.NotImplementedException();
	}

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
