using SharpGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interactice_cube
{
    public partial class Form1 : Form
    {
        OpenGL gl = new OpenGL();
        float eyeX;
        float eyeY;
        float eyeZ;
        float viewpointX;
        float viewpointY;
        float viewpointZ;
        List<KubsGL> kubuSaraksts = new List<KubsGL>();
        Boolean fixOnMouse;
        int previousX;
        int previousY;
        float sizeToApply;
        int chosenKubs = 0;
        KubsGL k1 = new KubsGL();

        public Form1()
        {
            InitializeComponent();
  
            kubuSaraksts.Add(new KubsGL(-1, 1, -7, 45, 45, 1));
            kubuSaraksts.Add(new KubsGL(-5, 1, -7, 45, 45, 0.5f));
            kubuSaraksts.Add(new KubsGL(-2, 1, -7, 0, 0, 0.1f));

            foreach (KubsGL kubs in kubuSaraksts)
            {
                this.comboBoxKubs.Items.Add(kubs);
            }
                
            
        }

        void updatevalues()
        {
            eyeX = this.trackBarEyeX.Value;
            eyeY = this.trackBarEyeY.Value;
            eyeZ = this.trackBarEyeZ.Value;

            viewpointX = this.trackBarViewpointX.Value;
            viewpointY = this.trackBarViewpointY.Value;
            viewpointZ = this.trackBarViewpointZ.Value;

            sizeToApply = this.trackBarIzmers.Value;

        }

        private void openGLControl2_Load(object sender, EventArgs e)
        {

        }

        private void openGLControl2_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {
            updatevalues();

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            gl.LoadIdentity();

            gl.LookAt(eyeX, eyeY, eyeZ, viewpointX, viewpointY, viewpointZ, 0, 1, 0);

            foreach (KubsGL kubs in kubuSaraksts)
            {
                kubs.zimetKubu(gl);
            }

            //kubuSaraksts[0].setRotX(kubuSaraksts[0].getRotX() + 1f);

            kubuSaraksts[chosenKubs].setIzmers(sizeToApply);

        }

        private void openGLControl2_MouseMove(object sender, MouseEventArgs e)
        {
            if (fixOnMouse)
            {
                int nowX = e.X;
                int nowY = e.Y;
                float diffX = nowX - previousX;
                float diffY = nowY - previousY;

                kubuSaraksts[chosenKubs].setRotX(kubuSaraksts[0].getRotX() + diffX);
                kubuSaraksts[chosenKubs].setRotY(kubuSaraksts[0].getRotY() + diffY);

                previousX = nowX;
                previousY = nowY;


            }
        }

        private void openGLControl2_MouseDown(object sender, MouseEventArgs e)
        {
            fixOnMouse = true;
            previousX = e.X;
            previousY = e.Y;
        }

        private void openGLControl2_MouseUp(object sender, MouseEventArgs e)
        {
            fixOnMouse = false;
        }

        private void comboBoxKubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenKubs = this.comboBoxKubs.SelectedIndex;
            Console.WriteLine(chosenKubs);
        }
    }
}
