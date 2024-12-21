namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        Boolean check;
        int suma;
        int partidas;
        int clicks;
        Boolean ganador;

        void Enable()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
        }
        void Score()
        {

            //Condiciones de Victoria para X

            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                MessageBox.Show("¡El Jugador X es el Ganador!");
                suma = int.Parse(label5.Text);
                partidas = int.Parse(label8.Text);
                label5.Text = Convert.ToString(suma + 1);
                label8.Text = Convert.ToString(partidas + 1);
                Enable();
                ganador = true;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                MessageBox.Show("¡El Jugador X es el Ganador!");
                suma = int.Parse(label5.Text);
                partidas = int.Parse(label8.Text);
                label5.Text = Convert.ToString(suma + 1);
                label8.Text = Convert.ToString(partidas + 1);
                Enable();
                ganador = true;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                MessageBox.Show("¡El Jugador X es el Ganador!");
                suma = int.Parse(label5.Text);
                partidas = int.Parse(label8.Text);
                label5.Text = Convert.ToString(suma + 1);
                label8.Text = Convert.ToString(partidas + 1);
                Enable();
                ganador = true;
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                MessageBox.Show("¡El Jugador X es el Ganador!");
                suma = int.Parse(label5.Text);
                partidas = int.Parse(label8.Text);
                label5.Text = Convert.ToString(suma + 1);
                label8.Text = Convert.ToString(partidas + 1);
                Enable();
                ganador = true;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                MessageBox.Show("¡El Jugador X es el Ganador!");
                suma = int.Parse(label5.Text);
                partidas = int.Parse(label8.Text);
                label5.Text = Convert.ToString(suma + 1);
                label8.Text = Convert.ToString(partidas + 1);
                Enable();
                ganador = true;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                MessageBox.Show("¡El Jugador X es el Ganador!");
                suma = int.Parse(label5.Text);
                partidas = int.Parse(label8.Text);
                label5.Text = Convert.ToString(suma + 1);
                label8.Text = Convert.ToString(partidas + 1);
                Enable();
                ganador = true;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                MessageBox.Show("¡El Jugador X es el Ganador!");
                suma = int.Parse(label5.Text);
                partidas = int.Parse(label8.Text);
                label5.Text = Convert.ToString(suma + 1);
                label8.Text = Convert.ToString(partidas + 1);
                Enable();
                ganador = true;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                MessageBox.Show("¡El Jugador X es el Ganador!");
                suma = int.Parse(label5.Text);
                partidas = int.Parse(label8.Text);
                label5.Text = Convert.ToString(suma + 1);
                label8.Text = Convert.ToString(partidas + 1);
                Enable();
                ganador = true;
            }

            //Condiciones de Victoria para O

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                MessageBox.Show("¡El Jugador O es el Ganador!");
                suma = int.Parse(label4.Text);
                partidas = int.Parse(label8.Text);
                label4.Text = Convert.ToString(suma + 1);
                label8.Text = Convert.ToString(partidas + 1);
                Enable();
                ganador = true;
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                MessageBox.Show("¡El Jugador O es el Ganador!");
                suma = int.Parse(label4.Text);
                partidas = int.Parse(label8.Text);
                label4.Text = Convert.ToString(suma + 1);
                label8.Text = Convert.ToString(partidas + 1);
                Enable();
                ganador = true;
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                MessageBox.Show("¡El Jugador O es el Ganador!");
                suma = int.Parse(label4.Text);
                partidas = int.Parse(label8.Text);
                label4.Text = Convert.ToString(suma + 1);
                label8.Text = Convert.ToString(partidas + 1);
                Enable();
                ganador = true;
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                MessageBox.Show("¡El Jugador O es el Ganador!");
                suma = int.Parse(label4.Text);
                partidas = int.Parse(label8.Text);
                label4.Text = Convert.ToString(suma + 1);
                label8.Text = Convert.ToString(partidas + 1);
                Enable();
                ganador = true;
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                MessageBox.Show("¡El Jugador O es el Ganador!");
                suma = int.Parse(label4.Text);
                partidas = int.Parse(label8.Text);
                label4.Text = Convert.ToString(suma + 1);
                label8.Text = Convert.ToString(partidas + 1);
                Enable();
                ganador = true;
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                MessageBox.Show("¡El Jugador O es el Ganador!");
                suma = int.Parse(label4.Text);
                partidas = int.Parse(label8.Text);
                label4.Text = Convert.ToString(suma + 1);
                label8.Text = Convert.ToString(partidas + 1);
                Enable();
                ganador = true;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                MessageBox.Show("¡El Jugador O es el Ganador!");
                suma = int.Parse(label4.Text);
                partidas = int.Parse(label8.Text);
                label4.Text = Convert.ToString(suma + 1);
                label8.Text = Convert.ToString(partidas + 1);
                Enable();
                ganador = true;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                MessageBox.Show("¡El Jugador O es el Ganador!");
                suma = int.Parse(label4.Text);
                partidas = int.Parse(label8.Text);
                label4.Text = Convert.ToString(suma + 1);
                label8.Text = Convert.ToString(partidas + 1);
                Enable();
                ganador = true;
            }

            //Condicion de Empate

            if (clicks == 9 && ganador == false)
            {
                MessageBox.Show("¡Empate!");
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        //Funcionalidad al clickear en los botones
        private void button1_Click(object sender, EventArgs e)
        {
            clicks++;
            if (check == false)
            {
                button1.Text = "X";
                check = true;
            }
            else
            {
                button1.Text = "O";
                check = false;
            }
            Score();
            button1.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clicks++;
            if (check == false)
            {
                button2.Text = "X";
                check = true;
            }
            else
            {
                button2.Text = "O";
                check = false;
            }
            Score();
            button2.Enabled = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            clicks++;
            if (check == false)
            {
                button3.Text = "X";
                check = true;
            }
            else
            {
                button3.Text = "O";
                check = false;
            }
            Score();
            button3.Enabled = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            clicks++;
            if (check == false)
            {
                button4.Text = "X";
                check = true;
            }
            else
            {
                button4.Text = "O";
                check = false;
            }
            Score();
            button4.Enabled = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            clicks++;
            if (check == false)
            {
                button5.Text = "X";
                check = true;
            }
            else
            {
                button5.Text = "O";
                check = false;
            }
            Score();
            button5.Enabled = false;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            clicks++;
            if (check == false)
            {
                button6.Text = "X";
                check = true;
            }
            else
            {
                button6.Text = "O";
                check = false;
            }
            Score();
            button6.Enabled = false;
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            clicks++;
            if (check == false)
            {
                button7.Text = "X";
                check = true;
            }
            else
            {
                button7.Text = "O";
                check = false;
            }
            Score();
            button7.Enabled = false;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            clicks++;
            if (check == false)
            {
                button8.Text = "X";
                check = true;
            }
            else
            {
                button8.Text = "O";
                check = false;
            }
            Score();
            button8.Enabled = false;
        }
        private void button9_Click_1(object sender, EventArgs e)
        {
            clicks++;
            if (check == false)
            {
                button9.Text = "X";
                check = true;
            }
            else
            {
                button9.Text = "O";
                check = false;
            }
            Score();
            button9.Enabled = false;
        }

        //Nueva Partida
        private void button12_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button9.Enabled = true;
            button8.Enabled = true;
            button7.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            label4.Text = "0";
            label5.Text = "0";
            label8.Text = "0";

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;

            MessageBox.Show("¡Nueva partida iniciada!");
            clicks = 0;
            ganador = false;
            check = false;
        }

        //Reiniciar partida
        private void button10_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button9.Enabled = true;
            button8.Enabled = true;
            button7.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;

            MessageBox.Show("Nueva ronda iniciada");
            clicks = 0;
            ganador = false;
        }

        //Salir del juego
        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}