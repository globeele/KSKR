using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_rab_1
{
    public partial class MainForm : Form
    {
        static double lyamM = 209;
        static double cM = 920;
        static double roM = 2700;
        static double lyamB = 45;
        static double cB = 500;
        static double roB = 7800;
        
        double aM = lyamM / (cM * roM);
        double aB = lyamB / (cB * roB);



        double leftM, middleM, rightM;
        double leftB, middleB, rightB;
       

        double tempLeft, tempRight, tempBegin;

        double[,] matrix;
        double dx;
        double dt;
        double lengthDetails;
        double time;
        int countLength;
        int countTime;
        int size;

       

        public MainForm()
        {
            InitializeComponent();
            labelLyamM.Text = lyamM.ToString();
            labelCM.Text = cM.ToString();
            labelRoM.Text = roM.ToString();
                    
        }

        private void butCalc_Click(object sender, EventArgs e)
        {
            if (radioButtonRaz.Checked)
            {


                tempBegin = Convert.ToDouble(textBoxTempBegin.Text);
                tempLeft = Convert.ToDouble(textBoxTempLeft.Text);
                tempRight = Convert.ToDouble(textBoxTemRight.Text);
                lengthDetails = Convert.ToDouble(textBoxLength.Text);
                countLength = Convert.ToInt32(textBoxX.Text);
                time = Convert.ToDouble(textBoxTime.Text);
                countTime = Convert.ToInt32(textBoxT.Text);
                dt = time / countTime;
                dx = lengthDetails / countLength;

                size = countLength * countTime;

                matrix = new double[size, size + 1];


                leftM = -dt * aM / Math.Pow(dx, 2);
                middleM = -1 + 2.1 * dt * aM / Math.Pow(dx, 2);
                rightM = -dt * aM / Math.Pow(dx, 2); ;
                leftB = -dt * aB / Math.Pow(dx, 2);
                middleB = -1 + 2.1 * dt * aB / Math.Pow(dx, 2);
                rightB = -dt * aB / Math.Pow(dx, 2);
               

                for (int i = 0; i < size; i++)
                {
                    if (i < countLength)
                    {
                        matrix[i, i] = 1;
                    }
                    else
                    {
                        if (i % countLength == 0)
                        {
                            matrix[i, i] = 1;
                        }
                        else if (i % countLength == countLength - 1)
                        {
                            matrix[i, i] = 1;
                        }
                        else
                        {
                            if ((i % countLength) * dx < lengthDetails / 2)
                            {
                                matrix[i, i] = 1;
                                matrix[i, i - (countLength + 1)] = leftM;
                                matrix[i, i - countLength] = middleM;
                                matrix[i, i - (countLength - 1)] = rightM;
                            }
                            else if ((i % countLength) * dx >= lengthDetails / 2 && (i % countLength) * dx < (lengthDetails / 2) *2)
                            {
                                matrix[i, i] = 1;
                                matrix[i, i - (countLength + 1)] = leftB;
                                matrix[i, i - countLength] = middleB;
                                matrix[i, i - (countLength - 1)] = rightB;
                            }
                           
                        }
                    }
                }

                for (int i = 0; i < countLength; i++)
                    matrix[i, size] = tempBegin;
                for (int i = 0; i < matrix.GetLength(0); i++)
                    if (i % countLength == 0)
                        matrix[i, size] = tempLeft;
                    else if (i % countLength == countLength - 1)
                        matrix[i, size] = tempRight;

                
                Gauss();

               

                FormResults formResults = new FormResults(countTime, countLength, dx, matrix, size);
                formResults.Show();
                //Draw();
            }
            
            else if (radioButtonElem.Checked)
            {
                tempBegin = Convert.ToDouble(textBoxTempBegin.Text);
                tempLeft = Convert.ToDouble(textBoxTempLeft.Text);
                tempRight = Convert.ToDouble(textBoxTemRight.Text);
                lengthDetails = Convert.ToDouble(textBoxLength.Text);
                countLength = Convert.ToInt32(textBoxX.Text);
                time = Convert.ToDouble(textBoxTime.Text);
                countTime = Convert.ToInt32(textBoxT.Text);
                dt = time / countTime;
                dx = lengthDetails / countLength;

                size = countLength * countTime;

                double[,] temp = new double[countTime, countLength];

                double[,] matrC = new double[,] { { 2, 1 }, { 1, 2 } };
                double[,] matrK = new double[,] { { 1, -1 }, { -1, 1 } };
                double A = 0.0001;

                double koefCM = cM * roM * A * dx / 6;
                double koefCB = cB * roB * A * dx / 6;
               // double koefCL = cL * roL * A * dx / 6;

                double koefKM = A * lyamM / dx;
                double koefKB = A * lyamB / dx;
               // double koefKL = A * lyamL / dx;

                double[,] matrixCM = new double[2, 2];
                double[,] matrixCB = new double[2, 2];
                double[,] matrixCL = new double[2, 2];

                double[,] matrixKM = new double[2, 2];
                double[,] matrixKB = new double[2, 2];
                double[,] matrixKL = new double[2, 2];

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        matrixCM[i, j] = koefCM * matrC[i, j];
                        matrixCB[i, j] = koefCB * matrC[i, j];
                        //matrixCL[i, j] = koefCL * matrC[i, j];

                        matrixKM[i, j] = koefKM * matrK[i, j];
                        matrixKB[i, j] = koefKB * matrK[i, j];
                       // matrixKL[i, j] = koefKL * matrK[i, j];
                    }
                }

                double[,] C = new double[countLength, countLength];
                double[,] K = new double[countLength, countLength];

                for (int i = 0; i < countLength - 1; i++)
                {
                    if ((i % countLength) * dx < lengthDetails / 2)
                    {
                        C[i, i] += matrixCM[0, 0];
                        C[i, i + 1] += matrixCM[0, 1];
                        C[i + 1, i] += matrixCM[1, 0];
                        C[i + 1, i + 1] += matrixCM[1, 1];
                        K[i, i] += matrixKM[0, 0];
                        K[i, i + 1] += matrixKM[0, 1];
                        K[i + 1, i] += matrixKM[1, 0];
                        K[i + 1, i + 1] += matrixKM[1, 1];

                    }
                    else if ((i % countLength) * dx >= lengthDetails / 2 && (i % countLength) * dx < (lengthDetails / 2) * 2)
                    {
                        C[i, i] += matrixCB[0, 0];
                        C[i, i + 1] += matrixCB[0, 1];
                        C[i + 1, i] += matrixCB[1, 0];
                        C[i + 1, i + 1] += matrixCB[1, 1];
                        K[i, i] += matrixKB[0, 0];
                        K[i, i + 1] += matrixKB[0, 1];
                        K[i + 1, i] += matrixKB[1, 0];
                        K[i + 1, i + 1] += matrixKB[1, 1];
                    }
                   
                }

                double[,] B = new double[countLength, countLength + 1];
                double[,] P = new double[countLength, countLength];

                for (int i = 0; i < countLength; i++)
                {
                    for (int j = 0; j < countLength; j++)
                    {
                        B[i, j] += K[i, j] + (2 / dt) * C[i, j];
                        P[i, j] += (2 / dt) * C[i, j] - K[i, j];
                    }
                }

                double[] f = new double[countLength];
                f[0] = -tempLeft;
                f[1] = -tempLeft;
                f[countLength - 2] = -tempRight;
                f[countLength - 1] = -tempRight;


                double[] prevTemp = new double[countLength];
                for (int i = 0; i < prevTemp.Length; i++)
                    prevTemp[i] = tempBegin;
                for (int i = 0; i < prevTemp.Length; i++)
                    temp[0, i] = prevTemp[i];

                for (int i = 1; i < countTime; i++)
                {
                    double[] d1 = MultipleMatrixVector(P, prevTemp);
                    double[] d2 = DoubleVector(f);
                    double[] d3 = SubstractVectorVector(d1, d2);

                    matrix = new double[countLength, countLength + 1];

                    for (int j = 0; j < countLength; j++)
                        for (int k = 0; k < countLength;k++ )
                            matrix[j,k] = B[j,k];


                    for (int j = 0; j < countLength; j++)
                        matrix[j, countLength] = d3[j];

                    Gauss();

                    for (int j = 0; j < countLength; j++)
                        temp[i, j] = matrix[j, countLength];

                    for (int j = 0; j < countLength; j++)
                        prevTemp[j] = matrix[j, countLength];
                }

                FormResults formResults = new FormResults(countTime, countLength, dx, temp);
                formResults.Show();

            }
        }

        public double[] MultipleMatrixVector(double[,] a, double[] b)
        {
            double[] c = new double[a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0); i++)
                for (int k = 0; k < a.GetLength(0); k++)
                    c[i] += a[i, k] * b[k];
            return c;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public double[] SubstractVectorVector(double[] a, double[] b)
        {
            double[] c = new double[a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0); i++)
                c[i] = a[i] - b[i];
            return c;
        }

        public double[] DoubleVector(double[] a)
        {
            double[] c = new double[a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0); i++)
                c[i] = a[i] * 2;
            return c;
        }

        private void Gauss()
        {

            double tmp;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                tmp = matrix[i, i];

                tmp = matrix[i, i];
                double dd;
                for (int j = matrix.GetLength(0); j >= i; j--)
                {
                    dd = matrix[i, j];
                    dd /= tmp;
                    matrix[i, j] = dd;
                }
                for (int j = i + 1; j < matrix.GetLength(0); j++)
                {
                    tmp = matrix[j, i];
                    if (tmp != 0)
                        for (int k = matrix.GetLength(0); k >= i; k--)
                            matrix[j, k] -= tmp * matrix[i, k];
                }

            }

            for (int i = matrix.GetLength(0) - 1; i > 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    matrix[j, matrix.GetLength(0)] -= matrix[j, i] * matrix[i, matrix.GetLength(0)];
                    matrix[j, i] = 0;
                }
            }
        }

        private void radioButtonRaz_CheckedChanged(object sender, EventArgs e)
        {
            label17.Text = "Температура на левом конце:";
            label18.Text = "Температура на правом конце:";
        }

        private void radioButtonNeyavn_CheckedChanged(object sender, EventArgs e)
        {
            label17.Text = "Температура на левом конце:";
            label18.Text = "Температура на правом конце:";
        }

        private void radioButtonElem_CheckedChanged(object sender, EventArgs e)
        {
            label17.Text = "Тепловой поток:";
            label18.Text = "Конвекция:";
        }
    }
}
