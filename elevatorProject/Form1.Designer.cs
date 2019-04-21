namespace elevatorProject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape6 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.downLeftDoor = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.downRightDoor = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.upLeftDoor = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.upRightDoor = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape5 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lift = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.UpReqBtn = new System.Windows.Forms.Button();
            this.DownReqBtn = new System.Windows.Forms.Button();
            this.upDoorClose = new System.Windows.Forms.Timer(this.components);
            this.upDoorOpen = new System.Windows.Forms.Timer(this.components);
            this.downDoorClose = new System.Windows.Forms.Timer(this.components);
            this.downDoorOpen = new System.Windows.Forms.Timer(this.components);
            this.upToDown = new System.Windows.Forms.Timer(this.components);
            this.DownToUp = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.indicator1 = new System.Windows.Forms.Label();
            this.indicator2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape6,
            this.rectangleShape4,
            this.lineShape4,
            this.downLeftDoor,
            this.downRightDoor,
            this.upLeftDoor,
            this.upRightDoor,
            this.rectangleShape5,
            this.rectangleShape3,
            this.lineShape3,
            this.rectangleShape2,
            this.lineShape2,
            this.rectangleShape1,
            this.lineShape1,
            this.lift});
            this.shapeContainer1.Size = new System.Drawing.Size(828, 487);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape6
            // 
            this.rectangleShape6.Location = new System.Drawing.Point(291, 15);
            this.rectangleShape6.Name = "rectangleShape6";
            this.rectangleShape6.Size = new System.Drawing.Size(134, 223);
            // 
            // rectangleShape4
            // 
            this.rectangleShape4.Location = new System.Drawing.Point(295, 364);
            this.rectangleShape4.Name = "rectangleShape4";
            this.rectangleShape4.Size = new System.Drawing.Size(134, 223);
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 1;
            this.lineShape4.X2 = 245;
            this.lineShape4.Y1 = 291;
            this.lineShape4.Y2 = 290;
            // 
            // downLeftDoor
            // 
            this.downLeftDoor.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.downLeftDoor.Location = new System.Drawing.Point(66, 425);
            this.downLeftDoor.Name = "downLeftDoor";
            this.downLeftDoor.Size = new System.Drawing.Size(47, 145);
            this.downLeftDoor.Click += new System.EventHandler(this.downLeftDoor_Click);
            // 
            // downRightDoor
            // 
            this.downRightDoor.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.downRightDoor.Location = new System.Drawing.Point(110, 425);
            this.downRightDoor.Name = "downRightDoor";
            this.downRightDoor.Size = new System.Drawing.Size(58, 145);
            // 
            // upLeftDoor
            // 
            this.upLeftDoor.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.upLeftDoor.Location = new System.Drawing.Point(30, 37);
            this.upLeftDoor.Name = "upLeftDoor";
            this.upLeftDoor.Size = new System.Drawing.Size(47, 145);
            // 
            // upRightDoor
            // 
            this.upRightDoor.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.upRightDoor.Location = new System.Drawing.Point(146, 37);
            this.upRightDoor.Name = "upRightDoor";
            this.upRightDoor.Size = new System.Drawing.Size(58, 145);
            // 
            // rectangleShape5
            // 
            this.rectangleShape5.Location = new System.Drawing.Point(62, 418);
            this.rectangleShape5.Name = "rectangleShape5";
            this.rectangleShape5.Size = new System.Drawing.Size(114, 153);
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BackColor = System.Drawing.SystemColors.Control;
            this.rectangleShape3.Cursor = System.Windows.Forms.Cursors.Default;
            this.rectangleShape3.Location = new System.Drawing.Point(13, 69);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(46, 115);
            // 
            // lineShape3
            // 
            this.lineShape3.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 35;
            this.lineShape3.X2 = 190;
            this.lineShape3.Y1 = 183;
            this.lineShape3.Y2 = 182;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.SystemColors.Control;
            this.rectangleShape2.Cursor = System.Windows.Forms.Cursors.Default;
            this.rectangleShape2.Location = new System.Drawing.Point(13, 454);
            this.rectangleShape2.Name = "rectangleShape1";
            this.rectangleShape2.Size = new System.Drawing.Size(46, 115);
            // 
            // lineShape2
            // 
            this.lineShape2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape2.Name = "lineShape1";
            this.lineShape2.X1 = 34;
            this.lineShape2.X2 = 189;
            this.lineShape2.Y1 = 570;
            this.lineShape2.Y2 = 569;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(13, 68);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(46, 115);
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 35;
            this.lineShape1.X2 = 190;
            this.lineShape1.Y1 = 183;
            this.lineShape1.Y2 = 182;
            // 
            // lift
            // 
            this.lift.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lift.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.lift.BorderWidth = 5;
            this.lift.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.lift.FillGradientColor = System.Drawing.Color.Gray;
            this.lift.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.lift.Location = new System.Drawing.Point(70, 41);
            this.lift.Name = "lift";
            this.lift.Size = new System.Drawing.Size(91, 139);
            this.lift.Click += new System.EventHandler(this.lift_Click);
            // 
            // UpReqBtn
            // 
            this.UpReqBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpReqBtn.BackgroundImage")));
            this.UpReqBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpReqBtn.Location = new System.Drawing.Point(13, 491);
            this.UpReqBtn.Name = "UpReqBtn";
            this.UpReqBtn.Size = new System.Drawing.Size(29, 23);
            this.UpReqBtn.TabIndex = 1;
            this.UpReqBtn.UseVisualStyleBackColor = true;
            this.UpReqBtn.Click += new System.EventHandler(this.UpReqBtn_Click);
            // 
            // DownReqBtn
            // 
            this.DownReqBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DownReqBtn.BackgroundImage")));
            this.DownReqBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DownReqBtn.Location = new System.Drawing.Point(13, 94);
            this.DownReqBtn.Name = "DownReqBtn";
            this.DownReqBtn.Size = new System.Drawing.Size(29, 23);
            this.DownReqBtn.TabIndex = 2;
            this.DownReqBtn.UseVisualStyleBackColor = true;
            this.DownReqBtn.Click += new System.EventHandler(this.DownReqBtn_Click);
            // 
            // upDoorClose
            // 
            this.upDoorClose.Interval = 10;
            this.upDoorClose.Tick += new System.EventHandler(this.upDoorClose_Tick);
            // 
            // upDoorOpen
            // 
            this.upDoorOpen.Interval = 10;
            this.upDoorOpen.Tick += new System.EventHandler(this.upDoorOpen_Tick);
            // 
            // downDoorClose
            // 
            this.downDoorClose.Interval = 10;
            this.downDoorClose.Tick += new System.EventHandler(this.downDoorClose_Tick);
            // 
            // downDoorOpen
            // 
            this.downDoorOpen.Interval = 10;
            this.downDoorOpen.Tick += new System.EventHandler(this.downDoorOpen_Tick);
            // 
            // upToDown
            // 
            this.upToDown.Interval = 10;
            this.upToDown.Tick += new System.EventHandler(this.upToDown_Tick);
            // 
            // DownToUp
            // 
            this.DownToUp.Interval = 10;
            this.DownToUp.Tick += new System.EventHandler(this.DownToUp_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(304, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TxtLabel
            // 
            this.TxtLabel.AutoSize = true;
            this.TxtLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtLabel.Location = new System.Drawing.Point(319, 40);
            this.TxtLabel.Name = "TxtLabel";
            this.TxtLabel.Size = new System.Drawing.Size(70, 13);
            this.TxtLabel.TabIndex = 4;
            this.TxtLabel.Text = "Control Panel";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(370, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(304, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 46);
            this.button2.TabIndex = 8;
            this.button2.Text = "G";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(370, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 46);
            this.button3.TabIndex = 8;
            this.button3.Text = "1";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(370, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(304, 507);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 46);
            this.button4.TabIndex = 13;
            this.button4.Text = "G";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(370, 456);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(319, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Control Panel";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(304, 456);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // indicator1
            // 
            this.indicator1.AutoSize = true;
            this.indicator1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.indicator1.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicator1.ForeColor = System.Drawing.Color.Red;
            this.indicator1.Location = new System.Drawing.Point(318, 68);
            this.indicator1.Name = "indicator1";
            this.indicator1.Size = new System.Drawing.Size(71, 20);
            this.indicator1.TabIndex = 15;
            this.indicator1.Text = "label3";
            // 
            // indicator2
            // 
            this.indicator2.AutoSize = true;
            this.indicator2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.indicator2.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold);
            this.indicator2.ForeColor = System.Drawing.Color.Red;
            this.indicator2.Location = new System.Drawing.Point(318, 418);
            this.indicator2.Name = "indicator2";
            this.indicator2.Size = new System.Drawing.Size(71, 20);
            this.indicator2.TabIndex = 16;
            this.indicator2.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(828, 487);
            this.Controls.Add(this.indicator2);
            this.Controls.Add(this.indicator1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TxtLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DownReqBtn);
            this.Controls.Add(this.UpReqBtn);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape lift;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button UpReqBtn;
        private System.Windows.Forms.Button DownReqBtn;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape5;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape upRightDoor;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape upLeftDoor;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape downLeftDoor;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape downRightDoor;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.Timer upDoorClose;
        private System.Windows.Forms.Timer upDoorOpen;
        private System.Windows.Forms.Timer downDoorClose;
        private System.Windows.Forms.Timer downDoorOpen;
        private System.Windows.Forms.Timer upToDown;
        private System.Windows.Forms.Timer DownToUp;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TxtLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label indicator1;
        private System.Windows.Forms.Label indicator2;
        private System.Windows.Forms.Timer timer1;
    }
}

