using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Root.Reports;
using Excel = Microsoft.Office.Interop.Excel;

namespace CartAgenda
{
    public partial class formHome : Form
    {
        private int id;
        private string nome;
        private string senha;

        public formHome(int id, string nome, string senha)
        {
            InitializeComponent();
            
            lbNome.Text = nome;

            gbFiltro.Enabled = false;

            this.id = id;
            this.nome = nome;
            this.senha = senha;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            formUpdate update = new formUpdate();
            update.Show();
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            formInsert insert = new formInsert(this.id, this.nome, this.senha);
            insert.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            formDelete delete = new formDelete();
            delete.Show();
        }

        //Utilizando a classe Report.NET para gerar um PDF
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (printDialog1.ShowDialog() == DialogResult.OK)
                    this.printDocument1.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Gerar arquivo !!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void formHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdCartAgendaDataSet.vwPessoaJuridica' table. You can move, or remove it, as needed.
            //var filtro = c => 

            this.vwPessoaJuridicaTableAdapter.Fill(this.bdCartAgendaDataSet.vwPessoaJuridica);
            this.vwPessoaFisicaTableAdapter.Fill(this.bdCartAgendaDataSet.vwPessoaFisica);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.vwPessoaJuridicaTableAdapter.Fill(this.bdCartAgendaDataSet.vwPessoaJuridica);
            this.vwPessoaFisicaTableAdapter.Fill(this.bdCartAgendaDataSet.vwPessoaFisica);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle rect1 = new Rectangle(150, 10, Width, 200);

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            Graphics cabecalho = e.Graphics;

            String drawString = "_____________CartAgenda_____________\n\n";
            drawString += "Por Alex Alves Silva\n\n\n";
            Font drawFont = new Font("Arial", 20);
            PointF drawPoint = new PointF(150.0F, 150.0F);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            cabecalho.DrawString(drawString, drawFont, drawBrush, rect1, stringFormat);

            String drawString1 = "-> Pessoa Física\n";
            DataGridViewCell cel = null;
            int count = 0, temp = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0) temp = 5;
                    else if (j == 1) temp = 25;
                    else temp = 20;

                    cel = dataGridView1[j, i];
                    if (cel.Value != null)
                    {
                        count = cel.Value.ToString().Length;
                        drawString1 += cel.Value.ToString();
                        for (int k = 0; k < temp - count; k++)
                            drawString1 += " ";
                    }
                    else
                        drawString1 += "";
                }
                drawString1 += "\n\n\n";
            }


            drawString1 += "-> Pessoa Jurídica\n";
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0) temp = 5;
                    else if (j == 1) temp = 25;
                    else temp = 20;

                    cel = dataGridView2[j, i];
                    if (cel.Value != null)
                    {
                        count = cel.Value.ToString().Length;
                        drawString1 += cel.Value.ToString();
                        for (int k = 0; k < temp - count; k++)
                            drawString1 += " ";
                    }
                    else
                        drawString1 += "";
                }
                drawString1 += "\n\n";
            }

            Font drawFont1 = new Font("Lucida Console", 12);
            PointF drawPoint1 = new PointF(150.0F, 150.0F);
            SolidBrush drawBrush1 = new SolidBrush(Color.Black);

            e.Graphics.DrawString(drawString1, drawFont1, drawBrush1, drawPoint1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string msg = "Sistema feito com intuito de armazenar contatos e/ou endereços de pessoas e/ou empresas\n";
            msg += "O usuário poderá inserir, editar, visualizar e excluir seus contatos, além de poder imprimir e exportá-los";

            MessageBox.Show(msg);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvar = new SaveFileDialog(); // novo 

            Excel.Application App; // Aplicação Excel
            Excel.Workbook WorkBook; // Pasta
            Excel.Worksheet WorkSheet; // Planilha
            object misValue = System.Reflection.Missing.Value;

            App = new Excel.Application();
            WorkBook = App.Workbooks.Add(misValue);
            WorkSheet = (Excel.Worksheet)WorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;

            for (i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataGridView1[j, i];
                    WorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }

            // define algumas propriedades da caixa salvar
            salvar.Title = "Exportar para Excel";
            salvar.Filter = "Arquivo do Excel *.xls | *.xls";
            salvar.ShowDialog(); // mostra

            // salva o arquivo
            WorkBook.SaveAs(salvar.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,

            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            WorkBook.Close(true, misValue, misValue);
            App.Quit(); // encerra o excel

            MessageBox.Show("Exportado com sucesso!");
        }
    }
}
