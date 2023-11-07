using SharpGL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactice_cube
{
    internal class KubsGL
    {
        float cX = 0;
        float cY = 0;
        float cZ = 0;
        float rotX = 0;
        float rotY = 0;
        float izmers = 0;

        public KubsGL()
        {
            this.cX = 0;
            this.cY = 0;
            this.cZ = 0;
            this.rotX = 0;
            this.rotY = 0; 
            this.izmers = 0;
        }

        public void setRotX(float rotX)
        {
            this.rotX = rotX;
        }

        public void setRotY(float rotY)
        {
            this.rotY = rotY;
        }

        public void setIzmers(float izmers)
        {
            this.izmers = izmers;
        }

        public float getRotX()
        {
            return rotX;
        }

        public float getRotY()
        {
            return rotY;
        }

        public float getIzmers()
        {
            return izmers;
        }

        public KubsGL(float cX, float cY, float cZ, float rotX, float rotY, float izmers)
        {
            this.cX = cX;
            this.cY = cY;
            this.cZ = cZ;
            this.rotX = rotX;
            this.rotY = rotY;
            this.izmers = izmers;
        }

        public override string ToString()
        {
            return "KUBS: (" + cX + ", " + cY + ", " + cZ + ") ar izm: " + izmers;
        }

        public void paraditKubu()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("KUBS:");
            Console.WriteLine("Centrs: ("+ cX + ", " + cY + ", " + cZ + ")");
            Console.WriteLine("Rotacija X: " + rotX);
            Console.WriteLine("Rotacija Y: " + rotY);
            Console.WriteLine("Izmers: " + izmers);
        }

        public void zimetKubu(OpenGL gl)
        {
            gl.PushMatrix();
            gl.Translate(cX, cY, cZ); //paarvietoties pa kreisi un dziljaak
            gl.Rotate(rotX, 1.0f, 0.0f, 0.0f); // pagriezt pa x graadiem ap y asi
            gl.Rotate(rotY, 0.0f, 1.0f, 0.0f); // pagriezt pa x graadiem ap y asi


            gl.Color(1.0f, 1.0f, 1.0f);
            gl.Scale(izmers, izmers, izmers);
            gl.Begin(OpenGL.GL_QUADS);

            //blue
            gl.Color(0.0f, 0.0f, 1.0f);
            //gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(2.0f, -1.0f, 1.0f);

            //blue
            gl.Color(0.0f, 0.0f, 1.0f);
            //gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(2.0f, -1.0f, -1.0f);

            //blue
            gl.Color(0.0f, 0.0f, 1.0f);
            //gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(2.0f, 1.0f, -1.0f);

            //blue
            gl.Color(0.0f, 0.0f, 1.0f);
            //gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(2.0f, 1.0f, 1.0f);

            //--------------------------

            //green
            gl.Color(0.0f, 1.0f, 0.0f);
            //gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(2.0f, -1.0f, -1.0f);

            //green
            gl.Color(0.0f, 1.0f, 0.0f);
            //gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(2.0f, 1.0f, -1.0f);

            //green
            gl.Color(0.0f, 1.0f, 0.0f);
            //gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(4.0f, 1.0f, -1.0f);

            //green
            gl.Color(0.0f, 1.0f, 0.0f);
            //gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(4.0f, -1.0f, -1.0f);

            //---------------------------

            //red
            gl.Color(1.0f, 0.0f, 0.0f);
            //gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(4.0f, 1.0f, -1.0f);

            //red
            gl.Color(1.0f, 0.0f, 0.0f);
            //gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(4.0f, -1.0f, -1.0f);

            //red
            gl.Color(1.0f, 0.0f, 0.0f);
            //gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(4.0f, -1.0f, 1.0f);

            //red
            gl.Color(1.0f, 0.0f, 0.0f);
            //gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(4.0f, 1.0f, 1.0f);

            //---------------------------

            //green
            gl.Color(0.0f, 1.0f, 0.0f);
            //gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(2.0f, -1.0f, 1.0f);

            //green
            gl.Color(0.0f, 1.0f, 0.0f);
            //gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(2.0f, 1.0f, 1.0f);

            //green
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(4.0f, 1.0f, 1.0f);

            //green
            gl.Color(0.0f, 1.0f, 0.0f);
            //gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(4.0f, -1.0f, 1.0f);

            //--------------------------

            //blue
            gl.Color(0.0f, 0.0f, 1.0f);
            //gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(2.0f, 1.0f, -1.0f);

            //blue
            gl.Color(0.0f, 0.0f, 1.0f);
            //gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(4.0f, 1.0f, -1.0f);

            //green
            gl.Color(0.0f, 0.0f, 1.0f);
            //gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(4.0f, 1.0f, 1.0f);

            //green
            gl.Color(0.0f, 0.0f, 1.0f);
            //gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(2.0f, 1.0f, 1.0f);

            //--------------------------

            //red bot
            gl.Color(1.0f, 0.0f, 0.0f);
            //gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(2.0f, -1.0f, -1.0f);

            //red bot
            gl.Color(1.0f, 0.0f, 0.0f);
            //gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(4.0f, -1.0f, -1.0f);

            //red bot
            gl.Color(1.0f, 0.0f, 0.0f);
            //gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(4.0f, -1.0f, 1.0f);

            //red bot
            gl.Color(1.0f, 0.0f, 0.0f);
            //gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(2.0f, -1.0f, 1.0f);
            gl.End();
            gl.PopMatrix();
        }



    }
}
