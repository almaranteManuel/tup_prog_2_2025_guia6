using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {

        List<Persona> personas = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fDatos = new Form2();

            fDatos.ShowDialog();

            if (fDatos.DialogResult == DialogResult.OK)
            {
                string nombre = fDatos.textBox1.Text;

                Persona p = null;

                if (fDatos.radioButton1.Checked)
                {
                    p = new Persona(nombre);
                }
                else if (fDatos.radioButton2.Checked)
                {
                    string cuit = fDatos.textBox2.Text;
                    p = new PersonaJuridica(nombre, cuit);
                }

                if (p != null)
                {
                    personas.Add(p);
                }
                else
                {
                    MessageBox.Show("Tenes que elegir el tipo");
                    fDatos.ShowDialog();
                }
            }
        }

        protected void Actualizar()
        {
            listBox1.Items.Clear();

            foreach (Persona p in personas)
            {
                listBox1.Items.Add(p.Describir());
            }

            
        }
    }
}
