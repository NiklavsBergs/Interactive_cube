namespace Interactice_cube
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openGLControl2 = new SharpGL.OpenGLControl();
            this.trackBarEyeX = new System.Windows.Forms.TrackBar();
            this.trackBarEyeY = new System.Windows.Forms.TrackBar();
            this.trackBarEyeZ = new System.Windows.Forms.TrackBar();
            this.trackBarViewpointZ = new System.Windows.Forms.TrackBar();
            this.trackBarViewpointY = new System.Windows.Forms.TrackBar();
            this.trackBarViewpointX = new System.Windows.Forms.TrackBar();
            this.trackBarIzmers = new System.Windows.Forms.TrackBar();
            this.comboBoxKubs = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEyeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEyeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEyeZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarViewpointZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarViewpointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarViewpointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIzmers)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLControl2
            // 
            this.openGLControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openGLControl2.DrawFPS = true;
            this.openGLControl2.Location = new System.Drawing.Point(0, 0);
            this.openGLControl2.Name = "openGLControl2";
            this.openGLControl2.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl2.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl2.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl2.Size = new System.Drawing.Size(1003, 514);
            this.openGLControl2.TabIndex = 0;
            this.openGLControl2.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl2_OpenGLDraw);
            this.openGLControl2.Load += new System.EventHandler(this.openGLControl2_Load);
            this.openGLControl2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openGLControl2_MouseDown);
            this.openGLControl2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.openGLControl2_MouseMove);
            this.openGLControl2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.openGLControl2_MouseUp);
            // 
            // trackBarEyeX
            // 
            this.trackBarEyeX.Location = new System.Drawing.Point(22, 21);
            this.trackBarEyeX.Minimum = -10;
            this.trackBarEyeX.Name = "trackBarEyeX";
            this.trackBarEyeX.Size = new System.Drawing.Size(104, 45);
            this.trackBarEyeX.TabIndex = 1;
            // 
            // trackBarEyeY
            // 
            this.trackBarEyeY.Location = new System.Drawing.Point(22, 87);
            this.trackBarEyeY.Minimum = -10;
            this.trackBarEyeY.Name = "trackBarEyeY";
            this.trackBarEyeY.Size = new System.Drawing.Size(104, 45);
            this.trackBarEyeY.TabIndex = 2;
            // 
            // trackBarEyeZ
            // 
            this.trackBarEyeZ.Location = new System.Drawing.Point(22, 158);
            this.trackBarEyeZ.Maximum = 20;
            this.trackBarEyeZ.Name = "trackBarEyeZ";
            this.trackBarEyeZ.Size = new System.Drawing.Size(104, 45);
            this.trackBarEyeZ.TabIndex = 3;
            this.trackBarEyeZ.Value = 10;
            // 
            // trackBarViewpointZ
            // 
            this.trackBarViewpointZ.Location = new System.Drawing.Point(887, 158);
            this.trackBarViewpointZ.Minimum = -10;
            this.trackBarViewpointZ.Name = "trackBarViewpointZ";
            this.trackBarViewpointZ.Size = new System.Drawing.Size(104, 45);
            this.trackBarViewpointZ.TabIndex = 6;
            // 
            // trackBarViewpointY
            // 
            this.trackBarViewpointY.Location = new System.Drawing.Point(887, 87);
            this.trackBarViewpointY.Minimum = -10;
            this.trackBarViewpointY.Name = "trackBarViewpointY";
            this.trackBarViewpointY.Size = new System.Drawing.Size(104, 45);
            this.trackBarViewpointY.TabIndex = 5;
            // 
            // trackBarViewpointX
            // 
            this.trackBarViewpointX.Location = new System.Drawing.Point(887, 21);
            this.trackBarViewpointX.Minimum = -10;
            this.trackBarViewpointX.Name = "trackBarViewpointX";
            this.trackBarViewpointX.Size = new System.Drawing.Size(104, 45);
            this.trackBarViewpointX.TabIndex = 4;
            // 
            // trackBarIzmers
            // 
            this.trackBarIzmers.Location = new System.Drawing.Point(432, 21);
            this.trackBarIzmers.Minimum = 1;
            this.trackBarIzmers.Name = "trackBarIzmers";
            this.trackBarIzmers.Size = new System.Drawing.Size(104, 45);
            this.trackBarIzmers.TabIndex = 7;
            this.trackBarIzmers.Value = 1;
            // 
            // comboBoxKubs
            // 
            this.comboBoxKubs.FormattingEnabled = true;
            this.comboBoxKubs.Location = new System.Drawing.Point(22, 287);
            this.comboBoxKubs.Name = "comboBoxKubs";
            this.comboBoxKubs.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKubs.TabIndex = 8;
            this.comboBoxKubs.SelectedIndexChanged += new System.EventHandler(this.comboBoxKubs_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1003, 514);
            this.Controls.Add(this.comboBoxKubs);
            this.Controls.Add(this.trackBarIzmers);
            this.Controls.Add(this.trackBarViewpointZ);
            this.Controls.Add(this.trackBarViewpointY);
            this.Controls.Add(this.trackBarViewpointX);
            this.Controls.Add(this.trackBarEyeZ);
            this.Controls.Add(this.trackBarEyeY);
            this.Controls.Add(this.trackBarEyeX);
            this.Controls.Add(this.openGLControl2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEyeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEyeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEyeZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarViewpointZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarViewpointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarViewpointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIzmers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl2;
        private System.Windows.Forms.TrackBar trackBarEyeX;
        private System.Windows.Forms.TrackBar trackBarEyeY;
        private System.Windows.Forms.TrackBar trackBarEyeZ;
        private System.Windows.Forms.TrackBar trackBarViewpointZ;
        private System.Windows.Forms.TrackBar trackBarViewpointY;
        private System.Windows.Forms.TrackBar trackBarViewpointX;
        private System.Windows.Forms.TrackBar trackBarIzmers;
        private System.Windows.Forms.ComboBox comboBoxKubs;
    }
}

