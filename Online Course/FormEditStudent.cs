﻿using Database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Course
{
    public partial class FormEditStudent : Form
    {
        ArrayList list = new ArrayList();
        Student student = new Student();
        public FormEditStudent()
        {
            InitializeComponent();
        }

        private void guna2TextBoxEditIdStudent_TextChanged(object sender, EventArgs e)
        {
            if(guna2TextBoxEditIdStudent.Text.Length <= 2)
            {
                list = student.QueryData("id", guna2TextBoxEditIdStudent.Text);
                if(list.Count > 0)
                {
                    guna2TextBoxEditNameStudent.Text = ((Student)list[0]).Name;
                    guna2TextBoxEditUsernameStudent.Text = ((Student)list[0]).Username;
                    guna2TextBoxEditPasswordStudent.Text = ((Student)list[0]).GetPass();
                }
                else
                {
                    MessageBox.Show($"Data Tidak Ditemukan", "Error");
                }
            }
        }

        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Student newStu = new Student(
                    guna2TextBoxEditIdStudent.Text,
                    guna2TextBoxEditNameStudent.Text,
                    guna2TextBoxEditUsernameStudent.Text,
                    guna2TextBoxEditPasswordStudent.Text);

                newStu.Update();
                MessageBox.Show("Data Berhasil Diubah", "Info");
                guna2ButtonClear_Click(guna2ButtonAdd, e);
            }
            catch(Exception error)
            {
                MessageBox.Show($"Gagal Mengubah Data, Error : {error}", "Error");
            }
        }

        private void guna2ButtonClear_Click(object sender, EventArgs e)
        {
            guna2TextBoxEditIdStudent.Clear();
            guna2TextBoxEditIdStudent.Focus();
            guna2TextBoxEditUsernameStudent.Clear();
            guna2TextBoxEditPasswordStudent.Clear();
            guna2TextBoxEditNameStudent.Clear();
        }
    }
}