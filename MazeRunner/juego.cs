using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MazeRunner
{
    public partial class juego : Form
    {

        bool keysA = false, keysS = false, keysD = false, keysW = false;
        Image[] caminar = new Image[10];
        Image[] portal = new Image[8];
        Image[] moneda = new Image[7];
        int contderecha = 0, contmov = 0, conttimer3 = 0;
        int puntaje = 0;
        string orientacion = "DERECHA";



        public juego()
        {
            InitializeComponent();

            caminar[0] = MazeRunner.Properties.Resources.caminar1;
            caminar[1] = MazeRunner.Properties.Resources.caminar2;
            caminar[2] = MazeRunner.Properties.Resources.caminar3;
            caminar[3] = MazeRunner.Properties.Resources.caminar4;
            caminar[4] = MazeRunner.Properties.Resources.caminar5;
            caminar[5] = MazeRunner.Properties.Resources.caminar6;
            caminar[6] = MazeRunner.Properties.Resources.caminar7;
            caminar[7] = MazeRunner.Properties.Resources.caminar8;
            caminar[8] = MazeRunner.Properties.Resources.caminar9;
            caminar[9] = MazeRunner.Properties.Resources.caminar10;



            portal[0] = MazeRunner.Properties.Resources.portal1;
            portal[1] = MazeRunner.Properties.Resources.portal2;
            portal[2] = MazeRunner.Properties.Resources.portal3;
            portal[3] = MazeRunner.Properties.Resources.portal4;
            portal[4] = MazeRunner.Properties.Resources.portal5;
            portal[5] = MazeRunner.Properties.Resources.portal6;
            portal[6] = MazeRunner.Properties.Resources.portal7;
            portal[7] = MazeRunner.Properties.Resources.portal8;

            moneda[0] = MazeRunner.Properties.Resources.moneda1;
            moneda[1] = MazeRunner.Properties.Resources.moneda2;
            moneda[2] = MazeRunner.Properties.Resources.moneda3;
            moneda[3] = MazeRunner.Properties.Resources.moneda4;
            moneda[4] = MazeRunner.Properties.Resources.moneda5;
            moneda[5] = MazeRunner.Properties.Resources.moneda6;
            moneda[6] = MazeRunner.Properties.Resources.moneda7;





        }
        //Esta es la derecha
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (keysD == true)
            {
                personaje.Location = new Point(personaje.Location.X + 1, personaje.Location.Y);
                contderecha++;
                if (orientacion == "IZQUIERDA")
                {

                    caminar[0].RotateFlip(RotateFlipType.Rotate180FlipY);
                    caminar[1].RotateFlip(RotateFlipType.Rotate180FlipY);
                    caminar[2].RotateFlip(RotateFlipType.Rotate180FlipY);
                    caminar[3].RotateFlip(RotateFlipType.Rotate180FlipY);
                    caminar[4].RotateFlip(RotateFlipType.Rotate180FlipY);
                    caminar[5].RotateFlip(RotateFlipType.Rotate180FlipY);
                    caminar[6].RotateFlip(RotateFlipType.Rotate180FlipY);
                    caminar[7].RotateFlip(RotateFlipType.Rotate180FlipY);
                    caminar[8].RotateFlip(RotateFlipType.Rotate180FlipY);
                    caminar[9].RotateFlip(RotateFlipType.Rotate180FlipY);
                    orientacion = "DERECHA";
                }
                if (orientacion == "ABAJO")
                {

                    caminar[0].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[1].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[2].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[3].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[4].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[5].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[6].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[7].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[8].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[9].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    orientacion = "DERECHA";

                }

                if (orientacion == "ARRIBA")
                {

                    caminar[0].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[1].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[2].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[3].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[4].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[5].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[6].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[7].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[8].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[9].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    orientacion = "DERECHA";

                }

                if (contderecha == 4)
                {
                    personaje.Image = caminar[contmov];
                    contmov++;


                    if (contmov == 9)
                    {
                        contmov = 0;
                    }
                    contderecha = 0;

                }
            }


            //Esta es la izquierda
            if (keysA == true)
            {
                personaje.Location = new Point(personaje.Location.X - 1, personaje.Location.Y);

                if (orientacion == "DERECHA")
                {

                    caminar[0].RotateFlip(RotateFlipType.Rotate180FlipY);
                    caminar[1].RotateFlip(RotateFlipType.Rotate180FlipY);
                    caminar[2].RotateFlip(RotateFlipType.Rotate180FlipY);
                    caminar[3].RotateFlip(RotateFlipType.Rotate180FlipY);
                    caminar[4].RotateFlip(RotateFlipType.Rotate180FlipY);
                    caminar[5].RotateFlip(RotateFlipType.Rotate180FlipY);
                    caminar[6].RotateFlip(RotateFlipType.Rotate180FlipY);
                    caminar[7].RotateFlip(RotateFlipType.Rotate180FlipY);
                    caminar[8].RotateFlip(RotateFlipType.Rotate180FlipY);
                    caminar[9].RotateFlip(RotateFlipType.Rotate180FlipY);
                    orientacion = "IZQUIERDA";
                }



                if (orientacion == "ABAJO")
                {

                    caminar[0].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[1].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[2].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[3].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[4].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[5].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[6].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[7].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[8].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[9].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    orientacion = "DERECHA";

                }



                if (orientacion == "ARRIBA")
                {

                    caminar[0].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[1].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[2].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[3].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[4].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[5].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[6].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[7].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[8].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[9].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    orientacion = "DERECHA";

                }
                contderecha++;
                if (contderecha == 4)
                {
                    personaje.Image = caminar[contmov];
                    contmov++;


                    if (contmov == 9)
                    {
                        contmov = 0;
                    }
                    contderecha = 0;

                }
            }

            //Este es abajo
            if (keysS == true)
            {
                personaje.Location = new Point(personaje.Location.X, personaje.Location.Y + 1);

                if (orientacion == "DERECHA")
                {

                    caminar[0].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[1].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[2].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[3].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[4].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[5].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[6].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[7].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[8].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[9].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    orientacion = "ABAJO";

                }
                contderecha++;
                if (contderecha == 4)
                {
                    personaje.Image = caminar[contmov];
                    contmov++;


                    if (contmov == 9)
                    {
                        contmov = 0;
                    }
                    contderecha = 0;

                }
            }


            //Este es arriba
            if (keysW == true)
            {
                personaje.Location = new Point(personaje.Location.X, personaje.Location.Y - 1);

                if (orientacion == "DERECHA")
                {

                    caminar[0].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[1].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[2].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[3].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[4].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[5].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[6].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[7].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[8].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    caminar[9].RotateFlip(RotateFlipType.Rotate180FlipXY);
                    orientacion = "ARRIBA";

                }
                contderecha++;
                if (contderecha == 4)
                {
                    personaje.Image = caminar[contmov];
                    contmov++;


                    if (contmov == 9)
                    {
                        contmov = 0;
                    }
                    contderecha = 0;

                }


            }
            if (personaje.Bounds.IntersectsWith(panel1.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel2.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel3.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel4.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel5.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel6.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel7.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel8.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel9.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel10.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel11.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }

            if (personaje.Bounds.IntersectsWith(panel13.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel14.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel15.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel16.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel17.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel18.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel19.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel20.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel21.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel22.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel23.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel24.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel25.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel26.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel27.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel28.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel29.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel30.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel31.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel32.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel33.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel34.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(panel35.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Jajaja haz muerto!!");
                timer2.Stop();
                timer3.Stop();
            }
            if (personaje.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Felicidades haz encontrado la salida!!!");
                timer2.Stop();
                timer3.Stop();
                
            }
            



        }


        private void juego_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                keysD = true;
            }

            if (e.KeyCode == Keys.A)
            {
                keysA = true;
            }
            if (e.KeyCode == Keys.S)
            {
                keysS = true;
            }
            if (e.KeyCode == Keys.W)
            {
                keysW = true;
            }

        }

        private void juego_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                keysD = false;
            }

            if (e.KeyCode == Keys.A)
            {
                keysA = false;
            }
            if (e.KeyCode == Keys.S)
            {
                keysS = false;
            }
            if (e.KeyCode == Keys.W)
            {
                keysW = false;
            }
        }

        private void juego_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            pictureBox1.Image = portal[conttimer3];
            if (conttimer3 == 7)
            {
                conttimer3 = 0;
            }
            conttimer3++;



        }

        private void timer2_Tick(object sender, EventArgs e)
        {           
        }

        private void personaje_Click(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
                      
       }



        }
    }



