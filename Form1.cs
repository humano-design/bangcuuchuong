namespace bangcuuchuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void hopso_ValueChanged(object sender, EventArgs e)
        {
            listso.Items.Clear();
            int so= Int32.Parse(hopso.Value.ToString());
            for (int i = 1; i <= 10; i++) {

                listso.Items.Add (so + "x" + i + "=" + (so * i)+Environment.NewLine);

            } 
        }
    }
}
