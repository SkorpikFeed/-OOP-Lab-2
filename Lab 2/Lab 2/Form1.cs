using Microsoft.VisualBasic;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PeriodicPublication first = new PeriodicPublication();
            first.Info();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a;
            double b;
            int c;
            a = Convert.ToString(Interaction.InputBox("¬вед≥ть назву виданн€", "¬веденн€", "ћоЇ ¬иданн€"));
            c = Convert.ToInt16(Interaction.InputBox("¬вед≥ть к≥льк≥сть випуск≥в на р≥к", "¬веденн€", "12"));
            b = Convert.ToDouble(Interaction.InputBox("¬вед≥ть варт≥сть п≥дписки", "¬веденн€", "140,0"));
            PeriodicPublication second = new PeriodicPublication(b, a, c);
            second.Info();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}