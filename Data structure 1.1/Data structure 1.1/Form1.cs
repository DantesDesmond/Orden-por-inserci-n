﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_structure_1._1
{
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void Insert_Load(object sender, EventArgs e)
        {
            // omitido aproposito, chao error(El metodo de carga del formulario me dio un error de la nada, asi que lo comente).
        }

        void orderinsert(int[] vector)

        {
            int startVector = vector.Length;
            int posicion = 0;
            int auxiliar = 0;


            for (int i = 1; i < startVector; i++)
            {
                posicion = 0;

                for (int z = i; z > 0; z--)

                {

                    if (vector[i + posicion] < vector[z - 1])

                    {

                        auxiliar = vector[i + posicion];
                        vector[i + posicion] = vector[z - 1];
                        vector[z - 1] = auxiliar;
                        posicion--;

                    }
                    else
                    { 
                    
                    break;

                    }
                
                }
             
            }

            textBox1.Text += "Vector como va" + Environment.NewLine;

            foreach (int element in vector)

            {

                textBox1.Text += element + Environment.NewLine;
            
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int [] vector = {2,25,50,78,98,12,80,79,100,40,55,32,1,200};

            textBox1.Text = "Vector a lo bruto" + Environment.NewLine;

            foreach (int element in vector)

            { 
            
                textBox1.Text += element + Environment.NewLine;

            }

            orderinsert(vector);
        }
    }
}
