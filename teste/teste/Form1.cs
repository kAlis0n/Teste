namespace teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class OrigemDestino
        {
            public string Display { get; set; }
            public decimal Valor { get; set; }
            public OrigemDestino(string display, decimal valor)
            {
                Display = display;
                Valor = valor;
            }
        }

        private void DisplayOrigemDestino()
        {
            cbOrigemDestino.DisplayMember = "Display";
            cbOrigemDestino.ValueMember = "Valor";

            List<OrigemDestino> rs_min = new List<OrigemDestino>();
            rs_min.Add(new OrigemDestino("011 para 016", 1.9m));
            rs_min.Add(new OrigemDestino("016 para 011", 2.9m));
            rs_min.Add(new OrigemDestino("011 para 017", 1.7m));
            rs_min.Add(new OrigemDestino("017 para 011", 2.7m));
            rs_min.Add(new OrigemDestino("011 para 018", 0.9m));
            rs_min.Add(new OrigemDestino("018 para 011", 1.9m));

            cbOrigemDestino.DataSource = rs_min;
        }

        public class Planos
        {
            public string Display { get; set; }
            public int Valor { get; set; }
            public Planos(string display, int valor)
            {
                Display = display;
                Valor = valor;
            }
        }

        private void DisplayPlanos()
        {
            cbPlano.DisplayMember = "Display";
            cbPlano.ValueMember = "Valor";

            List<Planos> plano = new List<Planos>();
            plano.Add(new Planos("FaleMais 30", 30));
            plano.Add(new Planos("FaleMais 60", 60));
            plano.Add(new Planos("FaleMais 120", 120));

            cbPlano.DataSource = plano;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayOrigemDestino();
            DisplayPlanos();
            Calcular();
        }

        private void Calcular()
        {
            decimal tarifa, sem, com, acrescimo;
            int min, plano, excesso;

            if (cbOrigemDestino.SelectedIndex == -1 || cbPlano.SelectedIndex == -1) return;
            if (!(cbOrigemDestino.SelectedValue is decimal) || !(cbPlano.SelectedValue is int)) return;

            int.TryParse(txtTempo.Text, out min);

            tarifa = (decimal)cbOrigemDestino.SelectedValue;
            plano = (int)cbPlano.SelectedValue;

            sem = min * tarifa;

            com = 0;
            if (min > plano)
            {
                excesso = min - plano;
                acrescimo = tarifa * 1.1m;
                com = excesso * acrescimo;
            }

            txtSemPlano.Text = sem.ToString("C2");
            txtComPlano.Text = com.ToString("C2");
        }

        private void txtTempo_TextChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void cbOrigemDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void cbPlano_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void txtTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
