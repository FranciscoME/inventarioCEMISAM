
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Presentacion.Formulario;
using System.Security.Cryptography;
using System.IO;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        protected string cv = "012345#Z0liDSn4k3.6789";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (getv(cv) == false)
                throw new System.ArgumentException();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            

            if ((txtUsuario.Text == "cemisam") && (txtContrasena.Text == "inventarioCEMISAM"))
            {
                this.Hide();
                FormPrincipal frmPrincipal = new FormPrincipal();
                frmPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Fallo de autenticacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            //this.Hide();
            //FormPrincipal frmPrincipal = new FormPrincipal();
            //frmPrincipal.Show();
        }



        static bool getv(string ser)
        {
            bool val = false;
            string salida =  ser;
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] hashValue;
            byte[] message = UE.GetBytes(salida);
            SHA512Managed hashString = new SHA512Managed();
            string encodedData = Convert.ToBase64String(message);
            string hex = "";
            hashValue = hashString.ComputeHash(UE.GetBytes(encodedData));
            foreach (byte x in hashValue)
            {
                hex += String.Format("{0:x2}", x);
            }
            string hex2 = hex;

            Rijndael rijndael = Rijndael.Create();
            byte[] key = UTF8Encoding.UTF8.GetBytes("hola");
            byte[] iv = UTF8Encoding.UTF8.GetBytes("hola");
            int keySize = 32;
            int ivSize = 16;

            Array.Resize(ref key, keySize);
            Array.Resize(ref iv, ivSize);
            Console.WriteLine(ser);
            Console.WriteLine(hex + "\n");
            //encryptToFile(hex, @"C:\Windows\wsf.text", key, iv);
            Console.WriteLine( decryptFromFile(@"C:\wsf.text", key, iv));
            if (hex2 == decryptFromFile(@"C:\wsf.text", key, iv))
                val = true;
            return val;
        }

        public static string decryptFromFile(String filename, byte[] Key, byte[] IV)
        {
            // Crear un flujo para el archivo a generarse

            FileStream fileStream = File.Open(filename, FileMode.OpenOrCreate);

            // Crear una instancia del algoritmo Rijndael

            Rijndael RijndaelAlg = Rijndael.Create();

            // Crear un flujo de cifrado basado en el flujo de los datos

            CryptoStream cryptoStream = new CryptoStream(fileStream,
                                                         RijndaelAlg.CreateDecryptor(Key, IV),
                                                         CryptoStreamMode.Read);

            // Crear un flujo de lectura basado en el flujo de cifrado

            StreamReader streamReader = new StreamReader(cryptoStream);

            // Descifrar el mensaje a través del flujo de lectura

            string plainMessage = streamReader.ReadLine();

            // Cerrar los flujos utilizados

            streamReader.Close();
            cryptoStream.Close();
            fileStream.Close();

            return plainMessage;
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar == (int)Keys.Enter)
            {
                if ((txtUsuario.Text == "cemisam") && (txtContrasena.Text == "inventarioCEMISAM"))
                {
                    this.Hide();
                    FormPrincipal frmPrincipal = new FormPrincipal();
                    frmPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("Fallo de autenticacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
