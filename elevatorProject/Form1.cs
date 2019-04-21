using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elevatorProject
{
    public partial class Form1 : Form
    {

        //upDoorClose.Enable = false
        //upDoorOpen.Enable = false;
        //downDoorClose.Enable = false;
        //downDoorOpen.Enable = false;
        //upToDown.Enable = false;
        //downToUp.Enable = false;
        

        public static Boolean vertDoor = false;
        public static Boolean horDoor = false;
        public static Boolean upOpen = false;
        public static Boolean upClose = false;
        public static Boolean downOpen = false;
        public static Boolean downClose = false;

        Controllers Ctrl = new Controllers();
        Requests Reqs = new Requests();


        public Form1()
        {
            InitializeComponent();
            //Controllers Ctrl = new Controllers();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            upLeftDoor.BringToFront();
            upRightDoor.BringToFront();
            if (lift.Location.Y < 290)
            {
                indicator1.Text = " 1 ";
                indicator2.Text = " 1 ";
            }
            else
            {
                indicator1.Text = " G ";
                indicator2.Text = " G ";
            }
    }

        private void lift_Click(object sender, EventArgs e)
        {
 
           

        }

        private void rectangleShape4_Click(object sender, EventArgs e)
        {

        }

        private void UpReqBtn_Click(object sender, EventArgs e)
        {
            DownToUp.Enabled = false;
            upDoorClose.Enabled = false;
            upDoorOpen.Enabled = false;
            downDoorClose.Enabled = false;
            downDoorOpen.Enabled = false;
            
            upToDown.Enabled = true;
            downOpen = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            upDoorOpen.Enabled = false;
            downDoorClose.Enabled = false;
            downDoorOpen.Enabled = false;
            upToDown.Enabled = false;
            upDoorOpen.Enabled = false;
            DownToUp.Enabled = false;

            Ctrl.close(upDoorClose);
            upClose = true;
            upOpen = false;

        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

            downDoorClose.Enabled = false;
            downDoorOpen.Enabled = false;
            upToDown.Enabled = false;
            upDoorClose.Enabled = false;
            DownToUp.Enabled = false;

            Ctrl.open(upDoorOpen);
            upOpen = true;
            upClose = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {


            upDoorOpen.Enabled = false;
            downDoorOpen.Enabled = false;
            upToDown.Enabled = false;
            upDoorClose.Enabled = false;
            DownToUp.Enabled = false;

            Ctrl.close(downDoorClose);
            downClose = true;
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {

            upDoorOpen.Enabled = false;
            downDoorClose.Enabled = false;
            upToDown.Enabled = false;
            upDoorClose.Enabled = false;
            DownToUp.Enabled = false;
            Ctrl.open(downDoorOpen);
            downOpen = true;
            //downDoorOpen.Enabled = true;
        }


        private void downLeftDoor_Click(object sender, EventArgs e)
        {

        }

        private void upDoorClose_Tick(object sender, EventArgs e)
        {
            if (!(upLeftDoor.Location.X > 66))
            {
                upLeftDoor.Left += 1;
                upRightDoor.Left -= 1;
            }
        }
        private void upDoorOpen_Tick(object sender, EventArgs e)
        {
            if (this.lift.Location.Y < 290)
            {
                if (!(upLeftDoor.Location.X < 30))
                {
                    upLeftDoor.Left -= 1;
                    upRightDoor.Left += 1;
                }
            }

        }

        private void upToDown_Tick(object sender, EventArgs e)
        {
            if (upClose)
            {
                if (!(this.lift.Location.Y > 425))
                {
                    controller2 Down = new controller2();
                    Down.down(lift);

                    indicator1.Text = " G ";
                    indicator2.Text = " G ";
                }
                else
                {

                    if (!(downLeftDoor.Location.X < 30))
                    {
                        downLeftDoor.Left -= 1;
                        downRightDoor.Left += 1;
                    }
                }
            }
            else
            {
                if (!(upLeftDoor.Location.X > 66))
                {
                    upLeftDoor.Left += 1;
                    upRightDoor.Left -= 1;
                }
                    else
                    {
                        if (!(this.lift.Location.Y > 425))
                        {
                            this.lift.Top += 1;

                            indicator1.Text = " G ";
                            indicator2.Text = " G ";
                        }
                        else
                        {
                            if (this.lift.Location.Y > 290)
                            {
                                if (!(downLeftDoor.Location.X < 30))
                                {
                                    downLeftDoor.Left -= 1;
                                    downRightDoor.Left += 1;
                                }
                            }

                        }
                    }
                }
            }
        






        private void downDoorOpen_Tick(object sender, EventArgs e)
        {
            if (this.lift.Location.Y > 290)
            {
                if (!(downLeftDoor.Location.X < 30))
                {
                    downLeftDoor.Left -= 1;
                    downRightDoor.Left += 1;
                }
            }

        }

        private void downDoorClose_Tick(object sender, EventArgs e)
        {
            if (this.lift.Location.Y > 290)
            {
                if (!(downLeftDoor.Location.X > 66))
                {
                    
                    downLeftDoor.Left += 1;
                    downRightDoor.Left -= 1;
                }
            }
        }

        private void DownToUp_Tick(object sender, EventArgs e)
        {

            if (downClose)
            {
                if (!(this.lift.Location.Y < 41))
                {
                    this.lift.Top -= 1;

                    indicator1.Text = " G ";
                    indicator2.Text = " G ";
                }
                else
                {
                    if (!(upLeftDoor.Location.X < 66))
                    {
                       upLeftDoor.Left -= 1;
                        upRightDoor.Left += 1;
                    }
                }
            }
            else
            {
                if (!(downLeftDoor.Location.X > 66))
                {
                    downLeftDoor.Left += 1;
                    downRightDoor.Left -= 1;
                }
                else
                {
                    if (!(this.lift.Location.Y < 41))
                    {
                        this.lift.Top -= 1;

                        indicator1.Text = " 1 ";
                        indicator2.Text = " 1 ";
                    }
                    else
                    {
                        if (this.lift.Location.Y < 290)
                        {
                            if (!(upLeftDoor.Location.X < 30))
                            {
                                upLeftDoor.Left -= 1;
                                upRightDoor.Left += 1;
                            }
                        }

                    }
                }
            }
        }

        private void DownReqBtn_Click(object sender, EventArgs e)
        {
            upDoorClose.Enabled = false;
            upDoorOpen.Enabled = false;
            downDoorClose.Enabled = false;
            downDoorOpen.Enabled = false;
            upToDown.Enabled = false;

            DownToUp.Enabled = true;
            upOpen = true;
        }

}
}