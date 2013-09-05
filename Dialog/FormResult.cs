﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LimsProject
{

    public partial class FormResult : LibraryBasicForm.FormConfirm
    {
        public string Message
        {
            get {
                return laMsg.Text;
            }
            set {
                laMsg.Text = value;
            }
        }

        public FormResult()
        {
            InitializeComponent();
        }
    }
}
