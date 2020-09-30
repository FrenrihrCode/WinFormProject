using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp; //se importa la librería para los iconos de fontawesome

namespace WinFormProject
{
    public partial class Form1 : Form
    {
        //campos para declarar los iconos fa
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelSideMenu.Controls.Add(leftBorderBtn);
        }

        private void ActiveIconBtn(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(212, 175, 55);
                currentBtn.ForeColor = color;

                leftBorderBtn.BackColor = color;
            }
        }
    }
}
