﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Mike Bashkatov
 * Date: 26/04/2019
 * Name: Exersise 2
 */
namespace Exersise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList scoreArray = new ArrayList();

        List<scoreStruct> findGrades = new List<scoreStruct>();

        public struct scoreStruct
        {
            public int number;
            public string grade;
        }

        private scoreStruct scoreStructure;
        private void Form1_Load(object sender, EventArgs e)
        {

            scoreStructure.number = 299;
            scoreStructure.grade = "F";
            scoreArray.Add(scoreStructure);
            findGrades.Add(scoreStructure);

            scoreStructure.number = 349;
            scoreStructure.grade = "D";
            scoreArray.Add(scoreStructure);
            findGrades.Add(scoreStructure);

            scoreStructure.number = 399;
            scoreStructure.grade = "C";
            scoreArray.Add(scoreStructure);
            findGrades.Add(scoreStructure);

            scoreStructure.number = 449;
            scoreStructure.grade = "B";
            scoreArray.Add(scoreStructure);
            findGrades.Add(scoreStructure);

            scoreStructure.number = 500;
            scoreStructure.grade = "A";
            scoreArray.Add(scoreStructure);
            findGrades.Add(scoreStructure);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userNumber = Convert.ToInt32(txtScore.Text);

            int maxItem = scoreArray.Count - 1;

            if (userNumber > ((scoreStruct)scoreArray[maxItem]).number)
            {
                MessageBox.Show($"Your mark is: {((scoreStruct)scoreArray[maxItem]).grade}");
                return;
            }
            foreach (scoreStruct item in scoreArray)
            {
                if (userNumber <= item.number)
                {
                    MessageBox.Show($"Your grade is: {item.grade}");
                    return;
                }

                else
                {
                    continue;
                }
            }

            scoreStruct foundGrade = findGrades.Where(g => g.number >= userNumber).FirstOrDefault();

            MessageBox.Show($"Your grade is: {foundGrade.grade}");
        }
    }
}
