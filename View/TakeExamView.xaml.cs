﻿using ExamifyX.ViewModel;
using System;
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

namespace ExamifyX.View
{
	/// <summary>
	/// Interaction logic for TakeExamView.xaml
	/// </summary>
	public partial class TakeExamView : UserControl
	{
		public TakeExamView()
		{
			var exam = new ExamItems();

			InitializeComponent();
			this.DataContext = new ExamsPanelViewModel(exam);
		}


	}
}
